namespace Vheos.Helpers.RNG;
using Vheos.Helpers.Math;

public static class RNG
{
    // Publics
    public static int Seed { get; private set; }
    public static float Value01
        => (float)_randomizer.NextDouble();
    public static float Degree
        => Value01 * 360f;
    public static float Radian
        => Value01 * 2 * (float)System.Math.PI;

    public static float Range(float toEx)
        => Value01 * toEx;
    public static float Range(float fromIn, float toEx)
        => Value01.MapFrom01(fromIn, toEx);

    public static int Range(int toEx)
        => _randomizer.Next(toEx);
    public static int Range(int fromIn, int toEx)
        => _randomizer.Next(fromIn, toEx);

    public static int RangeInclusive(int toIn)
        => _randomizer.Next(toIn + 1);
    public static int RangeInclusive(int fromIn, int toIn)
        => _randomizer.Next(fromIn, toIn + 1);

#if UNITY
    public static Vector2 OnCircle(float radius = 1f)
    {
        float angle = Radian;
        float x = angle.Cos();
        float y = angle.Sin();

        return new(x, y);
    }
    public static Vector2 InCircle(float radius = 1f)
        => OnCircle(radius) * Value01;
    public static Vector3 OnSphere(float radius = 1f)
    {
        float angle1 = Radian;
        float angle2 = Radian;
        float x = angle1.Sin() * angle2.Cos();
        float y = angle1.Sin() * angle2.Cos();
        float z = angle1.Cos();

        return new(x, y, z);
    }
    public static Vector3 InSphere(float radius = 1f)
         => OnSphere(radius) * Value01;
#endif

    // Privates
    private static System.Random _randomizer;

    // Initializers
    static RNG()
    {
        Initialize((int)DateTime.Now.Ticks);
    }

    public static void Initialize(int seed)
    {
        Seed = seed;
        _randomizer = new System.Random(Seed);
    }
}
