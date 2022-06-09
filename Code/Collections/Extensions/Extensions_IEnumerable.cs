namespace Vheos.Helpers.Collections;

public static class Extensions_IEnumerable
{
    #region TRY
    /// <summary> If this collection contains any element, assigns it to r and returns true. Otherwise, sets r to its default value and returns false. </summary>
    public static bool TryGetAny<T>(this IEnumerable<T> @this, out T r)
    {
        foreach (var element in @this)
        {
            r = element;
            return true;
        }

        r = default;
        return false;
    }
    #endregion

    #region EMPTY
    /// <summary> Tests whether this enumerable contains zero element. </summary>
    public static bool IsEmpty<T>(this IEnumerable<T> @this)
    {
        foreach (var _ in @this)
            return false;
        return true;
    }
    /// <summary> Tests whether this enumerable contains any elements. </summary>
    public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
    {
        foreach (var _ in @this)
            return true;
        return false;
    }
    /// <summary> Tests whether this collection contains zero element. </summary>
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
    => @this == null || @this.IsEmpty();
    /// <summary> Tests whether this collection contains any elements. </summary>
    public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
    => @this != null && @this.IsNotEmpty();
    #endregion
}
