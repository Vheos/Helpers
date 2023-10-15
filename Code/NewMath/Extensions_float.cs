namespace Vheos.Helpers.Math;

public static class Extensions_f
{
    // Constants
    private const f DEG_TO_RAD = 0.0174532924f;

    // Binary
    public static f Add(this f t, f a)
		=> t + a;
    public static f Sub(this f t, f a)
		=> t - a;
    public static f Mul(this f t, f a)
		=> t * a;
    public static f Div(this f t, f a)
		=> t / a;
    public static f Pow(this f t, f a)
		=> (f)System.Math.Pow(t, a);
    public static f Root(this f t, f a)
		=> (f)System.Math.Pow(1f / t, a);
    public static f Mod(this f t, f a)
		=> t % a;
    public static f PosMod(this f t, f a)
		=> (t % a + a) % a;
    public static f Min(this f t, f a)
		=> t < a ? t : a;
    public static f Max(this f t, f a)
		=> t > a ? t : a;
    public static f Avg(this f t, f a)
		=> (t + a) / 2f;

    public static f Add(this f t, int a)
		=> t + a;
    public static f Sub(this f t, int a)
		=> t - a;
    public static f Mul(this f t, int a)
		=> t * a;
    public static f Div(this f t, int a)
		=> t / a;
    public static f Pow(this f t, int a)
		=> (f)System.Math.Pow(t, a);
    public static f Root(this f t, int a)
		=> (f)System.Math.Pow(1f / t, a);
    public static f Mod(this f t, int a)
		=> t % a;
    public static f PosMod(this f t, int a)
		=> (t % a + a) % a;
    public static f Min(this f t, int a)
		=> t < a ? t : a;
    public static f Max(this f t, int a)
		=> t > a ? t : a;
    public static f Avg(this f t, int a)
		=> (t + a) / 2f;

    // Unary
    public static f Neg(this f t)
		=> -t;
    public static f Inv(this f t)
		=> 1f / t;
    public static f Abs(this f t)
		=> t > 0f ? t : -t;
    public static int Sig(this f t)
		=> t > 0f ? +1
     : t < 0f ? -1
     : 0;
    public static f Sqrd(this f t)
		=> t * t;
    public static f Sqrt(this f t)
		=> (f)System.Math.Sqrt(t);

    // Trig
    public static f Sin(this f t, bool degrees = false)
		=> (f)System.Math.Sin(degrees ? t * DEG_TO_RAD : t);
    public static f Cos(this f t, bool degrees = false)
		=> (f)System.Math.Cos(degrees ? t * DEG_TO_RAD : t);
    public static f Tan(this f t, bool degrees = false)
		=> (f)System.Math.Tan(degrees ? t * DEG_TO_RAD : t);
    public static f Cot(this f t, bool degrees = false)
		=> 1f / t.Tan(degrees);
    public static f Sec(this f t, bool degrees = false)
		=> 1f / t.Cos(degrees);
    public static f Csc(this f t, bool degrees = false)
		=> 1f / t.Sin(degrees);
    public static f ArcSin(this f t, bool degrees = false)
		=> (f)System.Math.Asin(degrees ? t * DEG_TO_RAD : t);
    public static f ArcCos(this f t, bool degrees = false)
		=> (f)System.Math.Acos(degrees ? t * DEG_TO_RAD : t);
    public static f ArcTan(this f t, bool degrees = false)
		=> (f)System.Math.Atan(degrees ? t * DEG_TO_RAD : t);

    // Round
    public static int Round(this f t)
		=> (int)System.Math.Round(t, MidpointRounding.AwayFromZero);
    public static int RoundDown(this f t)
		=> (int)System.Math.Floor(t);
    public static int RoundUp(this f t)
		=> (int)System.Math.Ceiling(t);
    public static int RoundTowardsZero(this f t)
		=> (int)t;
    public static int RoundAwayFromZero(this f t)
		=> t > 0 ? (int)System.Math.Ceiling(t) : (int)System.Math.Floor(t);
    public static f RoundToDecimalDigits(this f t, int a)
		=> (f)System.Math.Round(t, a, MidpointRounding.AwayFromZero);

