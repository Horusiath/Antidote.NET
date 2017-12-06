#region copyright
// -----------------------------------------------------------------------
//  <copyright file="CrdtInteger.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Antidote
{
    public class CrdtInteger : CrdtFatCounter
    {
        public CrdtInteger Increment(long value) => throw new NotImplementedException();
        public CrdtInteger Decrement(long value) => throw new NotImplementedException();
        public CrdtInteger Reset() => throw new NotImplementedException();
        public CrdtInteger SetValue(long value) => throw new NotImplementedException();

        public static CrdtInteger operator +(CrdtInteger counter, long value) => throw new NotImplementedException();
        public static CrdtInteger operator -(CrdtInteger counter, long value) => throw new NotImplementedException();
    }
}