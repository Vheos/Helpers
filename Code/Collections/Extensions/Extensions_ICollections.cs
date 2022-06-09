namespace Vheos.Helpers.Collections;

public static class Extensions_ICollections
{
    #region RANGE
    /// <summary> Adds elements a to this collection. </summary>
    public static void Add<T>(this ICollection<T> @this, IEnumerable<T> a)
    {
        foreach (var element in a)
            @this.Add(element);
    }
    /// <inheritdoc cref="Add{T}(ICollection{T}, IEnumerable{T})"/>
    public static void Add<T>(this ICollection<T> @this, params T[] a)
    => @this.Add(a as IEnumerable<T>);
    /// <summary> Removes elements a from this collection. </summary>
    public static void Remove<T>(this ICollection<T> @this, IEnumerable<T> a)
    {
        foreach (var element in a)
            @this.Remove(element);
    }
    /// <inheritdoc cref="Remove{T}(ICollection{T}, IEnumerable{T})"/>
    public static void Remove<T>(this ICollection<T> @this, params T[] a)
     => @this.Remove(a as IEnumerable<T>);
    #endregion
    #region TRY
    /// <summary> If this collection contains the element a, assigns it to r and returns true. Otherwise, sets r to its default value and returns false. </summary>
    public static bool TryGet<T>(this ICollection<T> @this, T a, out T r)
    {
        if (@this.Contains(a))
        {
            r = a;
            return true;
        }

        r = default;
        return false;
    }
    /// <summary> If this collection contains any element, assigns it to r and returns true. Otherwise, sets r to its default value and returns false. </summary>
    public static bool TryGetAny<T>(this ICollection<T> @this, out T r)
    {
        foreach (var element in @this)
        {
            r = element;
            return true;
        }

        r = default;
        return false;
    }
    /// <summary> Adds element a if this collection doesn'@this contain it. Returns whether the collection was modified or not. </summary>
    public static bool TryAddUnique<T>(this ICollection<T> @this, T a)
    {
        if (@this.Contains(a))
            return false;

        @this.Add(a);
        return true;
    }
    /// <summary> Adds each element from a if this collection doesn'@this contain it. Returns whether the collection was modified or not. </summary>
    public static bool TryAddUnique<T>(this ICollection<T> @this, IEnumerable<T> a)
    {
        bool wasModified = false;
        foreach (var element in a)
            if (!@this.Contains(element))
            {
                @this.Add(element);
                wasModified = true;
            }

        return wasModified;
    }
    /// <inheritdoc cref="TryAddUnique{T}(ICollection{T}, IEnumerable{T})"/>
    public static bool TryAddUnique<T>(this ICollection<T> @this, params T[] a)
    => @this.TryAddUnique(a as IEnumerable<T>);
    /// <summary> Removes element a if this collection contains it. Returns whether the collection was modified or not. </summary>
    public static bool TryRemove<T>(this ICollection<T> @this, T a)
    {
        if (!@this.Contains(a))
            return false;

        @this.Remove(a);
        return true;
    }
    /// <summary> Adds each element from a if this collection doesn'@this contain it. Returns whether the collection was modified or not. </summary>
    public static bool TryRemove<T>(this ICollection<T> @this, IEnumerable<T> a)
    {
        bool wasModified = false;
        foreach (var element in a)
            if (@this.Contains(element))
            {
                @this.Remove(element);
                wasModified = true;
            }

        return wasModified;
    }
    /// <inheritdoc cref="TryRemove{T}(ICollection{T}, IEnumerable{T})"/>
    public static bool TryRemove<T>(this ICollection<T> @this, params T[] a)
    => @this.TryAddUnique(a as IEnumerable<T>);
    #endregion
    #region EMPTY
    /// <summary> Tests whether this collection contains zero element. </summary>
    public static bool IsEmpty<T>(this ICollection<T> @this)
    => @this.Count == 0;
    /// <summary> Tests whether this collection contains any elements. </summary>
    public static bool IsNotEmpty<T>(this ICollection<T> @this)
    => @this.Count != 0;
    /// <summary> Tests whether this collection contains zero element. </summary>
    public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
    => @this == null || @this.Count == 0;
    /// <summary> Tests whether this collection contains any elements. </summary>
    public static bool IsNotNullOrEmpty<T>(this ICollection<T> @this)
    => @this != null && @this.Count != 0;
    #endregion
}
