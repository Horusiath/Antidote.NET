#region copyright
// -----------------------------------------------------------------------
//  <copyright file="InteractiveTransaction.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Antidote.Transactions
{
    public class InteractiveTransaction : IAntidoteTransaction
    {
        public async Task AbortAsync(CancellationToken cancellation = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public async Task<CommitInfo> CommitAsync(CancellationToken cancellation = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public CrdtCounter Counter(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtCounter FatCounter(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtInteger Integer(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtGrowOnlyDictionary<TKey, TVal> GrowOnlyDictionary<TKey, TVal>(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtRemoveResetsDictionary<TKey, TVal> RemoveResetsDictionary<TKey, TVal>(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtAddWinsDictionary<TKey, TVal> Dictionary<TKey, TVal>(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtMultiValueRegister<T> MultiValueRegister<T>(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtRegister<T> Register<T>(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtAddWinsSet<T> Set<T>(string key)
        {
            throw new NotImplementedException();
        }

        public CrdtRemoveWinsSet<T> RemoveWinsSet<T>(string key)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync<T>(AntidoteObject<T> crdt, CancellationToken cancellation = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<T1, T2>> ReadBatchAsync<T1, T2>(AntidoteObject<T1> item1, AntidoteObject<T2> item2)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<T1, T2, T3>> ReadBatchAsync<T1, T2, T3>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<T1, T2, T3>> ReadBatchAsync<T1, T2, T3, T4>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<T1, T2, T3, T4>> ReadBatchAsync<T1, T2, T3, T4>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3,
            AntidoteObject<T4> item4)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<T1, T2, T3, T4, T5>> ReadBatchAsync<T1, T2, T3, T4, T5>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3,
            AntidoteObject<T4> item4, AntidoteObject<T5> item5)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<T1, T2, T3, T4, T5, T6>> ReadBatchAsync<T1, T2, T3, T4, T5, T6>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3,
            AntidoteObject<T4> item4, AntidoteObject<T5> item5, AntidoteObject<T6> item6)
        {
            throw new NotImplementedException();
        }
    }
}