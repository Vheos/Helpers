namespace Vheos.Helpers.Common
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using UnityEngine;

    static public class Utility
    {
        /// <summary> Returns an enumerable of all types in the chosen (or calling) assembly that derive from type T. Ignores unbound generic types. </summary>
        static public IEnumerable<Type> GetDerivedTypes<T>(Assembly assembly = null)
        {
            if (assembly == null)
                assembly = Assembly.GetCallingAssembly();
            return assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T)) && !t.IsGenericTypeDefinition);
        }

        /// <summary> Returns an array of all values defined in the given enum. </summary>
        static public T[] GetEnumValues<T>() where T : Enum
        => (T[])Enum.GetValues(typeof(T));

        /// <summary> Returns an enumerable of all values defined in the given enum as strings. </summary>
        static public IEnumerable<string> GetEnumValuesAsStrings<T>() where T : Enum
        {
            foreach (var value in Enum.GetValues(typeof(T)))
                yield return value.ToString();
        }

        /// <summary> Returns an array of all values defined in the given enum. </summary>
        static public string[] GetEnumNames<T>() where T : Enum
        => Enum.GetNames(typeof(T));

        /// <summary> Returns string text parsed as enum of type T. </summary>
        static public T ParseEnum<T>(string text) where T : Enum
        => (T)Enum.Parse(typeof(T), text);

        /// <summary> Returns an intersection of all chosen enumerables. </summary>
        static public List<T> Intersect<T>(IEnumerable<IEnumerable<T>> t)
        {
            if (t == null || !t.Any())
                return new List<T>();

            HashSet<T> hashSet = new(t.First());
            foreach (var enumerable in t.Skip(1))
                hashSet.IntersectWith(enumerable);
            return hashSet.ToList();
        }

        /// <summary> Returns a method that's n stack frames above the method you're currently in. </summary>
        static public MethodBase GetStackMethod(int frame = 2)
        => new StackFrame(frame).GetMethod();

        /// <summary> Returns a formatted list of all methods on the stack. </summary>
        static public string GetFormattedStack(int skipFrames = 1)
        {
            // Initialize
            StackFrame[] stackFrames = new StackTrace(skipFrames).GetFrames();
            StringBuilder builder = new();

            // Find longest type
            int longestType = 0;
            foreach (var frame in stackFrames)
            {
                MethodBase method = frame.GetMethod();
                int typeLength = method.DeclaringType.ToString().Length;
                if (method.IsStatic)
                    typeLength += 7;
                if (typeLength > longestType)
                    longestType = typeLength;
            }

            // Append methods
            foreach (var frame in stackFrames)
            {
                MethodBase method = frame.GetMethod();
                string typeText = method.IsStatic ? "static " : "";
                typeText += method.DeclaringType;
                typeText = typeText.PadLeft(longestType, ' ');
                builder.Append(typeText).Append(".").AppendLine(method.Name);
            }

            // print
            return builder.ToString();
        }

        static public float HalfTimeToLerpAlpha(float halfTime, float deltaTime)
        => halfTime == 0f ? 1f : 1f - (float)Math.Pow(0.5f, deltaTime / halfTime);

#if UNITY
        static public float HalfTimeToLerpAlpha(float halfTime)
        => HalfTimeToLerpAlpha(halfTime, Time.inFixedTimeStep ? Time.fixedDeltaTime : Time.deltaTime);
#endif

        /// <summary> Swaps the reference of object t with a. </summary>
        static public void Swap<T>(ref T t, ref T a)
        {
            T temp = t;
            t = a;
            a = temp;
        }

#if NET35
        /// <summary> Returns an intersection of all chosen lists. </summary>
        static public List<T> Intersect<T>(IEnumerable<List<T>> t)
        => Intersect((IEnumerable<IEnumerable<T>>)t);
#endif
    }
}