    public static f RoundToMultiple(this f t, f a)
		=> (f)System.Math.Round(t / a, MidpointRounding.AwayFromZero) * a;
    public static int RoundToMultiple(this f t, int a)
		=> (int)System.Math.Round(t / a, MidpointRounding.AwayFromZero) * a;

    // Map  
    public static f Clamp01(this f t)
		=> t < 0f ? 0f
     : t > 1f ? 1f
     : t;
    public static f Clamp(this f t, f a, f b)
		=> t < a ? a
     : t > b ? b
     : t;
    public static f ClampMin(this f t, f a)
		=> t > a ? t : a;
    public static f ClampMax(this f t, f a)
		=> t < a ? t : a;
    public static f Lerp(this f t, f a, f b)
		=> t + (a - t) * b;
    public static f LerpClamped(this f t, f a, f b)
		=> b <= 0f ? t
     : b >= 1f ? a
     : t.Lerp(a, b);
    public static f InverseLerp(this f t, f a, f b)
		=> (t - a) / (b - a);
    public static f InverseLerpClamped(this f t, f a, f b)
		=> t <= a ? 0f
     : t >= b ? 1f
     : t.InverseLerp(a, b);
    public static f Map(this f t, f a, f b, f c, f d)
		=> (t - a) * (d - c) / (b - a) + c;
    public static f MapClamped(this f t, f a, f b, f c, f d)
		=> t <= a ? c
     : t >= b ? d
     : t.Map(a, b, c, d);
    public static f MapFrom01(this f t, f a, f b)
		=> t.Map(0f, 1f, a, b);
    public static f MapTo01(this f t, f a, f b)
		=> t.Map(a, b, 0f, 1f);

    public static f Clamp(this f t, int a, int b)
		=> t < a ? a
     : t > b ? b
     : t;
    public static f ClampMin(this f t, int a)
		=> t > a ? t : a;
    public static f ClampMax(this f t, int a)
		=> t < a ? t : a;
    public static f Lerp(this f t, int a, f b)
		=> t + (a - t) * b;
    public static f LerpClamped(this f t, int a, f b)
		=> b <= 0f ? t
     : b >= 1f ? a
     : t.Lerp(a, b);
    public static f InverseLerp(this f t, int a, int b)
		=> (t - a) / (b - a);
    public static f InverseLerpClamped(this f t, int a, int b)
		=> t <= a ? 0f
     : t >= b ? 1f
     : t.InverseLerp(a, b);
    public static f Map(this f t, int a, int b, int c, int d)
		=> (t - a) * (d - c) / (b - a) + c;
    public static f MapClamped(this f t, int a, int b, int c, int d)
		=> t <= a ? c
     : t >= b ? d
     : t.Map(a, b, c, d);
    public static f MapFrom01(this f t, int a, int b)
		=> t.Map(0f, 1f, a, b);
    public static f MapTo01(this f t, int a, int b)
		=> t.Map(a, b, 0f, 1f);

    // Checks
    public static bool IsPos(this f t)
		=> t > 0;
    public static bool IsNeg(this f t)
		=> t < 0;
    public static bool IsPosInf(this f t)
		=> f.IsPositiveInfinity(t);
    public static bool IsNegInf(this f t)
		=> f.IsNegativeInfinity(t);
    public static bool IsInf(this f t)
		=> f.IsInfinity(t);
    public static bool IsNaN(this f t)
		=> f.IsNaN(t);

    public static bool IsBetween(this f t, f a, f b)
		=> t >= a && t <= b;
    public static bool IsBetween(this f t, int a, int b)
		=> t >= a && t <= b;

