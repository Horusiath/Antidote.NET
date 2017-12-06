#region copyright
// -----------------------------------------------------------------------
//  <copyright file="IAntidoteTransaction.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Antidote.Transactions
{
    public interface IAntidoteTransaction : ICrdtFactory, IDisposable
    {
        
    }
}