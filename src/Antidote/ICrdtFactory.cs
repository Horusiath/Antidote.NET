#region copyright
// -----------------------------------------------------------------------
//  <copyright file="ICrdtFactory.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Antidote.Proto;

namespace Antidote
{
    public interface ICrdtFactory
    {
        CrdtCounter Counter(string key);
        CrdtCounter FatCounter(string key);
        CrdtInteger Integer(string key);
        CrdtGrowOnlyDictionary<TKey, TVal> GrowOnlyDictionary<TKey, TVal>(string key);
        CrdtRemoveResetsDictionary<TKey, TVal> RemoveResetsDictionary<TKey, TVal>(string key);
        CrdtAddWinsDictionary<TKey, TVal> Dictionary<TKey, TVal>(string key);
        CrdtMultiValueRegister<T> MultiValueRegister<T>(string key);
        CrdtRegister<T> Register<T>(string key);
        CrdtAddWinsSet<T> Set<T>(string key);
        CrdtRemoveWinsSet<T> RemoveWinsSet<T>(string key);

        Task UpdateAsync<T>(AntidoteObject<T> crdt, CancellationToken cancellation = default(CancellationToken));
        Task<Tuple<T1, T2>> ReadBatchAsync<T1, T2>(AntidoteObject<T1> item1, AntidoteObject<T2> item2);
        Task<Tuple<T1, T2, T3>> ReadBatchAsync<T1, T2, T3>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3);
        Task<Tuple<T1, T2, T3>> ReadBatchAsync<T1, T2, T3, T4>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3);
        Task<Tuple<T1, T2, T3, T4>> ReadBatchAsync<T1, T2, T3, T4>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3, AntidoteObject<T4> item4);
        Task<Tuple<T1, T2, T3, T4, T5>> ReadBatchAsync<T1, T2, T3, T4, T5>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3, AntidoteObject<T4> item4, AntidoteObject<T5> item5);
        Task<Tuple<T1, T2, T3, T4, T5, T6>> ReadBatchAsync<T1, T2, T3, T4, T5, T6>(AntidoteObject<T1> item1, AntidoteObject<T2> item2, AntidoteObject<T3> item3, AntidoteObject<T4> item4, AntidoteObject<T5> item5, AntidoteObject<T6> item6);
    }
}