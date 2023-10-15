namespace Vheos.Helpers.New;

public class Bictionary<TKey, TValue> : IReadOnlyBictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>
{
    // Fields
    private readonly Dictionary<TKey, TValue> _valuesByKeys = new();
    private readonly Dictionary<TValue, TKey> _keysByValues = new();

    // Methods
    public void Add(TKey key, TValue value)
    {
        if (_valuesByKeys.ContainsKey(key) || _keysByValues.ContainsKey(value))
            throw new ArgumentException($"Duplicate key or value in {typeof(Bictionary<TKey, TValue>).Name}");

        _valuesByKeys.Add(key, value);
        _keysByValues.Add(value, key);
    }
    public bool TryAdd(TKey key, TValue value)
    {
        if (_valuesByKeys.ContainsKey(key) || _keysByValues.ContainsKey(value))
            return false;

        _valuesByKeys.Add(key, value);
        _keysByValues.Add(value, key);
        return true;
    }
    public bool TryGetValue(TKey key, out TValue value)
        => _valuesByKeys.TryGetValue(key, out value);
    public bool TryGetKey(TValue value, out TKey key)
        => _keysByValues.TryGetValue(value, out key);
    public TValue GetValueOr(TKey key, TValue or)
        => _valuesByKeys.TryGetValue(key, out var value) ? value : or;
    public TKey GetKeyOr(TValue value, TKey or)
        => _keysByValues.TryGetValue(value, out var key) ? key : or;
    public IEnumerable<TKey> Keys
        => _valuesByKeys.Keys;
    public IEnumerable<TValue> Values
        => _valuesByKeys.Values;

    // IEnumerable
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        => _valuesByKeys.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()
        => _valuesByKeys.GetEnumerator();

    // Operators
    public TValue this[TKey key]
        => _valuesByKeys[key];
    public TKey this[TValue value]
        => _keysByValues[value];
}

public interface IReadOnlyBictionary<TKey, TValue>
{
    public bool TryGetValue(TKey key, out TValue value);
    public bool TryGetKey(TValue value, out TKey key);
    public TValue GetValueOr(TKey key, TValue or);
    public TKey GetKeyOr(TValue value, TKey or);
    public IEnumerable<TKey> Keys
    { get; }
    public IEnumerable<TValue> Values
    { get; }
    public TValue this[TKey key]
    { get; }
    public TKey this[TValue value]
    { get; }
}