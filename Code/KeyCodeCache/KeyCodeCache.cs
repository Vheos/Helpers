namespace Vheos.Helpers.KeyCodeCache;

static public class KeyCodeCache
{
    // Privates
    static private Dictionary<string, KeyCode> _keyCodesByName;

    // Publics
    static public void Initialize()
    {
        _keyCodesByName = new Dictionary<string, KeyCode>();
        foreach (var keyCodeName in Utility.GetEnumNames<KeyCode>())
            _keyCodesByName.Add(keyCodeName, Utility.ParseEnum<KeyCode>(keyCodeName));
    }
    static public IReadOnlyDictionary<string, KeyCode> KeyCodesByName
    => _keyCodesByName;
}
