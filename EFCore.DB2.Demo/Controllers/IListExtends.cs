using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DB2.Demo.Controllers
{
    public static class IListExtends
    {
        public static async Task<List<TSource>> ToListAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            List<TSource> list = new List<TSource>();
            ConfiguredCancelableAsyncEnumerable<TSource>.Enumerator asyncEnumerator = source.AsAsyncEnumerable().WithCancellation(cancellationToken).GetAsyncEnumerator();
            try
            {
                while (await asyncEnumerator.MoveNextAsync())
                {
                    TSource current = asyncEnumerator.Current;
                    list.Add(current);
                }
            }
            finally
            {
                await asyncEnumerator.DisposeAsync();
            }

            return list;
        }
    }
}
