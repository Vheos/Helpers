namespace Vheos.Helpers.Dump
{
    using System;
    using System.Text;
    using System.Reflection;
    using System.Linq;
    using Vheos.Helpers.Common;

    [Flags]
    public enum ScopeModifiers
    {
        None = 0,
        Instance = 1 << 1,
        Static = 1 << 2,
        All = Instance | Static,
    }
}