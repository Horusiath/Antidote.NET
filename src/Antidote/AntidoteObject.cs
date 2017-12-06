#region copyright
// -----------------------------------------------------------------------
//  <copyright file="AntidoteObject.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Antidote
{
    public class AntidoteObject<T>
    {
        public ICrdtFactory Parent { get; }

        public async Task<T> ReadAsync(CancellationToken cancellation = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}