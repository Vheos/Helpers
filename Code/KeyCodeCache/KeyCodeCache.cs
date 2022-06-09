namespace Vheos.Helpers.KeyCodeCache;

public static class KeyCodeCache
{
    // Publics
    public static IReadOnlyDictionary<string, KeyCode> KeyCodesByName
        => _keyCodesByName;

    // Privates
    private static readonly Dictionary<string, KeyCode> _keyCodesByName;

    // Initializers
    static KeyCodeCache()
    {
        _keyCodesByName = new(StringComparer.OrdinalIgnoreCase);
        foreach (var keyCodeName in Utility.GetEnumNames<KeyCode>())
            _keyCodesByName.Add(keyCodeName, Utility.ParseEnum<KeyCode>(keyCodeName));
    }
}