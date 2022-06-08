namespace Vheos.Tools.Random
{
    using System;
    using Vheos.Helpers.Math;
    using SystemRandom = System.Random;

    static public class Random
    {
        // Publics
        static public float Value01
        => (float)_random.NextDouble();
        static public int Range(int fromInclusive, int toExclusive)
        => Value01.MapFrom01(fromInclusive, toExclusive).RoundDown();
        static public int Seed
        { get; private set; }

        // Privates
        static private SystemRandom _random;

        // Initializers
        static public void Initialize() => Initialize((int)DateTime.Now.Ticks);
        static public void Initialize(int seed)
        {
            Seed = seed;
            _random = new SystemRandom(Seed);
        }
    }
}