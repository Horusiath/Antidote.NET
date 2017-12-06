#region copyright
// -----------------------------------------------------------------------
//  <copyright file="CrdtCounter.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Antidote
{
    public class CrdtCounter : AntidoteObject<long>
    {
        public CrdtCounter Increment(long value) => throw new NotImplementedException();
        public CrdtCounter Decrement(long value) => throw new NotImplementedException();

        public static CrdtCounter operator + (CrdtCounter counter, long value) => throw new NotImplementedException();
        public static CrdtCounter operator -(CrdtCounter counter, long value) => throw new NotImplementedException();
    }
}