namespace Vheos.Helpers.RNG;

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
}
