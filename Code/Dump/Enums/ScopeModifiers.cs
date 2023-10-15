namespace Vheos.Helpers.Dump;

[Flags]
public enum ScopeModifiers
{
    None = 0,
    Instance = 1 << 0,
    Static = 1 << 1,
    All = Instance | Static,
}
