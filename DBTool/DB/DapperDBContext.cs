using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IBM.Data.DB2.Core;

namespace DBTool.DB
{
    // ReSharper disable once InconsistentNaming
    public class DapperDBContext : IDBContext
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private int? _commandTimeout = null;

        public bool IsTransactionStarted { get; private set; }
        public DapperDBContext(string dbConnection)
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            if (string.IsNullOrEmpty(dbConnection))
                throw new ArgumentNullException(nameof(DapperDBContext), "数据库连接字符串不能为空");
            _connection = new DB2Connection(dbConnection);
            _connection.Open();
        }

        #region 事务

        public void BeginTransaction()
        {
            if (IsTransactionStarted)
                throw new InvalidOperationException("有未提交的事务。");

            _transaction = _connection.BeginTransaction();
            IsTransactionStarted = true;
        }

        public void Commit()
        {
            if (!IsTransactionStarted)
                throw new InvalidOperationException("没有开启的事务。");

            _transaction.Commit();
            _transaction = null;

            IsTransactionStarted = false;
        }

        public void Rollback()
        {
            if (!IsTransactionStarted)
                throw new InvalidOperationException("没有开启的事务。");

            _transaction.Rollback();
            _transaction.Dispose();
            _transaction = null;

            IsTransactionStarted = false;
        }

        #endregion

        #region 查询等

        public int Execute(string sql, Hashtable table = null)
        {
            DynamicParameters param = BuildParams(table);
            return _connection.Execute(sql, param);
        }

        public async Task<int> ExecuteAsync(string sql, Hashtable table = null, CommandType commandType = CommandType.StoredProcedure)
        {
            DynamicParameters param = BuildParams(table);
            return await _connection.ExecuteAsync(sql, param, _transaction, _commandTimeout, commandType);
        }

        public async Task<bool> ExsitsAsync(string sql, Hashtable table = null)
        {
            DynamicParameters param = BuildParams(table);
            var result = await _connection.QueryAsync<int>(sql, param);
            if (result != null)
                return result.FirstOrDefault() > 0;
            return false;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, Hashtable table = null)
        {
            DynamicParameters param = BuildParams(table);
            return await _connection.QueryAsync<T>(sql, param, _transaction, _commandTimeout);
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, Hashtable table = null, CommandType commandType = CommandType.StoredProcedure)
        {
            DynamicParameters param = BuildParams(table);
            return await _connection.QueryFirstOrDefaultAsync<T>(sql, param, _transaction, _commandTimeout, commandType);
        }

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, Hashtable table = null, string splitOn = "Id", CommandType commandType = CommandType.StoredProcedure)
        {
            DynamicParameters param = BuildParams(table);
            return await _connection.QueryAsync(sql, map, param, _transaction, true, splitOn, _commandTimeout, commandType);
        }



        //public async Task<int?> InsertIdentity<T>(T entity)
        //{
        //    return await _connection.InsertAsync<T>(entity);
        //}

        //public async Task<Key> Insert<Key, T>(T entity)
        //{
        //    return await _connection.InsertAsync<Key, T>(entity);
        //}

        //public async Task<int> Delete<T>(T entity)
        //{
        //    return await _connection.DeleteAsync<T>(entity);
        //}

        private static DynamicParameters BuildParams(Hashtable table)
        {
            DynamicParameters dp = new DynamicParameters();
            if (table != null && table.Count > 0)
            {
                foreach (DictionaryEntry item in table)
                {
                    dp.Add(item.Key.ToString(), item.Value);
                }
            }

            return dp;
        }
        #endregion

        public void Dispose()
        {
            if (IsTransactionStarted)
                Rollback();

            _connection.Close();
            _connection.Dispose();
            _connection = null;
        }
    }
}