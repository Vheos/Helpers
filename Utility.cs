namespace Vheos.Tools.UtilityNS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    static public class Utility
    {
        /// <summary> Returns an enumerable of all types in the chosen (or calling) assembly that derive from type T. Ignores unbound generic types. </summary>
        static public IEnumerable<Type> GetDerivedTypes<T>(Assembly assembly = null)
        {
            if (assembly == null)
                assembly = Assembly.GetCallingAssembly();
            return assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T)) && !t.IsGenericTypeDefinition);
        }

        /// <summary> Returns an array of all values defined in the given enums. </summary>
        static public T[] GetEnumValues<T>() where T : Enum
        => (T[])Enum.GetValues(typeof(T));

        /// <summary> Returns an intersection of all chosen enumerables. </summary>
        static public List<T> Intersect<T>(IEnumerable<IEnumerable<T>> lists)
        {
            if (lists == null || !lists.Any())
                return new List<T>();

            HashSet<T> hashSet = new HashSet<T>(lists.First());
            foreach (var list in lists.Skip(1))
                hashSet.IntersectWith(list);
            return hashSet.ToList();
        }

        /// <summary> Swaps the reference of object t with a. </summary>
        static public void Swap<T>(ref T t, ref T a)
        {
            T temp = t;
            t = a;
            a = temp;
        }
    }
}



namespace Vheos.Tools.UtilityNS.Unity
{
    static public class UnityUtility
    {
    }
}