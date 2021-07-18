using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DBTool.DB
{
    // ReSharper disable once InconsistentNaming
    public interface IDBContext : IDisposable
    {
        bool IsTransactionStarted { get; }

        void BeginTransaction();

        void Commit();

        void Rollback();

        Task<int> ExecuteAsync(string sql, Hashtable table = null, CommandType commandType = CommandType.StoredProcedure);

        Task<bool> ExsitsAsync(string sql, Hashtable table = null);

        Task<T> QueryFirstOrDefaultAsync<T>(string sql, Hashtable table = null, CommandType commandType = CommandType.StoredProcedure);

        Task<IEnumerable<T>> QueryAsync<T>(string sql, Hashtable table = null);

        int Execute(string sql, Hashtable table = null);
    }
}