    // Spatial
    public static f DistanceTo(this f t, f a)
		=> (t - a).Abs();
    public static f DistanceTo(this f t, int a)
		=> (t - a).Abs();

    // Conversions
    public static int ToInt(this f t)
		=> (int)t;
#if UNITY
    public static Vector2 ToVector2(this f t)
		=> new(t, t);
    public static Vector3 ToVector3(this f t)
		=> new(t, t, t);
    public static Vector4 ToVector4(this f t)
		=> new(t, t, t, t);

    public static Vector2 Append(this f t)
		=> new(t, 0);
    public static Vector2 Append(this f t, f y)
		=> new(t, y);
    public static Vector3 Append(this f t, f y, f z)
		=> new(t, y, z);
    public static Vector3 Append(this f t, Vector2 a)
		=> new(t, a.x, a.y);
    public static Vector4 Append(this f t, f y, f z, f w)
		=> new(t, y, z, w);
    public static Vector4 Append(this f t, Vector3 a)
		=> new(t, a.x, a.y, a.z);
#endif

    #region SET
    public static void SetAdd(this ref f t, int a)
		=> t = t.Add(a);
    public static void SetSub(this ref f t, int a)
		=> t = t.Sub(a);
    public static void SetMul(this ref f t, int a)
		=> t = t.Mul(a);
    public static void SetDiv(this ref f t, int a)
		=> t = t.Div(a);
    public static void SetPow(this ref f t, int a)
		=> t = t.Pow(a);
    public static void SetRoot(this ref f t, int a)
		=> t = t.Root(a);
    public static void SetMod(this ref f t, int a)
		=> t = t.Mod(a);
    public static void SetPosMod(this ref f t, int a)
		=> t = t.PosMod(a);
    public static void SetMin(this ref f t, int a)
		=> t = t.Min(a);
    public static void SetMax(this ref f t, int a)
		=> t = t.Max(a);
    public static void SetAvg(this ref f t, int a)
		=> t = t.Avg(a);

    public static void SetAdd(this ref f t, f a)
		=> t = t.Add(a);
    public static void SetSub(this ref f t, f a)
		=> t = t.Sub(a);
    public static void SetMul(this ref f t, f a)
		=> t = t.Mul(a);
    public static void SetDiv(this ref f t, f a)
		=> t = t.Div(a);
    public static void SetPow(this ref f t, f a)
		=> t = t.Pow(a);
    public static void SetRoot(this ref f t, f a)
		=> t = t.Root(a);
    public static void SetMod(this ref f t, f a)
		=> t = t.Mod(a);
    public static void SetPosMod(this ref f t, f a)
		=> t = t.PosMod(a);
    public static void SetMin(this ref f t, f a)
		=> t = t.Min(a);
    public static void SetMax(this ref f t, f a)
		=> t = t.Max(a);
    public static void SetAvg(this ref f t, f a)
		=> t = t.Avg(a);

    public static void SetNeg(this ref f t)
		=> t = t.Neg();
    public static void SetInv(this ref f t)
		=> t = t.Inv();
    public static void SetAbs(this ref f t)
		=> t = t.Abs();
    public static void SetSig(this ref f t)
		=> t = t.Sig();
    public static void SetSqrt(this ref f t)
		=> t = t.Sqrt();
    public static void SetSqrd(this ref f t)
		=> t = t.Sqrd();

    public static void SetSin(this ref f t, bool degrees = false)
		=> t = t.Sin(degrees);
    public static void SetCos(this ref f t, bool degrees = false)
		=> t = t.Cos(degrees);
    public static void SetTan(this ref f t, bool degrees = false)
		=> t = t.Tan(degrees);
    public static void SetCot(this ref f t, bool degrees = false)
		=> t = t.Cot(degrees);
    public static void SetSec(this ref f t, bool degrees = false)
		=> t = t.Sec(degrees);
    public static void SetCsc(this ref f t, bool degrees = false)
		=> t = t.Csc(degrees);
    public static void SetArcSin(this ref f t, bool degrees = false)
		=> t = t.ArcSin(degrees);
    public static void SetArcCos(this ref f t, bool degrees = false)
		=> t = t.ArcCos(degrees);
    public static void SetArcTan(this ref f t, bool degrees = false)
		=> t = t.ArcTan(degrees);

