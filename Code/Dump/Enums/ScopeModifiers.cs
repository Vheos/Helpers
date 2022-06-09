namespace Vheos.Helpers.Dump;

[Flags]
public enum ScopeModifiers
{
    None = 0,
    Instance = 1 << 1,
    Static = 1 << 2,
    All = Instance | Static,
}
