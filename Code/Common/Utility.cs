namespace Vheos.Helpers.Common;

using System.Diagnostics;
using System.Reflection;
using System.Text;

public static class Utility
{
    /// <summary> Returns an enumerable of all types in the chosen (or calling) assembly that derive from type T. Ignores unbound generic types. </summary>
    public static IEnumerable<Type> GetDerivedTypes<T>(Assembly assembly = null)
    {
        if (assembly == null)
            assembly = Assembly.GetCallingAssembly();
        return assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T)) && !t.IsGenericTypeDefinition);
    }

    /// <summary> Returns an array of all values defined in the given enum. </summary>
    public static T[] GetEnumValues<T>() where T : Enum
    => (T[])Enum.GetValues(typeof(T));

    /// <summary> Returns an enumerable of all values defined in the given enum as strings. </summary>
    public static IEnumerable<string> GetEnumValuesAsStrings<T>() where T : Enum
    {
        foreach (var value in Enum.GetValues(typeof(T)))
            yield return value.ToString();
    }

    /// <summary> Returns an array of all values defined in the given enum. </summary>
    public static string[] GetEnumNames<T>() where T : Enum
    => Enum.GetNames(typeof(T));

    /// <summary> Returns string text parsed as enum of type T. </summary>
    public static T ParseEnum<T>(string text) where T : Enum
    => (T)Enum.Parse(typeof(T), text);

    /// <summary> Returns an intersection of all chosen enumerables. </summary>
    public static List<T> Intersect<T>(IEnumerable<IEnumerable<T>> t)
    {
        if (t == null || !t.Any())
            return new List<T>();

        HashSet<T> hashSet = new(t.First());
        foreach (var enumerable in t.Skip(1))
            hashSet.IntersectWith(enumerable);
        return hashSet.ToList();
    }

    /// <summary> Returns a method that's n stack frames above the method you're currently in. </summary>
    public static MethodBase GetStackMethod(int frame = 2)
    => new StackFrame(frame).GetMethod();

    /// <summary> Returns a formatted list of all methods on the stack. </summary>
    public static string GetFormattedStack(int skipFrames = 1)
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

    public static float HalfTimeToLerpAlpha(float halfTime, float deltaTime)
    => halfTime == 0f ? 1f : 1f - (float)System.Math.Pow(0.5f, deltaTime / halfTime);

#if UNITY
    public static float HalfTimeToLerpAlpha(float halfTime)
    => HalfTimeToLerpAlpha(halfTime, Time.inFixedTimeStep ? Time.fixedDeltaTime : Time.deltaTime);
#endif

    /// <summary> Swaps the reference of object t with a. </summary>
    public static void Swap<T>(ref T t, ref T a)
        => (a, t) = (t, a);

#if NET35
    /// <summary> Returns an intersection of all chosen lists. </summary>
    static public List<T> Intersect<T>(IEnumerable<List<T>> t)
    => Intersect((IEnumerable<IEnumerable<T>>)t);
#endif
}
