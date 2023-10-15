namespace Vheos.Helpers.Dump;

[Flags]
public enum AccessModifiers
{
    None = 0,
    Private = 1 << 0,
    Public = 1 << 1,
    All = Private | Public,
}
