namespace Vheos.Helpers.Dump
{
    using System;
    using System.Text;
    using System.Reflection;
    using System.Linq;
    using Vheos.Helpers.Common;

    [Flags]
    public enum AccessModifiers
    {
        None = 0,
        Private = 1 << 1,
        Public = 1 << 2,
        All = Private | Public,
    }
}