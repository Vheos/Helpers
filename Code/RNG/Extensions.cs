namespace Vheos.Helpers.RNG;

using Vheos.Helpers.Math;

static public class Random_Extensions
{
    /// <summary> Returns a random element from this list. </summary>
    static public T Random<T>(this IList<T> t)
    => t[RNG.Range(0, t.Count)];

    /// <summary> Randomizes the indices of all elements in this list. </summary>
    static public void Shuffle<T>(this IList<T> t)
    {
        for (int i = 0; i < t.Count - 1; ++i)
        {
            int j = RNG.Range(i, t.Count);
            (t[j], t[i]) = (t[i], t[j]);
        }
    }

    /// <summary> Returns true with @this probability. </summary>
    static public bool Roll(this float @this)
    => RNG.Value01 < @this || @this == 1f;

    /// <summary> Returns true with @this% probability. </summary>
    static public bool RollPercent(this float @this)
    => RNG.Value01 < @this / 100f || @this == 100f;

    /// <summary> Returns true with @this% probability. </summary>
    static public bool RollPercent(this int @this)
    => RNG.Value01 < @this / 100f || @this == 100f;
}
