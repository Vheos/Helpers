namespace Vheos.Helpers.Math;

public static class Extensions_float
{
    // Constants
    private const float DEG_TO_RAD = 0.0174532924f;

    // Binary
    /// <summary>Returns <c><paramref name="this"/> + <paramref name="a"/></c></summary>
    public static float Add(this float @this, float a)
    => @this + a;
    /// <summary>Returns <c><paramref name="this"/> - <paramref name="a"/></c></summary>
    public static float Sub(this float @this, float a)
    => @this - a;
    /// <summary>Returns <c><paramref name="this"/> * <paramref name="a"/></c></summary>
    public static float Mul(this float @this, float a)
    => @this * a;
    /// <summary>Returns <c><paramref name="this"/> / <paramref name="a"/></c></summary>
    public static float Div(this float @this, float a)
    => @this / a;
    /// <summary>Returns the <c><paramref name="a"/></c>-th power of <c><paramref name="this"/></c></summary>
    public static float Pow(this float @this, float a)
    => (float)System.Math.Pow(@this, a);
    /// <summary>Returns the <c><paramref name="a"/></c>-th root of <c><paramref name="this"/></c></summary>
    public static float Root(this float @this, float a)
    => (float)System.Math.Pow(1f / @this, a);
    /// <summary>Returns <c><paramref name="this"/> % <paramref name="a"/></c> using truncated division</summary>
    /// <remarks>
    /// Examples:<br/><c>
    /// +2 Mod +3 = +2<br/>
    /// -2 Mod +3 = -2<br/>
    /// +2 Mod -3 = +2<br/>
    /// -2 Mod -3 = -2<br/>
    /// </c></remarks>
    public static float Mod(this float @this, float a)
    => @this % a;
    /// <summary>Returns <c><paramref name="this"/> % <paramref name="a"/></c> using floored division</summary>
    /// <remarks>
    /// Examples:<br/><c>
    /// +2 PosMod +3 = +2<br/>
    /// -2 PosMod +3 = +1<br/>
    /// +2 PosMod -3 = -1<br/>
    /// -2 PosMod -3 = -2<br/>
    /// </c></remarks>
    public static float PosMod(this float @this, float a)
    => (@this % a + a) % a;
    /// <summary>Returns the smaller number out of <c><paramref name="this"/> and <paramref name="a"/></c></summary>
    public static float Min(this float @this, float a)
    => @this < a ? @this : a;
    /// <summary>Returns the bigger number out of <c><paramref name="this"/> and <paramref name="a"/></c></summary>
    public static float Max(this float @this, float a)
    => @this > a ? @this : a;
    /// <summary>Returns the arithmetic mean of <c><paramref name="this"/> and <paramref name="a"/></c></summary>
    public static float Avg(this float @this, float a)
    => (@this + a) / 2f;

