namespace Vheos.Helpers.Dump;

[Flags]
public enum AccessModifiers
{
    None = 0,
    Private = 1 << 1,
    Public = 1 << 2,
    All = Private | Public,
}
