namespace Vheos.Helpers.KeyCodeCache;

static public class Extensions
{
    static public bool IsValidKeyCode(this string t)
        => KeyCodeCache.KeyCodesByName.ContainsKey(t);
    static public KeyCode ToKeyCode(this string t)
        => KeyCodeCache.KeyCodesByName.TryGetValue(t, out var keyCode) ? keyCode : KeyCode.None;
}
