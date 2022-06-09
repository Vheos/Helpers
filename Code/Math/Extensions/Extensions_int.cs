namespace Vheos.Helpers.Math;

public static class Extensions_int
{
    // Constants
    private const float DEG_TO_RAD = 0.017453f;

    // Binary
    /// <inheritdoc cref="Extensions_float.Add(float, float)"/>
    public static float Add(this int @this, float a)
    => @this + a;
    /// <inheritdoc cref="Extensions_float.Sub(float, float)"/>
    public static float Sub(this int @this, float a)
    => @this - a;
    /// <inheritdoc cref="Extensions_float.Mul(float, float)"/>
    public static float Mul(this int @this, float a)
    => @this * a;
    /// <inheritdoc cref="Extensions_float.Div(float, float)"/>
    public static float Div(this int @this, float a)
    => @this / a;
    /// <inheritdoc cref="Extensions_float.Pow(float, float)"/>
    public static float Pow(this int @this, float a)
    => (float)System.Math.Pow(@this, a);
    /// <inheritdoc cref="Extensions_float.Root(float, float)"/>
    public static float Root(this int @this, float a)
    => (int)System.Math.Pow(1f / @this, a);
    /// <inheritdoc cref="Extensions_float.Mod(float, float)"/>
    public static float Mod(this int @this, float a)
    => @this % a;
    /// <inheritdoc cref="Extensions_float.PosMod(float, float)"/>
    public static float PosMod(this int @this, float a)
    => (@this % a + a) % a;
    /// <inheritdoc cref="Extensions_float.Min(float, float)"/>
    public static float Min(this int @this, float a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Extensions_float.Max(float, float)"/>
    public static float Max(this int @this, float a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Extensions_float.Avg(float, float)"/>
    public static float Avg(this int @this, float a)
    => (@this + a) / 2f;

    /// <inheritdoc cref="Add(int, float)"/>
    public static int Add(this int @this, int a)
    => @this + a;
    /// <inheritdoc cref="Sub(int, float)"/>
    public static int Sub(this int @this, int a)
    => @this - a;
    /// <inheritdoc cref="Mul(int, float)"/>
    public static int Mul(this int @this, int a)
    => @this * a;
    /// <inheritdoc cref="Div(int, float)"/>
    public static int Div(this int @this, int a)
    => @this / a;
    /// <inheritdoc cref="Pow(int, float)"/>
    public static int Pow(this int @this, int a)
    => (int)System.Math.Pow(@this, a);
    /// <inheritdoc cref="Root(int, float)"/>
    public static float Root(this int @this, int a)
    => (float)System.Math.Pow(1f / @this, a);
    /// <inheritdoc cref="Mod(int, float)"/>
    public static int Mod(this int @this, int a)
    => @this % a;
    /// <inheritdoc cref="PosMod(int, float)"/>
    public static int PosMod(this int @this, int a)
    => (@this % a + a) % a;
    /// <inheritdoc cref="Min(int, float)"/>
    public static int Min(this int @this, int a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Max(int, float)"/>
    public static int Max(this int @this, int a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Avg(int, float)"/>
    public static float Avg(this int @this, int a)
    => (@this + a) / 2f;

    // Unary
    /// <inheritdoc cref="Extensions_float.Neg(float)"/>
    public static int Neg(this int @this)
    => -@this;
    /// <inheritdoc cref="Extensions_float.Inv(float)"/>
    public static float Inv(this int @this)
    => 1f / @this;
    /// <inheritdoc cref="Extensions_float.Abs(float)"/>
    public static int Abs(this int @this)
    => @this > 0 ? @this : -@this;
    /// <inheritdoc cref="Extensions_float.Sig(float)"/>
    public static int Sig(this int @this)
    => @this > 0 ? +1
     : @this < 0 ? -1
     : 0;
    /// <inheritdoc cref="Extensions_float.Sqrd(float)"/>
    public static int Sqrd(this int @this)
    => @this * @this;
    /// <inheritdoc cref="Extensions_float.Sqrt(float)"/>
    public static float Sqrt(this int @this)
    => (float)System.Math.Sqrt(@this);

    // Trig
    /// <summary>Returns the sine of <c><paramref name="this"/></c> degrees</summary>
    public static float Sin(this int @this)
    => Mathf.Sin(@this * DEG_TO_RAD);
    /// <summary>Returns the cosine of <c><paramref name="this"/></c> degrees</summary>
    public static float Cos(this int @this)
    => Mathf.Cos(@this * DEG_TO_RAD);
    /// <summary>Returns the tangent of <c><paramref name="this"/></c> degrees</summary>
    public static float Tan(this int @this)
    => Mathf.Tan(@this * DEG_TO_RAD);
    /// <summary>Returns the cotangent of <c><paramref name="this"/></c> degrees</summary>
    public static float Cot(this int @this)
    => 1f / Mathf.Tan(@this * DEG_TO_RAD);
    /// <summary>Returns the secant of <c><paramref name="this"/></c> degrees</summary>
    public static float Sec(this int @this)
    => 1f / Mathf.Cos(@this * DEG_TO_RAD);
    /// <summary>Returns the cosecant of <c><paramref name="this"/></c> degrees</summary>
    public static float Csc(this int @this)
    => 1f / Mathf.Sin(@this * DEG_TO_RAD);
    /// <summary>Returns the arcsine of <c><paramref name="this"/></c> degrees</summary>
    public static float ArcSin(this int @this)
    => Mathf.Asin(@this * DEG_TO_RAD);
    /// <summary>Returns the arccosine of <c><paramref name="this"/></c> degrees</summary>
    public static float ArcCos(this int @this)
    => Mathf.Acos(@this * DEG_TO_RAD);
    /// <summary>Returns the arctangent of <c><paramref name="this"/></c> degrees</summary>
    public static float ArcTan(this int @this)
    => Mathf.Atan(@this * DEG_TO_RAD);

    // Round
    /// <inheritdoc cref="Extensions_float.RoundToMultiple(float, float)"/>
    public static float RoundToMultiple(this int @this, float a)
    => (float)System.Math.Round(@this / a, MidpointRounding.AwayFromZero) * a;
    /// <inheritdoc cref="RoundToMultiple(int, float)"/>
    public static int RoundToMultiple(this int @this, int a)
    => (int)System.Math.Round((float)@this / a, MidpointRounding.AwayFromZero) * a;

    // Map
    /// <inheritdoc cref="Extensions_float.Clamp01(float)"/>
    public static int Clamp01(this int @this)
    => @this < 0 ? 0
     : @this > 1 ? 1
     : @this;
    /// <inheritdoc cref="Extensions_float.Clamp(float, float, float)"/>
    public static float Clamp(this int @this, float a, float b)
    => @this < a ? a
     : @this > b ? b
     : @this;
    /// <inheritdoc cref="Extensions_float.ClampMin(float, float)"/>
    public static float ClampMin(this int @this, float a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Extensions_float.ClampMax(float, float)"/>
    public static float ClampMax(this int @this, float a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Extensions_float.Lerp(float, float, float)"/>
    public static float Lerp(this int @this, float a, float b)
    => @this + (a - @this) * b;
    /// <inheritdoc cref="Extensions_float.LerpClamped(float, float, float)"/>
    public static float LerpClamped(this int @this, float a, float b)
    => b <= 0f ? @this
     : b >= 1f ? a
     : @this.Lerp(a, b);
    /// <inheritdoc cref="Extensions_float.InverseLerp(float, float, float)"/>
    public static float InverseLerp(this int @this, float a, float b)
    => (@this - a) / (b - a);
    /// <inheritdoc cref="Extensions_float.InverseLerpClamped(float, float, float)"/>
    public static float InverseLerpClamped(this int @this, float a, float b)
    => @this <= a ? 0f
     : @this >= b ? 1f
     : @this.InverseLerp(a, b);
    /// <inheritdoc cref="Extensions_float.Map(float, float, float, float, float)"/>
    public static float Map(this int @this, float a, float b, float c, float d)
    => (@this - a) * (d - c) / (float)(b - a) + c;
    /// <inheritdoc cref="Extensions_float.MapClamped(float, float, float, float, float)"/>
    public static float MapClamped(this int @this, float a, float b, float c, float d)
    => @this <= a ? c
     : @this >= b ? d
     : @this.Map(a, b, c, d);

    /// <inheritdoc cref="Clamp(int, float, float)"/>
    public static int Clamp(this int @this, int a, int b)
    => @this < a ? a
     : @this > b ? b
     : @this;
    /// <inheritdoc cref="ClampMin(int, float)"/>
    public static int ClampMin(this int @this, int a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="ClampMax(int, float)"/>
    public static int ClampMax(this int @this, int a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Lerp(int, float, float)"/>
    public static float Lerp(this int @this, int a, float b)
    => @this + (a - @this) * b;
    /// <inheritdoc cref="LerpClamped(int, float, float)"/>
    public static float LerpClamped(this int @this, int a, float b)
    => b <= 0f ? @this
     : b >= 1f ? a
     : @this.Lerp(a, b);
    /// <inheritdoc cref="InverseLerp(int, float, float)"/>
    public static float InverseLerp(this int @this, int a, int b)
    => (@this - a) / (b - a);
    /// <inheritdoc cref="InverseLerpClamped(int, float, float)"/>
    public static float InverseLerpClamped(this int @this, int a, int b)
    => @this <= a ? 0f
     : @this >= b ? 1f
     : @this.InverseLerp(a, b);
    /// <inheritdoc cref="Map(int, float, float, float, float)"/>
    public static float Map(this int @this, int a, int b, int c, int d)
    => (@this - a) * (d - c) / (float)(b - a) + c;
    /// <inheritdoc cref="MapClamped(int, float, float, float, float)"/>
    public static float MapClamped(this int @this, int a, int b, int c, int d)
    => @this <= a ? c
     : @this >= b ? d
     : @this.Map(a, b, c, d);

    // Checks
    /// <inheritdoc cref="Extensions_float.IsPos(float)"/>
    public static bool IsPos(this int @this)
    => @this > 0;
    /// <inheritdoc cref="Extensions_float.IsNeg(float)"/>
    public static bool IsNeg(this int @this)
    => @this < 0;
    /// <inheritdoc cref="Extensions_float.IsBetween(float, float, float)"/>
    public static bool IsBetween(this int @this, float a, float b)
    => @this >= a && @this <= b;
    /// <inheritdoc cref="Extensions_float.IsBetween(float, float, float)"/>
    public static bool IsBetween(this int @this, int a, int b)
    => @this >= a && @this <= b;

    /// <summary>Checks whether <c><paramref name="this"/> == 0</c></summary>
    public static bool IsZero(this int @this)
    => @this == 0;
    /// <summary>Checks whether <c><paramref name="this"/></c> is an even number</summary>
    public static bool IsEven(this int @this)
    => @this % 2 == 0;
    /// <summary>Checks whether <c><paramref name="this"/></c> is an odd number</summary>
    public static bool IsOdd(this int @this)
    => @this % 2 != 0;

    // Spatial
    /// <inheritdoc cref="Extensions_float.DistanceTo(float, float)"/>
    public static float DistanceTo(this int @this, float a)
    => (@this - a).Abs();
    /// <inheritdoc cref="DistanceTo(int, float)"/>
    public static int DistanceTo(this int @this, int a)
    => (@this - a).Abs();

    // Conversions
    /// <summary>Returns <c><paramref name="this"/></c> cast to <c><see cref="float"/></c></summary>
    public static float ToFloat(this int @this)
    => @this;
#if UNITY
    /// <inheritdoc cref="Extensions_float.ToVector2(float)"/>
    public static Vector2Int ToVector2Int(this int @this)
    => new(@this, @this);
    /// <inheritdoc cref="Extensions_float.ToVector3(float)"/>
    public static Vector3Int ToVector3Int(this int @this)
    => new(@this, @this, @this);

    /// <inheritdoc cref="Extensions_float.Append(float)"/>
    public static Vector2Int Append(this int @this)
    => new(@this, 0);
    /// <inheritdoc cref="Extensions_float.Append(float, float)"/>
    public static Vector2Int Append(this int @this, int y)
    => new(@this, y);
    /// <inheritdoc cref="Extensions_float.Append(float, float, float)"/>
    public static Vector3Int Append(this int @this, int y, int z)
    => new(@this, y, z);
    /// <inheritdoc cref="Extensions_float.Append(float, Vector2)"/>
    public static Vector3Int Append(this int @this, Vector2Int a)
    => new(@this, a.x, a.y);
    /// <inheritdoc cref="Extensions_float.Append(float, float, float, float)"/>
    public static Vector4Int Append(this int @this, int y, int z, int w)
    => new(@this, y, z, w);
    /// <inheritdoc cref="Extensions_float.Append(float, Vector3)"/>
    public static Vector4Int Append(this int @this, Vector3Int a)
    => new(@this, a.x, a.y, a.z);
#endif

    #region SET
    public static void SetAdd(this ref int @this, int a)
    => @this = @this.Add(a);
    public static void SetSub(this ref int @this, int a)
    => @this = @this.Sub(a);
    public static void SetMul(this ref int @this, int a)
    => @this = @this.Mul(a);
    public static void SetDiv(this ref int @this, int a)
    => @this = @this.Div(a);
    public static void SetPow(this ref int @this, int a)
    => @this = @this.Pow(a);
    public static void SetMod(this ref int @this, int a)
    => @this = @this.Mod(a);
    public static void SetPosMod(this ref int @this, int a)
    => @this = @this.PosMod(a);
    public static void SetMin(this ref int @this, int a)
    => @this = @this.Min(a);
    public static void SetMax(this ref int @this, int a)
    => @this = @this.Max(a);

    public static void SetNeg(this ref int @this)
    => @this = @this.Neg();
    public static void SetAbs(this ref int @this)
    => @this = @this.Abs();
    public static void SetSig(this ref int @this)
    => @this = @this.Sig();
    public static void SetSqrd(this ref int @this)
    => @this = @this.Sqrd();

    public static void SetRoundToMultiple(this ref int @this, int a)
    => @this = @this.RoundToMultiple(a);

    public static void SetClamp(this ref int @this, int a, int b)
    => @this = @this.Clamp(a, b);
    public static void SetClampMin(this ref int @this, int a)
    => @this = @this.ClampMin(a);
    public static void SetClampMax(this ref int @this, int a)
    => @this = @this.ClampMax(a);

    public static void SetDistanceTo(this ref int @this, int a)
    => @this = @this.DistanceTo(a);
    #endregion
}
