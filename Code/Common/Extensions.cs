namespace Vheos.Helpers.Common;

using System.Text.RegularExpressions;

static public class Extensions
{
    #region TYPES
    /// <summary> Casts this value to type T. If it can'@this be cast, returns null.  </summary>
    static public T As<T>(this object @this) where T : class
    => @this as T;
    /// <summary> Casts this value to type T. If it can'@this be cast, throws an InvalidCastException.  </summary>
    static public T Cast<T>(this ValueType @this) where T : struct
    => (T)@this;
    /// <summary> Casts this value to type T. If it can'@this be cast, throws an InvalidCastException.  </summary>
    static public T Cast<T>(this object @this)
    => (T)@this;

    /// <summary> Checks if this type can be assigned to type T. </summary>
    static public bool IsAssignableTo<T>(this Type @this)
    => typeof(T).IsAssignableFrom(@this);
    /// <summary> Returns true if this type can'@this be assigned to type T. </summary>
    static public bool IsNotAssignableTo<T>(this Type @this)
    => !typeof(T).IsAssignableFrom(@this);
    #endregion

    #region TRY OUT
    /// <summary> If this object can be cast to r's type, does so and returns true. Otherwise, sets r to null and returns false. </summary>
    static public bool TryAs<T>(this object @this, out T r) where T : class
    {
        r = @this as T;
        return r != null;
    }
    /// <summary> If this object can be cast to r's type, does so and returns true. Otherwise, sets r to its default value and returns false. </summary>
    static public bool TryCast<T>(this ValueType @this, out T r) where T : struct
    {
        try
        {
            r = (T)@this;
            return true;
        }
        catch (InvalidCastException)
        {
            r = default;
            return false;
        }
    }
    /// <summary> If this object can be cast to r's type, does so and returns true. Otherwise, sets r to its default value and returns false. </summary>
    static public bool TryCast<T>(this object @this, out T r)
    {
        try
        {
            r = (T)@this;
            return true;
        }
        catch (InvalidCastException)
        {
            r = default;
            return false;
        }
    }
    /// <summary> If this object is non-null, assigns it to r and returns true. Otherwise, and sets r to null and returns false. </summary>
    static public bool TryNonNull<T>(this T @this, out T r) where T : class
    {
        r = @this;
        return r != null;
    }
    /// <summary> If this nullable is non-null, assigns it to r and returns true. Otherwise, and sets r to its default value and returns false. </summary>
    static public bool TryNonNull<T>(this T? @this, out T r) where T : struct
    {
        if (@this.HasValue)
        {
            r = @this.Value;
            return true;
        }

        r = default;
        return false;
    }
    #endregion

    #region IS CONTAINED
    /// <summary> Tests whether this object is contained within the collection a. </summary>
    static public bool IsContainedIn<T>(this T @this, ICollection<T> a)
    => a.Contains(@this);
    /// <summary> Tests whether this object is not contained within the collection a. </summary>
    static public bool IsNotContainedIn<T>(this T @this, ICollection<T> a)
    => !a.Contains(@this);
    #endregion

    /// <summary> Checks if this enum uses the [Flags] attributes. </summary>
    static public bool HasFlagsAttribute(this Enum @this)
    => @this.GetType().IsDefined(typeof(FlagsAttribute), false);
    /// <summary> Calls action a for each flag set in this enum. </summary>
    static public void ForEachSetFlag<T>(this T @this, Action<T> a) where T : Enum
    {
        foreach (var flag in (T[])Enum.GetValues(typeof(T)))
            if (@this.HasFlag(flag))
                a(flag);
    }
    /// <summary> Checks if this string is null or empty (""). </summary>
    static public bool IsNullOrEmpty(this string @this)
    => string.IsNullOrEmpty(@this);
    /// <summary> Checks if this string is not null or empty (""). </summary>
    static public bool IsNotNullOrEmpty(this string @this)
    => !string.IsNullOrEmpty(@this);
    /// <summary> Checks if this string contains any characters. </summary>
    static public bool Any(this string @this)
    => !string.IsNullOrEmpty(@this);
    /// <summary> Returns this string with spaces inserted between camel-case words. </summary>
    static public string SplitCamelCase(this string @this)
    => Regex.Replace(@this, "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", "$1 ");
    /// <summary> Formats this value using culture-independen format a. </summary>
    static public string ToInvariant(this IFormattable @this, string a = null)
    => @this.ToString(a, System.Globalization.CultureInfo.InvariantCulture);
    /// <summary> If test a evaluates to true, returns a. Otherwise, returns b. </summary>
    static public T ChooseIf<T>(this T @this, Func<T, bool> a, T b = default)
    => a(@this) ? @this : b;
    /// <summary> If test a evaluates to true, returns a. Otherwise, returns b. </summary>
    static public T ChooseIfNonNull<T>(this T @this, T b = default)
    => @this != null ? @this : b;

    /// <summary> Returns this bool, then inverts it </summary>
    static public bool Toggle(this ref bool @this)
    {
        @this = !@this;
        return !@this;
    }
    /// <summary> Returns this bool, then resets it </summary>
    static public bool Consume(this ref bool @this)
    {
        if (!@this)
            return false;
        @this = false;
        return true;
    }
    /// <summary> Returns 0 for false and 1 for true. </summary>
    static public int To01(this bool @this)
    => @this ? 1 : 0;
    /// <summary> Returns -1 for false and +1 for true. </summary>
    static public int ToSign(this bool @this)
    => @this ? +1 : -1;
    /// <summary> Returns a for true and b for false. </summary>
    static public T Map<T>(this bool @this, T a, T b)
    => @this ? a : b;

    /// <summary> Returns a shallow copy of this array. </summary>
    static public T[] MakeCopy<T>(this T[] @this)
    {
        T[] r = new T[@this.Length];
        @this.CopyTo(r, 0);
        return r;
    }
    /// <summary> Returns a shallow copy of this list. </summary>
    static public List<T> MakeCopy<T>(this List<T> @this)
    => new(@this);
    /// <summary> Returns a shallow copy of this list. </summary>
    static public HashSet<T> MakeCopy<T>(this HashSet<T> @this)
    => new(@this);
    /// <summary> Returns a shallow copy of this list. </summary>
    static public Dictionary<TKey, TValue> MakeCopy<TKey, TValue>(this Dictionary<TKey, TValue> @this)
    => new(@this);

    /// <summary> Swaps the references of this object and a. </summary>
    static public void SwapWith<T>(ref this T @this, ref T a) where T : struct
        => (a, @this) = (@this, a);


#if NET35
    #region HAS FLAG
    /// <summary> HasFlag for .NET Framework versions earlier than 4.0 </summary>
    public static bool HasFlag<T>(this T @this, T a) where T : Enum
    {
        int tInt = Convert.ToInt32(@this);
        int aInt = Convert.ToInt32(a);
        return (tInt & aInt) == aInt;
    }
    #endregion
#endif
}
