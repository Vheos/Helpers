namespace Vheos.Helpers.RNG;
public static class Random_Extensions
{
    /// <summary> Returns a random element from this list. </summary>
    public static T Random<T>(this IList<T> t)
    => t[RNG.Range(0, t.Count)];

    /// <summary> Randomizes the indices of all elements in this list. </summary>
    public static void Shuffle<T>(this IList<T> t)
    {
        for (int i = 0; i < t.Count - 1; ++i)
        {
            int j = RNG.Range(i, t.Count);
            (t[j], t[i]) = (t[i], t[j]);
        }
    }

    /// <summary> Returns true with @this probability. </summary>
    public static bool Roll(this float @this)
    => RNG.Value01 < @this || @this == 1f;

    /// <summary> Returns true with @this% probability. </summary>
    public static bool RollPercent(this float @this)
    => RNG.Value01 < @this / 100f || @this == 100f;

    /// <summary> Returns true with @this% probability. </summary>
    public static bool RollPercent(this int @this)
    => RNG.Value01 < @this / 100f || @this == 100f;
}
