namespace Vheos.Helpers.RNG;
using Vheos.Helpers.Math;

static public class RNG
{
    // Publics
    static public float Value01
    => (float)_randomizer.NextDouble();
    static public int Range(int fromInclusive, int toExclusive)
    => Value01.MapFrom01(fromInclusive, toExclusive).RoundDown();
    static public int Seed
    { get; private set; }

    // Privates
    static private System.Random _randomizer;

    // Initializers


    static public void Initialize() => Initialize((int)DateTime.Now.Ticks);
    static public void Initialize(int seed)
    {
        Seed = seed;
        _randomizer = new System.Random(Seed);
    }
}
