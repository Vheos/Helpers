namespace Vheos.Tools.RandomN
{
        static public class Random_Extensions
    {
        /// <summary> Returns a random element from this list. </summary>
        static public T Random<T>(this IList<T> t)
        => t[RandomN.Random.Range(0, t.Count)];

        /// <summary> Randomizes the indices of all elements in this list. </summary>
        static public void Shuffle<T>(this IList<T> t)
        {
            for (int i = 0; i < t.Count - 1; ++i)
            {
                int j = RandomN.Random.Range(i, t.Count);
                T tmp = t[i];
                t[i] = t[j];
                t[j] = tmp;
            }
        }
    }
}