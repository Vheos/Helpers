namespace Vheos.Helpers.Collections;

static public class Extensions_IDictionary
{
    #region TRY
    /// <summary> If this dictionary contains the key a, assigns its value to r and returns true. Otherwise, sets r to its default value and returns false. </summary>
    static public bool TryGet<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey a, out TValue r)
    {
        if (@this.ContainsKey(a))
        {
            r = @this[a];
            return true;
        }
        r = default;
        return false;
    }
    /// <summary> If this dictionary contains the key a and its value is non-null, assigns it to r and returns true. Otherwise, sets r to null and returns false. </summary>
    static public bool TryGetNonNullValue<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey a, out TValue r) where TValue : class
    {
        if (@this.ContainsKey(a))
        {
            r = @this[a];
            return r != null;
        }
        r = null;
        return false;
    }
    /// <summary> If this dictionary contains the key a and its value can be cast to r's type, does so and returns true. Otherwise, sets r to its default value and returns false. </summary>
    static public bool TryGetValueAs<TKey, TValue, TValueAs>(this IDictionary<TKey, TValue> @this, TKey a, out TValueAs r)
        where TValue : class
        where TValueAs : class, TValue
    {
        if (@this.ContainsKey(a) && @this[a].TryAs(out r))
            return true;
        r = null;
        return false;
    }
    /// <summary> If this dictionary doesn'@this contain key a, adds it and sets it value to b. Returns whether the dictionary was modified or not. </summary>
    static public bool TryAddUnique<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey a, TValue b)
    {
        if (@this.ContainsKey(a))
            return false;

        @this.Add(a, b);
        return true;
    }
    /// <summary> If this dictionary doesn'@this contain key a, adds it and sets it to its default value. Returns whether the dictionary was modified or not. </summary>
    static public bool TryAddDefault<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey a)
    {
        if (@this.ContainsKey(a))
            return false;

        @this.Add(a, default);
        return true;
    }
    /// <summary> If this dictionary doesn'@this contain key a, adds it, sets it value to b and returns it. Otherwise, returns found value. </summary>
    static public TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey a, TValue b) where TValue : class
    {
        if (@this.ContainsKey(a))
            @this.Add(a, b);
        return b;
    }
    #endregion
}
