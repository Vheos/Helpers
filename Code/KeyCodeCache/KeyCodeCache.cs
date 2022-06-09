namespace Vheos.Helpers.KeyCodeCache;

static public class KeyCodeCache
{
    // Publics
    static public IReadOnlyDictionary<string, KeyCode> KeyCodesByName
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