    /// <inheritdoc cref="Add(float, float)"/>
    public static float Add(this float @this, int a)
    => @this + a;
    /// <inheritdoc cref="Sub(float, float)"/>
    public static float Sub(this float @this, int a)
    => @this - a;
    /// <inheritdoc cref="Mul(float, float)"/>
    public static float Mul(this float @this, int a)
    => @this * a;
    /// <inheritdoc cref="Div(float, float)"/>
    public static float Div(this float @this, int a)
    => @this / a;
    /// <inheritdoc cref="Pow(float, float)"/>
    public static float Pow(this float @this, int a)
    => (float)System.Math.Pow(@this, a);
    /// <inheritdoc cref="Root(float, float)"/>
    public static float Root(this float @this, int a)
    => (float)System.Math.Pow(1f / @this, a);
    /// <inheritdoc cref="Mod(float, float)"/>
    public static float Mod(this float @this, int a)
    => @this % a;
    /// <inheritdoc cref="PosMod(float, float)"/>
    public static float PosMod(this float @this, int a)
    => (@this % a + a) % a;
    /// <inheritdoc cref="Min(float, float)"/>
    public static float Min(this float @this, int a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Max(float, float)"/>
    public static float Max(this float @this, int a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="Avg(float, float)"/>
    public static float Avg(this float @this, int a)
    => (@this + a) / 2f;

    // Unary
    /// <summary>Returns -<c><paramref name="this"/></c></summary>
    public static float Neg(this float @this)
    => -@this;
    /// <summary>Returns <c>1f / <paramref name="this"/></c></summary>
    public static float Inv(this float @this)
    => 1f / @this;
    /// <summary>Returns the absolute value of <c><paramref name="this"/></c></summary>
    public static float Abs(this float @this)
    => @this > 0f ? @this : -@this;
    /// <summary>Returns the sign of <c><paramref name="this"/></c></summary>
    /// <remarks>
    /// Examples:<br/><c>
    /// +3 Abs = +1<br/>
    /// 0 Abs = 0<br/>
    /// -3 Abs = -1<br/>
    /// </c></remarks>
    public static int Sig(this float @this)
    => @this > 0f ? +1
     : @this < 0f ? -1
     : 0;
    /// <summary>Returns the square of <c><paramref name="this"/></c></summary>
    public static float Sqrd(this float @this)
    => @this * @this;
    public static float Sqrt(this float @this)
    => (float)System.Math.Sqrt(@this);
    /// <summary>Returns the square root of <c><paramref name="this"/></c></summary>

    // Trig
    /// <summary>Returns the sine of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float Sin(this float @this, bool degrees = false)
    => Mathf.Sin(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the cosine of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float Cos(this float @this, bool degrees = false)
    => Mathf.Cos(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the tangent of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float Tan(this float @this, bool degrees = false)
    => Mathf.Tan(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the cotangent of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float Cot(this float @this, bool degrees = false)
    => 1f / Mathf.Tan(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the secant of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float Sec(this float @this, bool degrees = false)
    => 1f / Mathf.Cos(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the secant of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float Csc(this float @this, bool degrees = false)
    => 1f / Mathf.Sin(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the arcsine of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float ArcSin(this float @this, bool degrees = false)
    => Mathf.Asin(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the arccosine of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float ArcCos(this float @this, bool degrees = false)
    => Mathf.Acos(degrees ? @this * DEG_TO_RAD : @this);
    /// <summary>Returns the arctangent of <c><paramref name="this"/></c> radians
    /// (or degrees, if <c><paramref name="degrees"/></c> is <c><see langword="true"/></c>)</summary>
    public static float ArcTan(this float @this, bool degrees = false)
    => Mathf.Atan(degrees ? @this * DEG_TO_RAD : @this);

    // Round
    /// <summary>Returns <c><paramref name="this"/></c> rounded to the nearest integer</summary>
    public static int Round(this float @this)
    => (int)System.Math.Round(@this, MidpointRounding.AwayFromZero);
    /// <summary>Returns the biggest integer smaller than or equal to <c><paramref name="this"/></c></summary>
    public static int RoundDown(this float @this)
    => (int)System.Math.Floor(@this);
    /// <summary>Returns the smallest integer bigger than or equal to <c><paramref name="this"/></c></summary>
    public static int RoundUp(this float @this)
    => (int)System.Math.Ceiling(@this);
    /// <summary>Returns <c><paramref name="this"/></c> rounded down if positive, and up if negative</summary>
    public static int RoundTowardsZero(this float @this)
    => (int)@this;
    /// <summary>Returns <c><paramref name="this"/></c> rounded up if positive, and down if negative</summary>
    public static int RoundAwayFromZero(this float @this)
    => @this > 0 ? (int)System.Math.Ceiling(@this) : (int)System.Math.Floor(@this);
    /// <summary>Returns <c><paramref name="this"/></c> rounded to the <c><paramref name="a"/></c>-th decimal place</summary>
    public static float RoundToDecimalDigits(this float @this, int a)
    => (float)System.Math.Round(@this, a, MidpointRounding.AwayFromZero);

    /// <summary>Returns <c><paramref name="this"/></c> rounded to the nearest multiple of <c><paramref name="a"/></c></summary>
    public static float RoundToMultiple(this float @this, float a)
    => (float)System.Math.Round(@this / a, MidpointRounding.AwayFromZero) * a;
    /// <inheritdoc cref="RoundToMultiple(float, float)"/>
    public static int RoundToMultiple(this float @this, int a)
    => (int)System.Math.Round(@this / a, MidpointRounding.AwayFromZero) * a;

    // Map  
    /// <summary>Returns <c><paramref name="this"/></c> clamped between <c>0</c> and <c>1</c></summary>
    public static float Clamp01(this float @this)
    => @this < 0f ? 0f
     : @this > 1f ? 1f
     : @this;
    /// <summary>Returns <c><paramref name="this"/></c> clamped between <c><paramref name="a"/></c> and <c><paramref name="b"/></c></summary>
    public static float Clamp(this float @this, float a, float b)
    => @this < a ? a
     : @this > b ? b
     : @this;
    /// <summary>Returns <c><paramref name="this"/></c> clamped to a minimum of <c><paramref name="a"/></c></summary>
    public static float ClampMin(this float @this, float a)
    => @this > a ? @this : a;
    /// <summary>Returns <c><paramref name="this"/></c> clamped to a maximum of <c><paramref name="a"/></c></summary>
    public static float ClampMax(this float @this, float a)
    => @this < a ? @this : a;
    /// <summary>Returns a number at relative distance <c><paramref name="b"/></c> from <c><paramref name="this"/></c> to <c><paramref name="a"/></c></summary>
    public static float Lerp(this float @this, float a, float b)
    => @this + (a - @this) * b;
    /// <summary>Returns a number at relative distance <c><paramref name="b"/></c> from <c><paramref name="this"/></c> to <c><paramref name="a"/></c> 
    /// (clamped between <c><paramref name="this"/></c> and <c><paramref name="a"/></c>)</summary>
    public static float LerpClamped(this float @this, float a, float b)
    => b <= 0f ? @this
     : b >= 1f ? a
     : @this.Lerp(a, b);
    /// <summary>Returns relative distance from <c><paramref name="a"/></c> to <c><paramref name="b"/></c> at which <c><paramref name="this"/></c> number is</summary>
    public static float InverseLerp(this float @this, float a, float b)
    => (@this - a) / (b - a);
    /// <summary>Returns relative distance from <c><paramref name="a"/></c>to <c><paramref name="b"/></c> at which <c><paramref name="this"/></c> number is  
    /// (clamped between <c>0</c> and <c>1</c>)</summary>
    public static float InverseLerpClamped(this float @this, float a, float b)
    => @this <= a ? 0f
     : @this >= b ? 1f
     : @this.InverseLerp(a, b);
    /// <summary>Returns <c><paramref name="this"/></c> mapped from range <c>[<paramref name="a"/>, <paramref name="b"/>]</c> to <c>[<paramref name="c"/>, <paramref name="d"/>]</c></summary>
    public static float Map(this float @this, float a, float b, float c, float d)
    => (@this - a) * (d - c) / (b - a) + c;
    /// <summary>Returns <c><paramref name="this"/></c> mapped from range <c>[<paramref name="a"/>, <paramref name="b"/>]</c> to <c>[<paramref name="c"/>, <paramref name="d"/>]</c>
    /// (clamped between <c><paramref name="c"/></c> and <c><paramref name="d"/></c>)</summary>
    public static float MapClamped(this float @this, float a, float b, float c, float d)
    => @this <= a ? c
     : @this >= b ? d
     : @this.Map(a, b, c, d);
    /// <summary>Returns <c><paramref name="this"/></c> mapped from range <c>[0, 1]</c> to <c>[<paramref name="a"/>, <paramref name="b"/>]</c></summary>
    public static float MapFrom01(this float @this, float a, float b)
    => @this.Map(0f, 1f, a, b);
    /// <summary>Returns <c><paramref name="this"/></c> mapped from range <c>[<paramref name="a"/>, <paramref name="b"/>]</c> to <c>[0, 1]</c></summary>
    public static float MapTo01(this float @this, float a, float b)
    => @this.Map(a, b, 0f, 1f);

    /// <inheritdoc cref="Clamp(float, float, float)"/>
    public static float Clamp(this float @this, int a, int b)
    => @this < a ? a
     : @this > b ? b
     : @this;
    /// <inheritdoc cref="ClampMin(float, float)"/>
    public static float ClampMin(this float @this, int a)
    => @this > a ? @this : a;
    /// <inheritdoc cref="ClampMax(float, float)"/>
    public static float ClampMax(this float @this, int a)
    => @this < a ? @this : a;
    /// <inheritdoc cref="Lerp(float, float, float)"/>
    public static float Lerp(this float @this, int a, float b)
    => @this + (a - @this) * b;
    /// <inheritdoc cref="LerpClamped(float, float, float)"/>
    public static float LerpClamped(this float @this, int a, float b)
    => b <= 0f ? @this
     : b >= 1f ? a
     : @this.Lerp(a, b);
    /// <inheritdoc cref="InverseLerp(float, float, float)"/> 
    public static float InverseLerp(this float @this, int a, int b)
    => (@this - a) / (b - a);
    /// <inheritdoc cref="InverseLerpClamped(float, float, float)"/> 
    public static float InverseLerpClamped(this float @this, int a, int b)
    => @this <= a ? 0f
     : @this >= b ? 1f
     : @this.InverseLerp(a, b);
    /// <inheritdoc cref="Map(float, float, float, float, float)"/> 
    public static float Map(this float @this, int a, int b, int c, int d)
    => (@this - a) * (d - c) / (b - a) + c;
    /// <inheritdoc cref="MapClamped(float, float, float, float, float)"/> 
    public static float MapClamped(this float @this, int a, int b, int c, int d)
    => @this <= a ? c
     : @this >= b ? d
     : @this.Map(a, b, c, d);
    /// <inheritdoc cref="MapFrom01(float, float, float)"/> 
    public static float MapFrom01(this float @this, int a, int b)
    => @this.Map(0f, 1f, a, b);
    /// <inheritdoc cref="MapTo01(float, float, float)"/> 
    public static float MapTo01(this float @this, int a, int b)
    => @this.Map(a, b, 0f, 1f);

    // Checks
    /// <summary>Checks whether <c><paramref name="this"/> > 0</c></summary>
    public static bool IsPos(this float @this)
    => @this > 0;
    /// <summary>Checks whether <c><paramref name="this"/> <![CDATA[<]]> 0</c></summary>
    public static bool IsNeg(this float @this)
    => @this < 0;
    /// <summary>Checks whether <c><paramref name="this"/></c> is positive infinity (<c>+1f / 0f</c>)</summary>
    public static bool IsPosInf(this float @this)
    => float.IsPositiveInfinity(@this);
    /// <summary>Checks whether <c><paramref name="this"/></c> is negative infinity (<c>-1f / 0f</c>)</summary>
    public static bool IsNegInf(this float @this)
    => float.IsNegativeInfinity(@this);
    /// <summary>Checks whether <c><paramref name="this"/></c> is either positive or negative infinity</summary>
    public static bool IsInf(this float @this)
    => float.IsInfinity(@this);
    /// <summary>Checks whether <c><paramref name="this"/></c> is not a number (<c>0f / 0f</c>)</summary>
    public static bool IsNaN(this float @this)
    => float.IsNaN(@this);

    /// <summary>Checks whether <c><paramref name="this"/></c> is between <c><paramref name="a"/></c> and <c><paramref name="b"/></c> (both inclusive)</summary>
    public static bool IsBetween(this float @this, float a, float b)
    => @this >= a && @this <= b;
    /// <inheritdoc cref="IsBetween(float, float, float)"/> 
    public static bool IsBetween(this float @this, int a, int b)
    => @this >= a && @this <= b;

    // Spatial
    /// <summary>Returns the distance between <c><paramref name="this"/></c> and <c><paramref name="a"/></c></summary>
    public static float DistanceTo(this float @this, float a)
    => (@this - a).Abs();
    /// <inheritdoc cref="DistanceTo(float, int)"/>
    public static float DistanceTo(this float @this, int a)
    => (@this - a).Abs();

    // Conversions
    /// <summary>Returns <c><paramref name="this"/></c> cast to <c><see cref="int"/></c></summary>
    public static int ToInt(this float @this)
    => (int)@this;
#if UNITY
    /// <summary>Returns a vector with all its components set to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="this"/>)</c></summary>
    public static Vector2 ToVector2(this float @this)
    => new(@this, @this);
    /// <summary>Returns a vector with all its components set to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="this"/>, <paramref name="this"/>)</c></summary>
    public static Vector3 ToVector3(this float @this)
    => new(@this, @this, @this);
    /// <summary>Returns a vector with all its components set to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="this"/>, <paramref name="this"/>, <paramref name="this"/>)</c></summary>
    public static Vector4 ToVector4(this float @this)
    => new(@this, @this, @this, @this);

    /// <summary>Returns a vector created by appending <c>0</c> to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, 0)</c></summary>
    public static Vector2 Append(this float @this)
    => new(@this, 0);
    /// <summary>Returns a vector created by appending <c><paramref name="y"/></c> to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="y"/>)</c></summary>
    public static Vector2 Append(this float @this, float y)
    => new(@this, y);
    /// <summary>Returns a vector created by appending <c><paramref name="y"/></c> and <c><paramref name="z"/></c> to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="y"/>, <paramref name="z"/>)</c></summary>
    public static Vector3 Append(this float @this, float y, float z)
    => new(@this, y, z);
    /// <summary>Returns a vector created by appending <c><paramref name="a"/></c>'s components to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="a"/>.x, <paramref name="a"/>.y)</c></summary>
    public static Vector3 Append(this float @this, Vector2 a)
    => new(@this, a.x, a.y);
    /// <summary>Returns a vector created from appending <c><paramref name="y"/></c>, <c><paramref name="z"/></c> and <c><paramref name="w"/></c> to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="y"/>, <paramref name="z"/>, <paramref name="w"/>)</c></summary>
    public static Vector4 Append(this float @this, float y, float z, float w)
    => new(@this, y, z, w);
    /// <summary>Returns a vector created by appending <c><paramref name="a"/></c>'s components to <c><paramref name="this"/></c><br/>
    /// <c>= <see langword="new"/>(<paramref name="this"/>, <paramref name="a"/>.x, <paramref name="a"/>.y, <paramref name="a"/>.z)</c></summary>
    public static Vector4 Append(this float @this, Vector3 a)
    => new(@this, a.x, a.y, a.z);
#endif

    #region SET
    public static void SetAdd(this ref float @this, int a)
    => @this = @this.Add(a);
    public static void SetSub(this ref float @this, int a)
    => @this = @this.Sub(a);
    public static void SetMul(this ref float @this, int a)
    => @this = @this.Mul(a);
    public static void SetDiv(this ref float @this, int a)
    => @this = @this.Div(a);
    public static void SetPow(this ref float @this, int a)
    => @this = @this.Pow(a);
    public static void SetRoot(this ref float @this, int a)
    => @this = @this.Root(a);
    public static void SetMod(this ref float @this, int a)
    => @this = @this.Mod(a);
    public static void SetPosMod(this ref float @this, int a)
    => @this = @this.PosMod(a);
    public static void SetMin(this ref float @this, int a)
    => @this = @this.Min(a);
    public static void SetMax(this ref float @this, int a)
    => @this = @this.Max(a);
    public static void SetAvg(this ref float @this, int a)
    => @this = @this.Avg(a);

    public static void SetAdd(this ref float @this, float a)
    => @this = @this.Add(a);
    public static void SetSub(this ref float @this, float a)
    => @this = @this.Sub(a);
    public static void SetMul(this ref float @this, float a)
    => @this = @this.Mul(a);
    public static void SetDiv(this ref float @this, float a)
    => @this = @this.Div(a);
    public static void SetPow(this ref float @this, float a)
    => @this = @this.Pow(a);
    public static void SetRoot(this ref float @this, float a)
    => @this = @this.Root(a);
    public static void SetMod(this ref float @this, float a)
    => @this = @this.Mod(a);
    public static void SetPosMod(this ref float @this, float a)
    => @this = @this.PosMod(a);
    public static void SetMin(this ref float @this, float a)
    => @this = @this.Min(a);
    public static void SetMax(this ref float @this, float a)
    => @this = @this.Max(a);
    public static void SetAvg(this ref float @this, float a)
    => @this = @this.Avg(a);

    public static void SetNeg(this ref float @this)
    => @this = @this.Neg();
    public static void SetInv(this ref float @this)
    => @this = @this.Inv();
    public static void SetAbs(this ref float @this)
    => @this = @this.Abs();
    public static void SetSig(this ref float @this)
    => @this = @this.Sig();
    public static void SetSqrt(this ref float @this)
    => @this = @this.Sqrt();
    public static void SetSqrd(this ref float @this)
    => @this = @this.Sqrd();

    public static void SetSin(this ref float @this, bool degrees = false)
    => @this = @this.Sin(degrees);
    public static void SetCos(this ref float @this, bool degrees = false)
    => @this = @this.Cos(degrees);
    public static void SetTan(this ref float @this, bool degrees = false)
    => @this = @this.Tan(degrees);
    public static void SetCot(this ref float @this, bool degrees = false)
    => @this = @this.Cot(degrees);
    public static void SetSec(this ref float @this, bool degrees = false)
    => @this = @this.Sec(degrees);
    public static void SetCsc(this ref float @this, bool degrees = false)
    => @this = @this.Csc(degrees);
    public static void SetArcSin(this ref float @this, bool degrees = false)
    => @this = @this.ArcSin(degrees);
    public static void SetArcCos(this ref float @this, bool degrees = false)
    => @this = @this.ArcCos(degrees);
    public static void SetArcTan(this ref float @this, bool degrees = false)
    => @this = @this.ArcTan(degrees);

    public static void SetRound(this ref float @this)
    => @this = @this.Round();
    public static void SetRoundDown(this ref float @this)
    => @this = @this.RoundDown();
    public static void SetRoundUp(this ref float @this)
    => @this = @this.RoundUp();
    public static void SetRoundTowardsZero(this ref float @this)
    => @this = @this.RoundTowardsZero();
    public static void SetRoundAwayFromZero(this ref float @this)
    => @this = @this.RoundAwayFromZero();
    public static void SetRoundToDecimalDigits(this ref float @this, int a)
    => @this = @this.RoundToDecimalDigits(a);

    public static void SetRoundToMultiple(this ref float @this, int a)
    => @this = @this.RoundToMultiple(a);

    public static void SetRoundToMultiple(this ref float @this, float a)
    => @this = @this.RoundToMultiple(a);

    public static void SetClamp(this ref float @this, int a, int b)
    => @this = @this.Clamp(a, b);
    public static void SetClampMin(this ref float @this, int a)
    => @this = @this.ClampMin(a);
    public static void SetClampMax(this ref float @this, int a)
    => @this = @this.ClampMax(a);
    public static void SetLerp(this ref float @this, int a, float b)
    => @this = @this.Lerp(a, b);
    public static void SetLerpClamped(this ref float @this, int a, float b)
    => @this = @this.LerpClamped(a, b);
    public static float SetInverseLerp(this ref float @this, int a, int b)
    => @this = @this.InverseLerp(a, b);
    public static float SetInverseLerpClamped(this ref float @this, int a, int b)
    => @this = @this.SetInverseLerpClamped(a, b);
    public static void SetMap(this ref float @this, int a, int b, int c, int d)
    => @this = @this.Map(a, b, c, d);
    public static void SetMapClamped(this ref float @this, int a, int b, int c, int d)
    => @this = @this.MapClamped(a, b, c, d);
    public static void SetMapFrom01(this ref float @this, int a, int b)
    => @this = @this.MapFrom01(a, b);
    public static void SetMapTo01(this ref float @this, int a, int b)
    => @this = @this.MapTo01(a, b);

    public static void SetClamp(this ref float @this, float a, float b)
    => @this = @this.Clamp(a, b);
    public static void SetClampMin(this ref float @this, float a)
    => @this = @this.ClampMin(a);
    public static void SetClampMax(this ref float @this, float a)
    => @this = @this.ClampMax(a);
    public static void SetLerp(this ref float @this, float a, float b)
    => @this = @this.Lerp(a, b);
    public static void SetLerpClamped(this ref float @this, float a, float b)
    => @this = @this.LerpClamped(a, b);
    public static float SetInverseLerp(this ref float @this, float a, float b)
    => @this = @this.InverseLerp(a, b);
    public static float SetInverseLerpClamped(this ref float @this, float a, float b)
    => @this = @this.SetInverseLerpClamped(a, b);

    public static void SetMap(this ref float @this, float a, float b, float c, float d)
    => @this = @this.Map(a, b, c, d);
    public static void SetMapClamped(this ref float @this, float a, float b, float c, float d)
    => @this = @this.MapClamped(a, b, c, d);
    public static void SetMapFrom01(this ref float @this, float a, float b)
    => @this = @this.MapFrom01(a, b);
    public static void SetMapTo01(this ref float @this, float a, float b)
    => @this = @this.MapTo01(a, b);

    public static void SetClamp01(this ref float @this)
    => @this = @this.Clamp01();

    public static void SetDistanceTo(this ref float @this, int a)
    => @this = @this.DistanceTo(a);
    public static void SetDistanceTo(this ref float @this, float a)
    => @this = @this.DistanceTo(a);
    #endregion
}
