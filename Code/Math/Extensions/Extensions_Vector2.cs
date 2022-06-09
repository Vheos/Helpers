#if UNITY
namespace Vheos.Helpers.Math;

public static class Extensions_Vector2
{
    // Binary
    public static Vector2 Add(this Vector2 @this, Vector2 a)
    => new(@this.x.Add(a.x), @this.y.Add(a.y));
    public static Vector2 Sub(this Vector2 @this, Vector2 a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y));
    public static Vector2 Mul(this Vector2 @this, Vector2 a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y));
    public static Vector2 Div(this Vector2 @this, Vector2 a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y));
    public static Vector2 Pow(this Vector2 @this, Vector2 a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y));
    public static Vector2 Root(this Vector2 @this, Vector2 a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y));
    public static Vector2 Mod(this Vector2 @this, Vector2 a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y));
    public static Vector2 PosMod(this Vector2 @this, Vector2 a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y));
    public static Vector2 Min(this Vector2 @this, Vector2 a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y));
    public static Vector2 Max(this Vector2 @this, Vector2 a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y));
    public static Vector2 Avg(this Vector2 @this, Vector2 a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y));

    public static Vector2 Add(this Vector2 @this, float x, float y)
    => new(@this.x.Add(x), @this.y.Add(y));
    public static Vector2 Sub(this Vector2 @this, float x, float y)
    => new(@this.x.Sub(x), @this.y.Sub(y));
    public static Vector2 Mul(this Vector2 @this, float x, float y)
    => new(@this.x.Mul(x), @this.y.Mul(y));
    public static Vector2 Div(this Vector2 @this, float x, float y)
    => new(@this.x.Div(x), @this.y.Div(y));
    public static Vector2 Pow(this Vector2 @this, float x, float y)
    => new(@this.x.Pow(x), @this.y.Pow(y));
    public static Vector2 Root(this Vector2 @this, float x, float y)
    => new(@this.x.Root(x), @this.y.Root(y));
    public static Vector2 Mod(this Vector2 @this, float x, float y)
    => new(@this.x.Mod(x), @this.y.Mod(y));
    public static Vector2 PosMod(this Vector2 @this, float x, float y)
    => new(@this.x.PosMod(x), @this.y.PosMod(y));
    public static Vector2 Min(this Vector2 @this, float x, float y)
    => new(@this.x.Min(x), @this.y.Min(y));
    public static Vector2 Max(this Vector2 @this, float x, float y)
    => new(@this.x.Max(x), @this.y.Max(y));
    public static Vector2 Avg(this Vector2 @this, float x, float y)
    => new(@this.x.Avg(x), @this.y.Avg(y));

    public static Vector2 Add(this Vector2 @this, float a)
    => new(@this.x.Add(a), @this.y.Add(a));
    public static Vector2 Sub(this Vector2 @this, float a)
    => new(@this.x.Sub(a), @this.y.Sub(a));
    public static Vector2 Mul(this Vector2 @this, float a)
    => new(@this.x.Mul(a), @this.y.Mul(a));
    public static Vector2 Div(this Vector2 @this, float a)
    => new(@this.x.Div(a), @this.y.Div(a));
    public static Vector2 Pow(this Vector2 @this, float a)
    => new(@this.x.Pow(a), @this.y.Pow(a));
    public static Vector2 Root(this Vector2 @this, float a)
    => new(@this.x.Root(a), @this.y.Root(a));
    public static Vector2 Mod(this Vector2 @this, float a)
    => new(@this.x.Mod(a), @this.y.Mod(a));
    public static Vector2 PosMod(this Vector2 @this, float a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a));
    public static Vector2 Min(this Vector2 @this, float a)
    => new(@this.x.Min(a), @this.y.Min(a));
    public static Vector2 Max(this Vector2 @this, float a)
    => new(@this.x.Max(a), @this.y.Max(a));
    public static Vector2 Avg(this Vector2 @this, float a)
    => new(@this.x.Avg(a), @this.y.Avg(a));

    public static Vector2 Add(this Vector2 @this, Vector2Int a)
