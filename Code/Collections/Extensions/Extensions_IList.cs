namespace Vheos.Helpers.Collections
{
    using System.Collections.Generic;
    static public class Extensions_IList
    {
        #region VALID
        /// <summary> Tests whether index a is within this list's bounds. </summary>
        static public bool IsValid<T>(this IList<T> @this, int a)
        => a >= 0 && a < @this.Count;
        /// <summary> If this list contains index a, returns its value. Otherwise, return the default value for this list's type. </summary>
        static public T DefaultOnInvalid<T>(this IList<T> @this, int a)
        => @this.IsValid(a) ? @this[a] : default;
        #endregion

        #region GET
        /// <summary> Returns the first element from this list. </summary>
        static public T First<T>(this IList<T> @this)
        => @this[0];
        /// <summary> Returns the first non-null element from this list. </summary>
        static public T FirstNonNull<T>(this IList<T> @this) where T : class
        {
            for (int i = 0; i < @this.Count; i++)
                if (@this[i] != null)
                    return @this[i];
            return default;
        }
        /// <summary> Returns the last element from this list. </summary>
        static public T Last<T>(this IList<T> @this)
        => @this[@this.Count - 1];
        /// <summary> Returns the last non-null element from this list. </summary>
        static public T LastNonNull<T>(this IList<T> @this) where T : class
        {
            for (int i = @this.Count - 1; i >= 0; i--)
                if (@this[i] != null)
                    return @this[i];
            return default;
        }
        #endregion
        #region SET
        /// <summary> Sets the first element from this list to the object a. </summary>
        static public void SetFirst<T>(this IList<T> @this, T a)
        => @this[0] = a;
        /// <summary> Sets the first non-null element from this list to the object a. </summary>
        static public void SetFirstNonNull<T>(this IList<T> @this, T a) where T : class
        {
            for (int i = 0; i < @this.Count; i++)
                if (@this[i] != null)
                {
                    @this[i] = a;
                    break;
                }
        }
        /// <summary> Sets the last element from this list to the value a. </summary>
        static public void SetLast<T>(this IList<T> @this, T a)
        => @this[@this.Count - 1] = a;
        /// <summary> Sets the last non-null element from this list to the value a. </summary>
        static public void SetLastNonNull<T>(this IList<T> @this, T a) where T : class
        {
            for (int i = @this.Count - 1; i >= 0; i--)
                if (@this[i] != null)
                {
                    @this[i] = a;
                    break;
                }
        }
        #endregion
        #region REMOVE
        /// <summary> Removes the first element from this list. </summary>
        static public void RemoveFirst<T>(this IList<T> @this)
        => @this.RemoveAt(0);
        /// <summary> Removes the first non-null element from this list. </summary>
        static public void RemoveFirstNonNull<T>(this IList<T> @this)
        {
            for (int i = 0; i < @this.Count; i++)
                if (@this[i] != null)
                {
                    @this.RemoveAt(i);
                    break;
                }
        }
        /// <summary> Removes the last element from this list. </summary>
        static public void RemoveLast<T>(this IList<T> @this)
        => @this.RemoveAt(@this.Count - 1);
        /// <summary> Removes the last non-null element from this list. </summary>
        static public void RemoveLastNonNull<T>(this IList<T> @this)
        {
            for (int i = @this.Count - 1; i >= 0; i--)
                if (@this[i] != null)
                {
                    @this.RemoveAt(i);
                    break;
                }
        }
        #endregion

        #region TRY OUT
        /// <summary> If this list contains the index a, returns true and assigns its value to r. Otherwise, returns false and sets r to its default value. </summary>
        static public bool TryGet<T>(this IList<T> @this, int a, out T r)
        {
            if (a >= 0 && a < @this.Count)
            {
                r = @this[a];
                return true;
            }

            r = default;
            return false;
        }
        /// <summary> If this list contains the index a and its value is non-null, returns true and assigns it to r. Otherwise, returns false and sets r to null. </summary>
        static public bool TryGetNonNull<T>(this IList<T> @this, int a, out T r) where T : class
        {
            if (a >= 0 && a < @this.Count && @this[a] != null)
            {
                r = @this[a];
                return true;
            }

            r = null;
            return false;
        }
        #endregion
    }
}