    public static void SetRound(this ref f t)
		=> t = t.Round();
    public static void SetRoundDown(this ref f t)
		=> t = t.RoundDown();
    public static void SetRoundUp(this ref f t)
		=> t = t.RoundUp();
    public static void SetRoundTowardsZero(this ref f t)
		=> t = t.RoundTowardsZero();
    public static void SetRoundAwayFromZero(this ref f t)
		=> t = t.RoundAwayFromZero();
    public static void SetRoundToDecimalDigits(this ref f t, int a)
		=> t = t.RoundToDecimalDigits(a);

    public static void SetRoundToMultiple(this ref f t, int a)
		=> t = t.RoundToMultiple(a);

    public static void SetRoundToMultiple(this ref f t, f a)
		=> t = t.RoundToMultiple(a);

    public static void SetClamp(this ref f t, int a, int b)
		=> t = t.Clamp(a, b);
    public static void SetClampMin(this ref f t, int a)
		=> t = t.ClampMin(a);
    public static void SetClampMax(this ref f t, int a)
		=> t = t.ClampMax(a);
    public static void SetLerp(this ref f t, int a, f b)
		=> t = t.Lerp(a, b);
    public static void SetLerpClamped(this ref f t, int a, f b)
		=> t = t.LerpClamped(a, b);
    public static f SetInverseLerp(this ref f t, int a, int b)
		=> t = t.InverseLerp(a, b);
    public static f SetInverseLerpClamped(this ref f t, int a, int b)
		=> t = t.SetInverseLerpClamped(a, b);
    public static void SetMap(this ref f t, int a, int b, int c, int d)
		=> t = t.Map(a, b, c, d);
    public static void SetMapClamped(this ref f t, int a, int b, int c, int d)
		=> t = t.MapClamped(a, b, c, d);
    public static void SetMapFrom01(this ref f t, int a, int b)
		=> t = t.MapFrom01(a, b);
    public static void SetMapTo01(this ref f t, int a, int b)
		=> t = t.MapTo01(a, b);

    public static void SetClamp(this ref f t, f a, f b)
		=> t = t.Clamp(a, b);
    public static void SetClampMin(this ref f t, f a)
		=> t = t.ClampMin(a);
    public static void SetClampMax(this ref f t, f a)
		=> t = t.ClampMax(a);
    public static void SetLerp(this ref f t, f a, f b)
		=> t = t.Lerp(a, b);
    public static void SetLerpClamped(this ref f t, f a, f b)
		=> t = t.LerpClamped(a, b);
    public static f SetInverseLerp(this ref f t, f a, f b)
		=> t = t.InverseLerp(a, b);
    public static f SetInverseLerpClamped(this ref f t, f a, f b)
		=> t = t.SetInverseLerpClamped(a, b);

    public static void SetMap(this ref f t, f a, f b, f c, f d)
		=> t = t.Map(a, b, c, d);
    public static void SetMapClamped(this ref f t, f a, f b, f c, f d)
		=> t = t.MapClamped(a, b, c, d);
    public static void SetMapFrom01(this ref f t, f a, f b)
		=> t = t.MapFrom01(a, b);
    public static void SetMapTo01(this ref f t, f a, f b)
		=> t = t.MapTo01(a, b);

    public static void SetClamp01(this ref f t)
		=> t = t.Clamp01();

    public static void SetDistanceTo(this ref f t, int a)
		=> t = t.DistanceTo(a);
    public static void SetDistanceTo(this ref f t, f a)
		=> t = t.DistanceTo(a);
    #endregion
}
