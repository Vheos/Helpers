namespace Vheos.Helpers.New;

public class Bictionary<TKey, TValue> : IReadOnlyBictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>
{
    // Fields
    private readonly Dictionary<TKey, TValue> valuesByKeys = new();
    private readonly Dictionary<TValue, TKey> keysByValues = new();

    // Methods
    public IEnumerable<TKey> Keys
        => valuesByKeys.Keys;
    public IEnumerable<TValue> Values
        => valuesByKeys.Values;
    public void Add(TKey key, TValue value)
    {
        if (valuesByKeys.ContainsKey(key) || keysByValues.ContainsKey(value))
            throw new ArgumentException($"Duplicate key or value in {typeof(Bictionary<TKey, TValue>).Name}");

        valuesByKeys.Add(key, value);
        keysByValues.Add(value, key);
    }
    public bool TryAdd(TKey key, TValue value)
    {
        if (valuesByKeys.ContainsKey(key) || keysByValues.ContainsKey(value))
            return false;

        valuesByKeys.Add(key, value);
        keysByValues.Add(value, key);
        return true;
    }
    public bool TryGetValue(TKey key, out TValue value)
        => valuesByKeys.TryGetValue(key, out value);
    public bool TryGetKey(TValue value, out TKey key)
        => keysByValues.TryGetValue(value, out key);
    public TValue GetValueOr(TKey key, TValue or)
        => valuesByKeys.TryGetValue(key, out var value) ? value : or;
    public TKey GetKeyOr(TValue value, TKey or)
        => keysByValues.TryGetValue(value, out var key) ? key : or;

    // IEnumerable
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        => valuesByKeys.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()
        => valuesByKeys.GetEnumerator();

    // Operators
    public TValue this[TKey key]
    {
        get => valuesByKeys[key];
        set
        {
            TValue oldValue = valuesByKeys[key];
            TValue newValue = value;
            if (newValue.Equals(oldValue))
                return;

            keysByValues.Remove(oldValue);
            keysByValues[newValue] = key;
            valuesByKeys[key] = newValue;
        }
    }
    public TKey this[TValue _value]
    {
        get => keysByValues[_value];
        set
        {
            TKey oldKey = keysByValues[_value];
            TKey newKey = value;
            if (newKey.Equals(oldKey))
                return;

            valuesByKeys.Remove(oldKey);
            valuesByKeys[newKey] = _value;
            keysByValues[_value] = newKey;
        }
    }
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