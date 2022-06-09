namespace Vheos.Helpers.KeyCodeCache;

public static class Extensions
{
    public static bool IsValidKeyCode(this string t)
        => KeyCodeCache.KeyCodesByName.ContainsKey(t);
    public static KeyCode ToKeyCode(this string t)
        => KeyCodeCache.KeyCodesByName.TryGetValue(t, out var keyCode) ? keyCode : KeyCode.None;
}
