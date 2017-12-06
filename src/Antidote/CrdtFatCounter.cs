#region copyright
// -----------------------------------------------------------------------
//  <copyright file="CrdtFatCounter.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Antidote
{
    public class CrdtFatCounter : CrdtCounter
    {
        public CrdtFatCounter Increment(long value) => throw new NotImplementedException();
        public CrdtFatCounter Decrement(long value) => throw new NotImplementedException();
        public CrdtFatCounter Reset() => throw new NotImplementedException();

        public static CrdtFatCounter operator +(CrdtFatCounter counter, long value) => throw new NotImplementedException();
        public static CrdtFatCounter operator -(CrdtFatCounter counter, long value) => throw new NotImplementedException();
    }
}