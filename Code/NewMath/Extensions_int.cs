namespace Vheos.Helpers.Math;

public static class Extensions_int
{
    // Constants
    private const f DEG_TO_RAD = 0.017453f;

    // Binary
    public static f Add(this int t, f a)
		=> t + a;
    public static f Sub(this int t, f a)
		=> t - a;
    public static f Mul(this int t, f a)
		=> t * a;
    public static f Div(this int t, f a)
		=> t / a;
    public static f Pow(this int t, f a)
		=> (f)System.Math.Pow(t, a);
    public static f Root(this int t, f a)
		=> (int)System.Math.Pow(1f / t, a);
    public static f Mod(this int t, f a)
		=> t % a;
    public static f PosMod(this int t, f a)
		=> (t % a + a) % a;
    public static f Min(this int t, f a)
		=> t < a ? t : a;
    public static f Max(this int t, f a)
		=> t > a ? t : a;
    public static f Avg(this int t, f a)
		=> (t + a) / 2f;

    public static int Add(this int t, int a)
		=> t + a;
    public static int Sub(this int t, int a)
		=> t - a;
    public static int Mul(this int t, int a)
		=> t * a;
    public static int Div(this int t, int a)
		=> t / a;
    public static int Pow(this int t, int a)
		=> (int)System.Math.Pow(t, a);
    public static f Root(this int t, int a)
		=> (f)System.Math.Pow(1f / t, a);
    public static int Mod(this int t, int a)
		=> t % a;
    public static int PosMod(this int t, int a)
		=> (t % a + a) % a;
    public static int Min(this int t, int a)
		=> t < a ? t : a;
    public static int Max(this int t, int a)
		=> t > a ? t : a;
    public static f Avg(this int t, int a)
		=> (t + a) / 2f;

    // Unary
    public static int Neg(this int t)
		=> -t;
    public static f Inv(this int t)
		=> 1f / t;
    public static int Abs(this int t)
		=> t > 0 ? t : -t;
    public static int Sig(this int t)
		=> t > 0 ? +1
     : t < 0 ? -1
     : 0;
    public static int Sqrd(this int t)
		=> t * t;
    public static f Sqrt(this int t)
		=> (f)System.Math.Sqrt(t);

    // Trig
    public static f Sin(this int t)
		=> (f)System.Math.Sin(t * DEG_TO_RAD);
    public static f Cos(this int t)
		=> (f)System.Math.Cos(t * DEG_TO_RAD);
    public static f Tan(this int t)
		=> (f)System.Math.Tan(t * DEG_TO_RAD);
    public static f Cot(this int t)
		=> 1f / t.Tan();
    public static f Sec(this int t)
		=> 1f / t.Cos();
    public static f Csc(this int t)
		=> 1f / t.Sin();
    public static f ArcSin(this int t)
		=> (f)System.Math.Asin(t * DEG_TO_RAD);
    public static f ArcCos(this int t)
		=> (f)System.Math.Acos(t * DEG_TO_RAD);
    public static f ArcTan(this int t)
		=> (f)System.Math.Atan(t * DEG_TO_RAD);

    // Round
    public static f RoundToMultiple(this int t, f a)
		=> (f)System.Math.Round(t / a, MidpointRounding.AwayFromZero) * a;
    public static int RoundToMultiple(this int t, int a)
		=> (int)System.Math.Round((f)t / a, MidpointRounding.AwayFromZero) * a;

    // Map
    public static int Clamp01(this int t)
		=> t < 0 ? 0
     : t > 1 ? 1
     : t;
    public static f Clamp(this int t, f a, f b)
		=> t < a ? a
     : t > b ? b
     : t;
    public static f ClampMin(this int t, f a)
		=> t > a ? t : a;
    public static f ClampMax(this int t, f a)
		=> t < a ? t : a;
    public static f Lerp(this int t, f a, f b)
		=> t + (a - t) * b;
    public static f LerpClamped(this int t, f a, f b)
		=> b <= 0f ? t
     : b >= 1f ? a
     : t.Lerp(a, b);
    public static f InverseLerp(this int t, f a, f b)
		=> (t - a) / (b - a);
    public static f InverseLerpClamped(this int t, f a, f b)
		=> t <= a ? 0f
     : t >= b ? 1f
     : t.InverseLerp(a, b);
    public static f Map(this int t, f a, f b, f c, f d)
		=> (t - a) * (d - c) / (f)(b - a) + c;
    public static f MapClamped(this int t, f a, f b, f c, f d)
		=> t <= a ? c
     : t >= b ? d
     : t.Map(a, b, c, d);

