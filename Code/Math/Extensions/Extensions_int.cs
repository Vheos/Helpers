namespace Vheos.Helpers.Math;

static public class Extensions_int
{
    // Constants
    private const float DEG_TO_RAD = 0.017453f;

    // Binary
    /// <inheritdoc cref="Extensions_float.Add(float, float)"/>
    static public float Add(this int @this, float a)
    => @this + a;
    /// <inheritdoc cref="Extensions_float.Sub(float, float)"/>
    static public float Sub(this int @this, float a)
    => @this - a;
    /// <inheritdoc cref="Extensions_float.Mul(float, float)"/>
    static public float Mul(this int @this, float a)
    => @this * a;
    /// <inheritdoc cref="Extensions_float.Div(float, float)"/>
    static public float Div(this int @this, float a)
    => @this / a;
    /// <inheritdoc cref="Extensions_float.Pow(float, float)"/>
    static public float Pow(this int @this, float a)
    => (float)System.Math.Pow(@this, a);
    /// <inheritdoc cref="Extensions_float.Root(float, float)"/>
    static public float Root(this int @this, float a)
    => (int)System.Math.Pow(1f / @this, a);
    /// <inheritdoc cref="Extensions_float.Mod(float, float)"/>
    static public float Mod(this int @this, float a)
    => @this % a;
    /// <inheritdoc cref="Extensions_float.PosMod(float, float)"/>
    static public float PosMod(this int @this, float a)
    => (@this % a + a) % a;
    /// <inheritdoc cref="Extensions_float.Min(float, float)"/>
    static public float Min(this int @this, float a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Extensions_float.Max(float, float)"/>
    static public float Max(this int @this, float a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Extensions_float.Avg(float, float)"/>
    static public float Avg(this int @this, float a)
    => (@this + a) / 2f;

    /// <inheritdoc cref="Add(int, float)"/>
    static public int Add(this int @this, int a)
    => @this + a;
    /// <inheritdoc cref="Sub(int, float)"/>
    static public int Sub(this int @this, int a)
    => @this - a;
    /// <inheritdoc cref="Mul(int, float)"/>
    static public int Mul(this int @this, int a)
    => @this * a;
    /// <inheritdoc cref="Div(int, float)"/>
    static public int Div(this int @this, int a)
    => @this / a;
    /// <inheritdoc cref="Pow(int, float)"/>
    static public int Pow(this int @this, int a)
    => (int)System.Math.Pow(@this, a);
    /// <inheritdoc cref="Root(int, float)"/>
    static public float Root(this int @this, int a)
    => (float)System.Math.Pow(1f / @this, a);
    /// <inheritdoc cref="Mod(int, float)"/>
    static public int Mod(this int @this, int a)
    => @this % a;
    /// <inheritdoc cref="PosMod(int, float)"/>
    static public int PosMod(this int @this, int a)
    => (@this % a + a) % a;
    /// <inheritdoc cref="Min(int, float)"/>
    static public int Min(this int @this, int a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Max(int, float)"/>
    static public int Max(this int @this, int a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Avg(int, float)"/>
    static public float Avg(this int @this, int a)
    => (@this + a) / 2f;

    // Unary
    /// <inheritdoc cref="Extensions_float.Neg(float)"/>
    static public int Neg(this int @this)
    => -@this;
    /// <inheritdoc cref="Extensions_float.Inv(float)"/>
    static public float Inv(this int @this)
    => 1f / @this;
    /// <inheritdoc cref="Extensions_float.Abs(float)"/>
    static public int Abs(this int @this)
    => @this > 0 ? @this : -@this;
    /// <inheritdoc cref="Extensions_float.Sig(float)"/>
    static public int Sig(this int @this)
    => @this > 0 ? +1
     : @this < 0 ? -1
     : 0;
    /// <inheritdoc cref="Extensions_float.Sqrd(float)"/>
    static public int Sqrd(this int @this)
    => @this * @this;
    /// <inheritdoc cref="Extensions_float.Sqrt(float)"/>
    static public float Sqrt(this int @this)
    => (float)System.Math.Sqrt(@this);

    // Trig
    /// <summary>Returns the sine of <c><paramref name="this"/></c> degrees</summary>
    static public float Sin(this int @this)
    => Mathf.Sin(@this * DEG_TO_RAD);
    /// <summary>Returns the cosine of <c><paramref name="this"/></c> degrees</summary>
    static public float Cos(this int @this)
    => Mathf.Cos(@this * DEG_TO_RAD);
    /// <summary>Returns the tangent of <c><paramref name="this"/></c> degrees</summary>
    static public float Tan(this int @this)
    => Mathf.Tan(@this * DEG_TO_RAD);
    /// <summary>Returns the cotangent of <c><paramref name="this"/></c> degrees</summary>
    static public float Cot(this int @this)
    => 1f / Mathf.Tan(@this * DEG_TO_RAD);
    /// <summary>Returns the secant of <c><paramref name="this"/></c> degrees</summary>
    static public float Sec(this int @this)
    => 1f / Mathf.Cos(@this * DEG_TO_RAD);
    /// <summary>Returns the cosecant of <c><paramref name="this"/></c> degrees</summary>
    static public float Csc(this int @this)
    => 1f / Mathf.Sin(@this * DEG_TO_RAD);
    /// <summary>Returns the arcsine of <c><paramref name="this"/></c> degrees</summary>
    static public float ArcSin(this int @this)
    => Mathf.Asin(@this * DEG_TO_RAD);
    /// <summary>Returns the arccosine of <c><paramref name="this"/></c> degrees</summary>
    static public float ArcCos(this int @this)
    => Mathf.Acos(@this * DEG_TO_RAD);
    /// <summary>Returns the arctangent of <c><paramref name="this"/></c> degrees</summary>
    static public float ArcTan(this int @this)
    => Mathf.Atan(@this * DEG_TO_RAD);

    // Round
    /// <inheritdoc cref="Extensions_float.RoundToMultiple(float, float)"/>
    static public float RoundToMultiple(this int @this, float a)
    => (float)System.Math.Round(@this / a, MidpointRounding.AwayFromZero) * a;
    /// <inheritdoc cref="RoundToMultiple(int, float)"/>
    static public int RoundToMultiple(this int @this, int a)
    => (int)System.Math.Round((float)@this / a, MidpointRounding.AwayFromZero) * a;

    // Map
    /// <inheritdoc cref="Extensions_float.Clamp01(float)"/>
    static public int Clamp01(this int @this)
    => @this < 0 ? 0
     : @this > 1 ? 1
     : @this;
    /// <inheritdoc cref="Extensions_float.Clamp(float, float, float)"/>
    static public float Clamp(this int @this, float a, float b)
    => @this < a ? a
     : @this > b ? b
     : @this;
    /// <inheritdoc cref="Extensions_float.ClampMin(float, float)"/>
    static public float ClampMin(this int @this, float a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Extensions_float.ClampMax(float, float)"/>
    static public float ClampMax(this int @this, float a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Extensions_float.Lerp(float, float, float)"/>
    static public float Lerp(this int @this, float a, float b)
    => @this + (a - @this) * b;
    /// <inheritdoc cref="Extensions_float.LerpClamped(float, float, float)"/>
    static public float LerpClamped(this int @this, float a, float b)
    => b <= 0f ? @this
     : b >= 1f ? a
     : @this.Lerp(a, b);
    /// <inheritdoc cref="Extensions_float.InverseLerp(float, float, float)"/>
    static public float InverseLerp(this int @this, float a, float b)
    => (@this - a) / (b - a);
    /// <inheritdoc cref="Extensions_float.InverseLerpClamped(float, float, float)"/>
    static public float InverseLerpClamped(this int @this, float a, float b)
    => @this <= a ? 0f
     : @this >= b ? 1f
     : @this.InverseLerp(a, b);
    /// <inheritdoc cref="Extensions_float.Map(float, float, float, float, float)"/>
    static public float Map(this int @this, float a, float b, float c, float d)
    => (@this - a) * (d - c) / (float)(b - a) + c;
    /// <inheritdoc cref="Extensions_float.MapClamped(float, float, float, float, float)"/>
    static public float MapClamped(this int @this, float a, float b, float c, float d)
    => @this <= a ? c
     : @this >= b ? d
     : @this.Map(a, b, c, d);

    /// <inheritdoc cref="Clamp(int, float, float)"/>
    static public int Clamp(this int @this, int a, int b)
    => @this < a ? a
     : @this > b ? b
     : @this;
    /// <inheritdoc cref="ClampMin(int, float)"/>
    static public int ClampMin(this int @this, int a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="ClampMax(int, float)"/>
    static public int ClampMax(this int @this, int a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Lerp(int, float, float)"/>
    static public float Lerp(this int @this, int a, float b)
    => @this + (a - @this) * b;
    /// <inheritdoc cref="LerpClamped(int, float, float)"/>
    static public float LerpClamped(this int @this, int a, float b)
    => b <= 0f ? @this
     : b >= 1f ? a
     : @this.Lerp(a, b);
    /// <inheritdoc cref="InverseLerp(int, float, float)"/>
    static public float InverseLerp(this int @this, int a, int b)
    => (@this - a) / (b - a);
    /// <inheritdoc cref="InverseLerpClamped(int, float, float)"/>
    static public float InverseLerpClamped(this int @this, int a, int b)
    => @this <= a ? 0f
     : @this >= b ? 1f
     : @this.InverseLerp(a, b);
    /// <inheritdoc cref="Map(int, float, float, float, float)"/>
    static public float Map(this int @this, int a, int b, int c, int d)
    => (@this - a) * (d - c) / (float)(b - a) + c;
    /// <inheritdoc cref="MapClamped(int, float, float, float, float)"/>
    static public float MapClamped(this int @this, int a, int b, int c, int d)
    => @this <= a ? c
     : @this >= b ? d
     : @this.Map(a, b, c, d);

    // Checks
    /// <inheritdoc cref="Extensions_float.IsPos(float)"/>
    static public bool IsPos(this int @this)
    => @this > 0;
    /// <inheritdoc cref="Extensions_float.IsNeg(float)"/>
    static public bool IsNeg(this int @this)
    => @this < 0;
    /// <inheritdoc cref="Extensions_float.IsBetween(float, float, float)"/>
    static public bool IsBetween(this int @this, float a, float b)
    => @this >= a && @this <= b;
    /// <inheritdoc cref="Extensions_float.IsBetween(float, float, float)"/>
    static public bool IsBetween(this int @this, int a, int b)
    => @this >= a && @this <= b;

    /// <summary>Checks whether <c><paramref name="this"/> == 0</c></summary>
    static public bool IsZero(this int @this)
    => @this == 0;
    /// <summary>Checks whether <c><paramref name="this"/></c> is an even number</summary>
    static public bool IsEven(this int @this)
    => @this % 2 == 0;
    /// <summary>Checks whether <c><paramref name="this"/></c> is an odd number</summary>
    static public bool IsOdd(this int @this)
    => @this % 2 != 0;

    // Spatial
    /// <inheritdoc cref="Extensions_float.DistanceTo(float, float)"/>
    static public float DistanceTo(this int @this, float a)
    => (@this - a).Abs();
    /// <inheritdoc cref="DistanceTo(int, float)"/>
    static public int DistanceTo(this int @this, int a)
    => (@this - a).Abs();

    // Conversions
    /// <summary>Returns <c><paramref name="this"/></c> cast to <c><see cref="float"/></c></summary>
    static public float ToFloat(this int @this)
    => @this;
#if UNITY
    /// <inheritdoc cref="Extensions_float.ToVector2(float)"/>
    static public Vector2Int ToVector2Int(this int @this)
    => new(@this, @this);
    /// <inheritdoc cref="Extensions_float.ToVector3(float)"/>
    static public Vector3Int ToVector3Int(this int @this)
    => new(@this, @this, @this);

    /// <inheritdoc cref="Extensions_float.Append(float)"/>
    static public Vector2Int Append(this int @this)
    => new(@this, 0);
    /// <inheritdoc cref="Extensions_float.Append(float, float)"/>
    static public Vector2Int Append(this int @this, int y)
    => new(@this, y);
    /// <inheritdoc cref="Extensions_float.Append(float, float, float)"/>
    static public Vector3Int Append(this int @this, int y, int z)
    => new(@this, y, z);
    /// <inheritdoc cref="Extensions_float.Append(float, Vector2)"/>
    static public Vector3Int Append(this int @this, Vector2Int a)
    => new(@this, a.x, a.y);
    /// <inheritdoc cref="Extensions_float.Append(float, float, float, float)"/>
    static public Vector4Int Append(this int @this, int y, int z, int w)
    => new(@this, y, z, w);
    /// <inheritdoc cref="Extensions_float.Append(float, Vector3)"/>
    static public Vector4Int Append(this int @this, Vector3Int a)
    => new(@this, a.x, a.y, a.z);
#endif

    #region SET
    static public void SetAdd(this ref int @this, int a)
    => @this = @this.Add(a);
    static public void SetSub(this ref int @this, int a)
    => @this = @this.Sub(a);
    static public void SetMul(this ref int @this, int a)
    => @this = @this.Mul(a);
    static public void SetDiv(this ref int @this, int a)
    => @this = @this.Div(a);
    static public void SetPow(this ref int @this, int a)
    => @this = @this.Pow(a);
    static public void SetMod(this ref int @this, int a)
    => @this = @this.Mod(a);
    static public void SetPosMod(this ref int @this, int a)
    => @this = @this.PosMod(a);
    static public void SetMin(this ref int @this, int a)
    => @this = @this.Min(a);
    static public void SetMax(this ref int @this, int a)
    => @this = @this.Max(a);

    static public void SetNeg(this ref int @this)
    => @this = @this.Neg();
    static public void SetAbs(this ref int @this)
    => @this = @this.Abs();
    static public void SetSig(this ref int @this)
    => @this = @this.Sig();
    static public void SetSqrd(this ref int @this)
    => @this = @this.Sqrd();

    static public void SetRoundToMultiple(this ref int @this, int a)
    => @this = @this.RoundToMultiple(a);

    static public void SetClamp(this ref int @this, int a, int b)
    => @this = @this.Clamp(a, b);
    static public void SetClampMin(this ref int @this, int a)
    => @this = @this.ClampMin(a);
    static public void SetClampMax(this ref int @this, int a)
    => @this = @this.ClampMax(a);

    static public void SetDistanceTo(this ref int @this, int a)
    => @this = @this.DistanceTo(a);
    #endregion
}