=> new(@this.x.Add(a.x), @this.y.Add(a.y));
    public static Vector2 Sub(this Vector2 @this, Vector2Int a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y));
    public static Vector2 Mul(this Vector2 @this, Vector2Int a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y));
    public static Vector2 Div(this Vector2 @this, Vector2Int a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y));
    public static Vector2 Pow(this Vector2 @this, Vector2Int a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y));
    public static Vector2 Root(this Vector2 @this, Vector2Int a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y));
    public static Vector2 Mod(this Vector2 @this, Vector2Int a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y));
    public static Vector2 PosMod(this Vector2 @this, Vector2Int a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y));
    public static Vector2 Min(this Vector2 @this, Vector2Int a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y));
    public static Vector2 Max(this Vector2 @this, Vector2Int a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y));
    public static Vector2 Avg(this Vector2 @this, Vector2Int a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y));

    public static Vector2 Add(this Vector2 @this, int x, int y)
    => new(@this.x.Add(x), @this.y.Add(y));
    public static Vector2 Sub(this Vector2 @this, int x, int y)
    => new(@this.x.Sub(x), @this.y.Sub(y));
    public static Vector2 Mul(this Vector2 @this, int x, int y)
    => new(@this.x.Mul(x), @this.y.Mul(y));
    public static Vector2 Div(this Vector2 @this, int x, int y)
    => new(@this.x.Div(x), @this.y.Div(y));
    public static Vector2 Pow(this Vector2 @this, int x, int y)
    => new(@this.x.Pow(x), @this.y.Pow(y));
    public static Vector2 Root(this Vector2 @this, int x, int y)
    => new(@this.x.Root(x), @this.y.Root(y));
    public static Vector2 Mod(this Vector2 @this, int x, int y)
    => new(@this.x.Mod(x), @this.y.Mod(y));
    public static Vector2 PosMod(this Vector2 @this, int x, int y)
    => new(@this.x.PosMod(x), @this.y.PosMod(y));
    public static Vector2 Min(this Vector2 @this, int x, int y)
    => new(@this.x.Min(x), @this.y.Min(y));
    public static Vector2 Max(this Vector2 @this, int x, int y)
    => new(@this.x.Max(x), @this.y.Max(y));
    public static Vector2 Avg(this Vector2 @this, int x, int y)
    => new(@this.x.Avg(x), @this.y.Avg(y));

    public static Vector2 Add(this Vector2 @this, int a)
    => new(@this.x.Add(a), @this.y.Add(a));
    public static Vector2 Sub(this Vector2 @this, int a)
    => new(@this.x.Sub(a), @this.y.Sub(a));
    public static Vector2 Mul(this Vector2 @this, int a)
    => new(@this.x.Mul(a), @this.y.Mul(a));
    public static Vector2 Div(this Vector2 @this, int a)
    => new(@this.x.Div(a), @this.y.Div(a));
    public static Vector2 Pow(this Vector2 @this, int a)
    => new(@this.x.Pow(a), @this.y.Pow(a));
    public static Vector2 Root(this Vector2 @this, int a)
    => new(@this.x.Root(a), @this.y.Root(a));
    public static Vector2 Mod(this Vector2 @this, int a)
    => new(@this.x.Mod(a), @this.y.Mod(a));
    public static Vector2 PosMod(this Vector2 @this, int a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a));
    public static Vector2 Min(this Vector2 @this, int a)
    => new(@this.x.Min(a), @this.y.Min(a));
    public static Vector2 Max(this Vector2 @this, int a)
    => new(@this.x.Max(a), @this.y.Max(a));
    public static Vector2 Avg(this Vector2 @this, int a)
    => new(@this.x.Avg(a), @this.y.Avg(a));

    // Unary
    public static Vector2 Neg(this Vector2 @this)
    => new(@this.x.Neg(), @this.y.Neg());
    public static Vector2 Inv(this Vector2 @this)
    => new(@this.x.Inv(), @this.y.Inv());
    public static Vector2 Abs(this Vector2 @this)
    => new(@this.x.Abs(), @this.y.Abs());
    public static Vector2Int Sig(this Vector2 @this)
    => new(@this.x.Sig(), @this.y.Sig());
    public static Vector2 Sqrd(this Vector2 @this)
    => new(@this.x.Sqrd(), @this.y.Sqrd());
    public static Vector2 Sqrt(this Vector2 @this)
    => new(@this.x.Sqrt(), @this.y.Sqrt());

    // Trig
    public static Vector2 Sin(this Vector2 @this, bool degrees = false)
    => new(@this.x.Sin(degrees), @this.y.Sin(degrees));
    public static Vector2 Cos(this Vector2 @this, bool degrees = false)
    => new(@this.x.Cos(degrees), @this.y.Cos(degrees));
    public static Vector2 Tan(this Vector2 @this, bool degrees = false)
    => new(@this.x.Tan(degrees), @this.y.Tan(degrees));
    public static Vector2 Cot(this Vector2 @this, bool degrees = false)
    => new(@this.x.Cot(degrees), @this.y.Cot(degrees));
    public static Vector2 Sec(this Vector2 @this, bool degrees = false)
    => new(@this.x.Sec(degrees), @this.y.Sec(degrees));
    public static Vector2 Csc(this Vector2 @this, bool degrees = false)
    => new(@this.x.Csc(degrees), @this.y.Csc(degrees));
    public static Vector2 ArcSin(this Vector2 @this, bool degrees = false)
    => new(@this.x.ArcSin(degrees), @this.y.ArcSin(degrees));
    public static Vector2 ArcCos(this Vector2 @this, bool degrees = false)
    => new(@this.x.ArcCos(degrees), @this.y.ArcCos(degrees));
    public static Vector2 ArcTan(this Vector2 @this, bool degrees = false)
    => new(@this.x.ArcTan(degrees), @this.y.ArcTan(degrees));

    // Round
    public static Vector2Int Round(this Vector2 @this)
    => new(@this.x.Round(), @this.y.Round());
    public static Vector2Int RoundDown(this Vector2 @this)
    => new(@this.x.RoundDown(), @this.y.RoundDown());
    public static Vector2Int RoundUp(this Vector2 @this)
    => new(@this.x.RoundUp(), @this.y.RoundUp());
    public static Vector2Int RoundTowardsZero(this Vector2 @this)
    => new(@this.x.RoundTowardsZero(), @this.y.RoundTowardsZero());
    public static Vector2Int RoundAwayFromZero(this Vector2 @this)
    => new(@this.x.RoundAwayFromZero(), @this.y.RoundAwayFromZero());
    public static Vector2 RoundToDecimalDigits(this Vector2 @this, int a)
    => new(@this.x.RoundToDecimalDigits(a), @this.y.RoundToDecimalDigits(a));

    public static Vector2 RoundToMultiple(this Vector2 @this, Vector2 a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y));
    public static Vector2 RoundToMultiple(this Vector2 @this, float x, float y)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y));
    public static Vector2 RoundToMultiple(this Vector2 @this, float a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a));

    public static Vector2Int RoundToMultiple(this Vector2 @this, Vector2Int a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y));
    public static Vector2Int RoundToMultiple(this Vector2 @this, int x, int y)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y));
    public static Vector2Int RoundToMultiple(this Vector2 @this, int a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a));

    // Clamp
    public static Vector2 Clamp01(this Vector2 @this)
    => new(@this.x.Clamp01(), @this.y.Clamp01());

    public static Vector2 Clamp(this Vector2 @this, Vector2 a, Vector2 b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y));
    public static Vector2 ClampMin(this Vector2 @this, Vector2 a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y));
    public static Vector2 ClampMax(this Vector2 @this, Vector2 a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y));
    public static Vector2 Lerp(this Vector2 @this, Vector2 a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b));
    public static Vector2 LerpClamped(this Vector2 @this, Vector2 a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b));
    public static Vector2 Map(this Vector2 @this, Vector2 a, Vector2 b, Vector2 c, Vector2 d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y));
    public static Vector2 MapClamped(this Vector2 @this, Vector2 a, Vector2 b, Vector2 c, Vector2 d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y));
    public static Vector2 MapFrom01(this Vector2 @this, Vector2 a, Vector2 b)
    => new(@this.x.MapFrom01(a.x, b.x), @this.y.MapFrom01(a.y, b.y));
    public static Vector2 MapTo01(this Vector2 @this, Vector2 a, Vector2 b)
    => new(@this.x.MapTo01(a.x, b.x), @this.y.MapTo01(a.y, b.y));

    public static Vector2 Clamp(this Vector2 @this, float ax, float ay, float bx, float by)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by));
    public static Vector2 ClampMin(this Vector2 @this, float x, float y)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y));
    public static Vector2 ClampMax(this Vector2 @this, float x, float y)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y));
    public static Vector2 Lerp(this Vector2 @this, float x, float y, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b));
    public static Vector2 LerpClamped(this Vector2 @this, float x, float y, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b));
    public static Vector2 Map(this Vector2 @this, float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy));
    public static Vector2 MapClamped(this Vector2 @this, float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy));
    public static Vector2 MapFrom01(this Vector2 @this, float ax, float ay, float bx, float by)
    => new(@this.x.MapFrom01(ax, bx), @this.y.MapFrom01(ay, by));
    public static Vector2 MapTo01(this Vector2 @this, float ax, float ay, float bx, float by)
    => new(@this.x.MapTo01(ax, bx), @this.y.MapTo01(ay, by));

    public static Vector2 Clamp(this Vector2 @this, float a, float b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b));
    public static Vector2 ClampMin(this Vector2 @this, float a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a));
    public static Vector2 ClampMax(this Vector2 @this, float a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a));
    public static Vector2 Lerp(this Vector2 @this, float a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b));
    public static Vector2 LerpClamped(this Vector2 @this, float a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b));
    public static Vector2 Map(this Vector2 @this, float a, float b, float c, float d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d));
    public static Vector2 MapClamped(this Vector2 @this, float a, float b, float c, float d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d));
    public static Vector2 MapFrom01(this Vector2 @this, float a, float b)
    => new(@this.x.MapFrom01(a, b), @this.y.MapFrom01(a, b));
    public static Vector2 MapTo01(this Vector2 @this, float a, float b)
    => new(@this.x.MapTo01(a, b), @this.y.MapTo01(a, b));

    public static Vector2 Clamp(this Vector2 @this, Vector2Int a, Vector2Int b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y));
    public static Vector2 ClampMin(this Vector2 @this, Vector2Int a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y));
    public static Vector2 ClampMax(this Vector2 @this, Vector2Int a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y));
    public static Vector2 Lerp(this Vector2 @this, Vector2Int a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b));
    public static Vector2 LerpClamped(this Vector2 @this, Vector2Int a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b));
    public static Vector2 Map(this Vector2 @this, Vector2Int a, Vector2Int b, Vector2Int c, Vector2Int d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y));
    public static Vector2 MapClamped(this Vector2 @this, Vector2Int a, Vector2Int b, Vector2Int c, Vector2Int d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y));
    public static Vector2 MapFrom01(this Vector2 @this, Vector2Int a, Vector2Int b)
    => new(@this.x.MapFrom01(a.x, b.x), @this.y.MapFrom01(a.y, b.y));
    public static Vector2 MapTo01(this Vector2 @this, Vector2Int a, Vector2Int b)
    => new(@this.x.MapTo01(a.x, b.x), @this.y.MapTo01(a.y, b.y));

    public static Vector2 Clamp(this Vector2 @this, int ax, int ay, int bx, int by)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by));
    public static Vector2 ClampMin(this Vector2 @this, int x, int y)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y));
    public static Vector2 ClampMax(this Vector2 @this, int x, int y)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y));
    public static Vector2 Lerp(this Vector2 @this, int x, int y, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b));
    public static Vector2 LerpClamped(this Vector2 @this, int x, int y, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b));
    public static Vector2 Map(this Vector2 @this, int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy));
    public static Vector2 MapClamped(this Vector2 @this, int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy));
    public static Vector2 MapFrom01(this Vector2 @this, int ax, int ay, int bx, int by)
    => new(@this.x.MapFrom01(ax, bx), @this.y.MapFrom01(ay, by));
    public static Vector2 MapTo01(this Vector2 @this, int ax, int ay, int bx, int by)
    => new(@this.x.MapTo01(ax, bx), @this.y.MapTo01(ay, by));

    public static Vector2 Clamp(this Vector2 @this, int a, int b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b));
    public static Vector2 ClampMin(this Vector2 @this, int a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a));
    public static Vector2 ClampMax(this Vector2 @this, int a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a));
    public static Vector2 Lerp(this Vector2 @this, int a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b));
    public static Vector2 LerpClamped(this Vector2 @this, int a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b));
    public static Vector2 Map(this Vector2 @this, int a, int b, int c, int d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d));
    public static Vector2 MapClamped(this Vector2 @this, int a, int b, int c, int d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d));
    public static Vector2 MapFrom01(this Vector2 @this, int a, int b)
    => new(@this.x.MapFrom01(a, b), @this.y.MapFrom01(a, b));
    public static Vector2 MapTo01(this Vector2 @this, int a, int b)
    => new(@this.x.MapTo01(a, b), @this.y.MapTo01(a, b));

    // Rotate
    public static Vector3 Rotate(this Vector2 @this, Quaternion a)
    => a * @this;
    public static Vector3 Unrotate(this Vector2 @this, Quaternion a)
    => a.Neg() * @this;
    public static Vector2 RotateCW(this Vector2 @this)
    => new(@this.y, -@this.x);
    public static Vector2 RotateCCW(this Vector2 @this)
    => new(-@this.y, @this.x);

    public static Quaternion RotationTo(this Vector2 @this, Vector2 a)
    => Quaternion.FromToRotation(@this, a);
    public static Quaternion RotationFrom(this Vector2 @this, Vector2 a)
    => Quaternion.FromToRotation(a, @this);

    public static Quaternion RotationTo(this Vector2 @this, float x, float y)
    => Quaternion.FromToRotation(@this, new(x, y));
    public static Quaternion RotationFrom(this Vector2 @this, float x, float y)
    => Quaternion.FromToRotation(new(x, y), @this);

    public static Quaternion RotationTo(this Vector2 @this, Vector2Int a)
    => Quaternion.FromToRotation(@this, a.ToVector3());
    public static Quaternion RotationFrom(this Vector2 @this, Vector2Int a)
    => Quaternion.FromToRotation(a.ToVector3(), @this);

    public static Quaternion RotationTo(this Vector2 @this, int x, int y)
    => Quaternion.FromToRotation(@this, new(x, y));
    public static Quaternion RotationFrom(this Vector2 @this, int x, int y)
    => Quaternion.FromToRotation(new(x, y), @this);

    // Spatial
    public static float Dot(this Vector2 @this, Vector2 a)
    => @this.x * a.x + @this.y * a.y;
    public static float DistanceTo(this Vector2 @this, Vector2 a)
    => (a - @this).magnitude;
    public static Vector2 OffsetTo(this Vector2 @this, Vector2 a)
    => a - @this;
    public static Vector2 OffsetFrom(this Vector2 @this, Vector2 a)
    => @this - a;
    public static Vector2 DirectionTowards(this Vector2 @this, Vector2 a)
    => (a - @this).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2 @this, Vector2 a)
    => (@this - a).normalized;

    public static float Dot(this Vector2 @this, float x, float y)
    => @this.x * x + @this.y * y;
    public static float DistanceTo(this Vector2 @this, float x, float y)
    => new Vector2(x - @this.x, y - @this.y).magnitude;
    public static Vector2 OffsetTo(this Vector2 @this, float x, float y)
    => new(x - @this.x, y - @this.y);
    public static Vector2 OffsetFrom(this Vector2 @this, float x, float y)
    => new(@this.x - x, @this.y - y);
    public static Vector2 DirectionTowards(this Vector2 @this, float x, float y)
    => new Vector2(x - @this.x, y - @this.y).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2 @this, float x, float y)
    => new Vector2(@this.x - x, @this.y - y).normalized;

    public static float Dot(this Vector2 @this, Vector2Int a)
    => @this.x * a.x + @this.y * a.y;
    public static float DistanceTo(this Vector2 @this, Vector2Int a)
    => (a - @this).magnitude;
    public static Vector2 OffsetTo(this Vector2 @this, Vector2Int a)
    => a - @this;
    public static Vector2 OffsetFrom(this Vector2 @this, Vector2Int a)
    => @this - a;
    public static Vector2 DirectionTowards(this Vector2 @this, Vector2Int a)
    => (a - @this).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2 @this, Vector2Int a)
    => (@this - a).normalized;

    public static float Dot(this Vector2 @this, int x, int y)
    => @this.x * x + @this.y * y;
    public static float DistanceTo(this Vector2 @this, int x, int y)
    => new Vector2(x - @this.x, y - @this.y).magnitude;
    public static Vector2 OffsetTo(this Vector2 @this, int x, int y)
    => new(x - @this.x, y - @this.y);
    public static Vector2 OffsetFrom(this Vector2 @this, int x, int y)
    => new(@this.x - x, @this.y - y);
    public static Vector2 DirectionTowards(this Vector2 @this, int x, int y)
    => new Vector2(x - @this.x, y - @this.y).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2 @this, int x, int y)
    => new Vector2(@this.x - x, @this.y - y).normalized;

    // Transform
    public static Vector3 Transform(this Vector2 @this, Transform a)
    => a.TransformPoint(@this);
    public static Vector3 Untransform(this Vector2 @this, Transform a)
    => a.InverseTransformPoint(@this);
    public static Vector3 TransformNoScale(this Vector2 @this, Transform a)
    => a.TransformPoint(@this.Div(a.localScale));
    public static Vector3 UntransformNoScale(this Vector2 @this, Transform a)
    => a.InverseTransformPoint(@this).Mul(a.localScale);
    public static Vector3 TransformDirection(this Vector2 @this, Transform a)
    => a.TransformDirection(@this);
    public static Vector3 UntransformDirection(this Vector2 @this, Transform a)
    => a.InverseTransformDirection(@this);

    // Comps
    public static IEnumerable<float> Comps(this Vector2 @this)
    {
        yield return @this.x;
        yield return @this.y;
    }
    public static float CompSum(this Vector2 @this)
    => @this.x + @this.y;
    public static float CompProduct(this Vector2 @this)
    => @this.x * @this.y;
    public static float CompMin(this Vector2 @this)
    => Mathf.Min(@this.x, @this.y);
    public static float CompMax(this Vector2 @this)
    => Mathf.Max(@this.x, @this.y);
    public static float CompAvg(this Vector2 @this)
    => (@this.x + @this.y) / 2f;
    public static bool Any(this Vector2 @this, Func<float, bool> test)
    => test(@this.x) || test(@this.y);
    public static bool All(this Vector2 @this, Func<float, bool> test)
    => test(@this.x) && test(@this.y);

    public static Vector2 CompDistanceTo(this Vector2 @this, Vector2 a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y));
    public static Vector2 CompDistanceTo(this Vector2 @this, float x, float y)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y));
    public static Vector2 CompDistanceTo(this Vector2 @this, float a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a));

    public static Vector2 CompDistanceTo(this Vector2 @this, Vector2Int a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y));
    public static Vector2 CompDistanceTo(this Vector2 @this, int x, int y)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y));
    public static Vector2 CompDistanceTo(this Vector2 @this, int a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a));

    // Conversions
    public static Vector2Int ToVector2Int(this Vector2 @this)
    => new((int)@this.x, (int)@this.y);
    public static Vector3Int ToVector3Int(this Vector2 @this)
    => new((int)@this.x, (int)@this.y, 0);
    public static Vector4Int ToVector4Int(this Vector2 @this)
    => new((int)@this.x, (int)@this.y, 0, 0);

    public static Vector3 Append(this Vector2 @this)
    => new(@this.x, @this.y, 0f);
    public static Vector3 Append(this Vector2 @this, float z)
    => new(@this.x, @this.y, z);
    public static Vector4 Append(this Vector2 @this, float z, float w)
    => new(@this.x, @this.y, z, w);
    public static Vector4 Append(this Vector2 @this, Vector2 a)
    => @this.Append(a.x, a.y);

    // XYZW
    #region XYZW
    public static Vector2 NewX(this Vector2 @this, float x)
    => new(x, @this.y);
    public static Vector2 NewY(this Vector2 @this, float y)
    => new(@this.x, y);

    public static Vector2 XX(this Vector2 @this)
    => new(@this.x, @this.x);
    public static Vector2 XY(this Vector2 @this)
    => new(@this.x, @this.y);
    public static Vector2 YX(this Vector2 @this)
    => new(@this.y, @this.x);
    public static Vector2 YY(this Vector2 @this)
    => new(@this.y, @this.y);

    public static Vector3 XXX(this Vector2 @this)
    => new(@this.x, @this.x, @this.x);
    public static Vector3 XXY(this Vector2 @this)
    => new(@this.x, @this.x, @this.y);
    public static Vector3 XYX(this Vector2 @this)
    => new(@this.x, @this.y, @this.x);
    public static Vector3 XYY(this Vector2 @this)
    => new(@this.x, @this.y, @this.y);
    public static Vector3 YXX(this Vector2 @this)
    => new(@this.y, @this.x, @this.x);
    public static Vector3 YXY(this Vector2 @this)
    => new(@this.y, @this.x, @this.y);
    public static Vector3 YYX(this Vector2 @this)
    => new(@this.y, @this.y, @this.x);
    public static Vector3 YYY(this Vector2 @this)
    => new(@this.y, @this.y, @this.y);

    public static Vector4 XXXX(this Vector2 @this)
    => new(@this.x, @this.x, @this.x, @this.x);
    public static Vector4 XXXY(this Vector2 @this)
    => new(@this.x, @this.x, @this.x, @this.y);
    public static Vector4 XXYX(this Vector2 @this)
    => new(@this.x, @this.x, @this.y, @this.x);
    public static Vector4 XXYY(this Vector2 @this)
    => new(@this.x, @this.x, @this.y, @this.y);
    public static Vector4 XYXX(this Vector2 @this)
    => new(@this.x, @this.y, @this.x, @this.x);
    public static Vector4 XYXY(this Vector2 @this)
    => new(@this.x, @this.y, @this.x, @this.y);
    public static Vector4 XYYX(this Vector2 @this)
    => new(@this.x, @this.y, @this.y, @this.x);
    public static Vector4 XYYY(this Vector2 @this)
    => new(@this.x, @this.y, @this.y, @this.y);
    public static Vector4 YXXX(this Vector2 @this)
    => new(@this.y, @this.x, @this.x, @this.x);
    public static Vector4 YXXY(this Vector2 @this)
    => new(@this.y, @this.x, @this.x, @this.y);
    public static Vector4 YXYX(this Vector2 @this)
    => new(@this.y, @this.x, @this.y, @this.x);
    public static Vector4 YXYY(this Vector2 @this)
    => new(@this.y, @this.x, @this.y, @this.y);
    public static Vector4 YYXX(this Vector2 @this)
    => new(@this.y, @this.y, @this.x, @this.x);
    public static Vector4 YYXY(this Vector2 @this)
    => new(@this.y, @this.y, @this.x, @this.y);
    public static Vector4 YYYX(this Vector2 @this)
    => new(@this.y, @this.y, @this.y, @this.x);
    public static Vector4 YYYY(this Vector2 @this)
    => new(@this.y, @this.y, @this.y, @this.y);
    #endregion
}
#endif