    public static int Clamp(this int t, int a, int b)
		=> t < a ? a
     : t > b ? b
     : t;
    public static int ClampMin(this int t, int a)
		=> t > a ? t : a;
    public static int ClampMax(this int t, int a)
		=> t < a ? t : a;
    public static f Lerp(this int t, int a, f b)
		=> t + (a - t) * b;
    public static f LerpClamped(this int t, int a, f b)
		=> b <= 0f ? t
     : b >= 1f ? a
     : t.Lerp(a, b);
    public static f InverseLerp(this int t, int a, int b)
		=> (t - a) / (b - a);
    public static f InverseLerpClamped(this int t, int a, int b)
		=> t <= a ? 0f
     : t >= b ? 1f
     : t.InverseLerp(a, b);
    public static f Map(this int t, int a, int b, int c, int d)
		=> (t - a) * (d - c) / (f)(b - a) + c;
    public static f MapClamped(this int t, int a, int b, int c, int d)
		=> t <= a ? c
     : t >= b ? d
     : t.Map(a, b, c, d);

    // Checks
    public static bool IsPos(this int t)
		=> t > 0;
    public static bool IsNeg(this int t)
		=> t < 0;
    public static bool IsBetween(this int t, f a, f b)
		=> t >= a && t <= b;
    public static bool IsBetween(this int t, int a, int b)
		=> t >= a && t <= b;

    public static bool IsZero(this int t)
		=> t == 0;
    public static bool IsEven(this int t)
		=> t % 2 == 0;
    public static bool IsOdd(this int t)
		=> t % 2 != 0;

    // Spatial
    public static f DistanceTo(this int t, f a)
		=> (t - a).Abs();
    public static int DistanceTo(this int t, int a)
		=> (t - a).Abs();

    // Conversions
    public static f Tof(this int t)
		=> t;
#if UNITY
    public static Vector2Int ToVector2Int(this int t)
		=> new(t, t);
    public static Vector3Int ToVector3Int(this int t)
		=> new(t, t, t);

    public static Vector2Int Append(this int t)
		=> new(t, 0);
    public static Vector2Int Append(this int t, int y)
		=> new(t, y);
    public static Vector3Int Append(this int t, int y, int z)
		=> new(t, y, z);
    public static Vector3Int Append(this int t, Vector2Int a)
		=> new(t, a.x, a.y);
    public static Vector4Int Append(this int t, int y, int z, int w)
		=> new(t, y, z, w);
    public static Vector4Int Append(this int t, Vector3Int a)
		=> new(t, a.x, a.y, a.z);
#endif

    #region SET
    public static void SetAdd(this ref int t, int a)
		=> t = t.Add(a);
    public static void SetSub(this ref int t, int a)
		=> t = t.Sub(a);
    public static void SetMul(this ref int t, int a)
		=> t = t.Mul(a);
    public static void SetDiv(this ref int t, int a)
		=> t = t.Div(a);
    public static void SetPow(this ref int t, int a)
		=> t = t.Pow(a);
    public static void SetMod(this ref int t, int a)
		=> t = t.Mod(a);
    public static void SetPosMod(this ref int t, int a)
		=> t = t.PosMod(a);
    public static void SetMin(this ref int t, int a)
		=> t = t.Min(a);
    public static void SetMax(this ref int t, int a)
		=> t = t.Max(a);

    public static void SetNeg(this ref int t)
		=> t = t.Neg();
    public static void SetAbs(this ref int t)
		=> t = t.Abs();
    public static void SetSig(this ref int t)
		=> t = t.Sig();
    public static void SetSqrd(this ref int t)
		=> t = t.Sqrd();

    public static void SetRoundToMultiple(this ref int t, int a)
		=> t = t.RoundToMultiple(a);

    public static void SetClamp(this ref int t, int a, int b)
		=> t = t.Clamp(a, b);
    public static void SetClampMin(this ref int t, int a)
		=> t = t.ClampMin(a);
    public static void SetClampMax(this ref int t, int a)
		=> t = t.ClampMax(a);

    public static void SetDistanceTo(this ref int t, int a)
		=> t = t.DistanceTo(a);
    #endregion
}
