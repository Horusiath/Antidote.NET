#region copyright
// -----------------------------------------------------------------------
//  <copyright file="CrdtFlag.cs" creator="Bartosz Sypytkowski">
//      Copyright (C) 2017 SyncFree <https://syncfree.lip6.fr/>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Antidote
{
    public class CrdtFlag : AntidoteObject<bool>
    {
        public CrdtFlag Enable() => throw new NotImplementedException();
        public CrdtFlag Disable() => throw new NotImplementedException();
        public CrdtFlag Reset() => throw new NotImplementedException();
    }
}