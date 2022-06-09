#if UNITY
namespace Vheos.Helpers.Math;

public static class Extensions_Vector2Int
{
    // Binary
    public static Vector2 Add(this Vector2Int @this, Vector2 a)
    => new(@this.x.Add(a.x), @this.y.Add(a.y));
    public static Vector2 Sub(this Vector2Int @this, Vector2 a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y));
    public static Vector2 Mul(this Vector2Int @this, Vector2 a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y));
    public static Vector2 Div(this Vector2Int @this, Vector2 a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y));
    public static Vector2 Pow(this Vector2Int @this, Vector2 a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y));
    public static Vector2 Root(this Vector2Int @this, Vector2 a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y));
    public static Vector2 Mod(this Vector2Int @this, Vector2 a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y));
    public static Vector2 PosMod(this Vector2Int @this, Vector2 a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y));
    public static Vector2 Min(this Vector2Int @this, Vector2 a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y));
    public static Vector2 Max(this Vector2Int @this, Vector2 a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y));
    public static Vector2 Avg(this Vector2Int @this, Vector2 a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y));

    public static Vector2 Add(this Vector2Int @this, float x, float y)
    => new(@this.x.Add(x), @this.y.Add(y));
    public static Vector2 Sub(this Vector2Int @this, float x, float y)
    => new(@this.x.Sub(x), @this.y.Sub(y));
    public static Vector2 Mul(this Vector2Int @this, float x, float y)
    => new(@this.x.Mul(x), @this.y.Mul(y));
    public static Vector2 Div(this Vector2Int @this, float x, float y)
    => new(@this.x.Div(x), @this.y.Div(y));
    public static Vector2 Pow(this Vector2Int @this, float x, float y)
    => new(@this.x.Pow(x), @this.y.Pow(y));
    public static Vector2 Root(this Vector2Int @this, float x, float y)
    => new(@this.x.Root(x), @this.y.Root(y));
    public static Vector2 Mod(this Vector2Int @this, float x, float y)
    => new(@this.x.Mod(x), @this.y.Mod(y));
    public static Vector2 PosMod(this Vector2Int @this, float x, float y)
    => new(@this.x.PosMod(x), @this.y.PosMod(y));
    public static Vector2 Min(this Vector2Int @this, float x, float y)
    => new(@this.x.Min(x), @this.y.Min(y));
    public static Vector2 Max(this Vector2Int @this, float x, float y)
    => new(@this.x.Max(x), @this.y.Max(y));
    public static Vector2 Avg(this Vector2Int @this, float x, float y)
    => new(@this.x.Avg(x), @this.y.Avg(y));

    public static Vector2 Add(this Vector2Int @this, float a)
    => new(@this.x.Add(a), @this.y.Add(a));
    public static Vector2 Sub(this Vector2Int @this, float a)
    => new(@this.x.Sub(a), @this.y.Sub(a));
    public static Vector2 Mul(this Vector2Int @this, float a)
    => new(@this.x.Mul(a), @this.y.Mul(a));
    public static Vector2 Div(this Vector2Int @this, float a)
    => new(@this.x.Div(a), @this.y.Div(a));
    public static Vector2 Pow(this Vector2Int @this, float a)
    => new(@this.x.Pow(a), @this.y.Pow(a));
    public static Vector2 Root(this Vector2Int @this, float a)
    => new(@this.x.Root(a), @this.y.Root(a));
    public static Vector2 Mod(this Vector2Int @this, float a)
    => new(@this.x.Mod(a), @this.y.Mod(a));
    public static Vector2 PosMod(this Vector2Int @this, float a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a));
    public static Vector2 Min(this Vector2Int @this, float a)
    => new(@this.x.Min(a), @this.y.Min(a));
    public static Vector2 Max(this Vector2Int @this, float a)
    => new(@this.x.Max(a), @this.y.Max(a));
    public static Vector2 Avg(this Vector2Int @this, float a)
    => new(@this.x.Avg(a), @this.y.Avg(a));

    public static Vector2Int Add(this Vector2Int @this, Vector2Int a)
=> new(@this.x.Add(a.x), @this.y.Add(a.y));
    public static Vector2Int Sub(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y));
    public static Vector2Int Mul(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y));
    public static Vector2Int Div(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y));
    public static Vector2Int Pow(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y));
    public static Vector2 Root(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y));
    public static Vector2Int Mod(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y));
    public static Vector2Int PosMod(this Vector2Int @this, Vector2Int a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y));
    public static Vector2Int Min(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y));
    public static Vector2Int Max(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y));
    public static Vector2 Avg(this Vector2Int @this, Vector2Int a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y));

    public static Vector2Int Add(this Vector2Int @this, int x, int y)
    => new(@this.x.Add(x), @this.y.Add(y));
    public static Vector2Int Sub(this Vector2Int @this, int x, int y)
    => new(@this.x.Sub(x), @this.y.Sub(y));
    public static Vector2Int Mul(this Vector2Int @this, int x, int y)
    => new(@this.x.Mul(x), @this.y.Mul(y));
    public static Vector2Int Div(this Vector2Int @this, int x, int y)
    => new(@this.x.Div(x), @this.y.Div(y));
    public static Vector2Int Pow(this Vector2Int @this, int x, int y)
    => new(@this.x.Pow(x), @this.y.Pow(y));
    public static Vector2 Root(this Vector2Int @this, int x, int y)
    => new(@this.x.Root(x), @this.y.Root(y));
    public static Vector2Int Mod(this Vector2Int @this, int x, int y)
    => new(@this.x.Mod(x), @this.y.Mod(y));
    public static Vector2Int PosMod(this Vector2Int @this, int x, int y)
    => new(@this.x.PosMod(x), @this.y.PosMod(y));
    public static Vector2Int Min(this Vector2Int @this, int x, int y)
    => new(@this.x.Min(x), @this.y.Min(y));
    public static Vector2Int Max(this Vector2Int @this, int x, int y)
    => new(@this.x.Max(x), @this.y.Max(y));
    public static Vector2 Avg(this Vector2Int @this, int x, int y)
    => new(@this.x.Avg(x), @this.y.Avg(y));

    public static Vector2Int Add(this Vector2Int @this, int a)
    => new(@this.x.Add(a), @this.y.Add(a));
    public static Vector2Int Sub(this Vector2Int @this, int a)
    => new(@this.x.Sub(a), @this.y.Sub(a));
    public static Vector2Int Mul(this Vector2Int @this, int a)
    => new(@this.x.Mul(a), @this.y.Mul(a));
    public static Vector2Int Div(this Vector2Int @this, int a)
    => new(@this.x.Div(a), @this.y.Div(a));
    public static Vector2Int Pow(this Vector2Int @this, int a)
    => new(@this.x.Pow(a), @this.y.Pow(a));
    public static Vector2 Root(this Vector2Int @this, int a)
    => new(@this.x.Root(a), @this.y.Root(a));
    public static Vector2Int Mod(this Vector2Int @this, int a)
    => new(@this.x.Mod(a), @this.y.Mod(a));
    public static Vector2Int PosMod(this Vector2Int @this, int a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a));
    public static Vector2Int Min(this Vector2Int @this, int a)
    => new(@this.x.Min(a), @this.y.Min(a));
    public static Vector2Int Max(this Vector2Int @this, int a)
    => new(@this.x.Max(a), @this.y.Max(a));
    public static Vector2 Avg(this Vector2Int @this, int a)
    => new(@this.x.Avg(a), @this.y.Avg(a));

    // Unary
    public static Vector2Int Neg(this Vector2Int @this)
    => new(@this.x.Neg(), @this.y.Neg());
    public static Vector2 Inv(this Vector2Int @this)
    => new(@this.x.Inv(), @this.y.Inv());
    public static Vector2Int Abs(this Vector2Int @this)
    => new(@this.x.Abs(), @this.y.Abs());
    public static Vector2Int Sig(this Vector2Int @this)
    => new(@this.x.Sig(), @this.y.Sig());
    public static Vector2Int Sqrd(this Vector2Int @this)
    => new(@this.x.Sqrd(), @this.y.Sqrd());
    public static Vector2 Sqrt(this Vector2Int @this)
    => new(@this.x.Sqrt(), @this.y.Sqrt());

    // Trig
    public static Vector2 Sin(this Vector2Int @this)
    => new(@this.x.Sin(), @this.y.Sin());
    public static Vector2 Cos(this Vector2Int @this)
    => new(@this.x.Cos(), @this.y.Cos());
    public static Vector2 Tan(this Vector2Int @this)
    => new(@this.x.Tan(), @this.y.Tan());
    public static Vector2 Cot(this Vector2Int @this)
    => new(@this.x.Cot(), @this.y.Cot());
    public static Vector2 Sec(this Vector2Int @this)
    => new(@this.x.Sec(), @this.y.Sec());
    public static Vector2 Csc(this Vector2Int @this)
    => new(@this.x.Csc(), @this.y.Csc());
    public static Vector2 ArcSin(this Vector2Int @this)
    => new(@this.x.ArcSin(), @this.y.ArcSin());
    public static Vector2 ArcCos(this Vector2Int @this)
    => new(@this.x.ArcCos(), @this.y.ArcCos());
    public static Vector2 ArcTan(this Vector2Int @this)
    => new(@this.x.ArcTan(), @this.y.ArcTan());

    // Round
    public static Vector2 RoundToMultiple(this Vector2Int @this, Vector2 a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y));
    public static Vector2 RoundToMultiple(this Vector2Int @this, float x, float y)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y));
    public static Vector2 RoundToMultiple(this Vector2Int @this, float a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a));

    public static Vector2Int RoundToMultiple(this Vector2Int @this, Vector2Int a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y));
    public static Vector2Int RoundToMultiple(this Vector2Int @this, int x, int y)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y));
    public static Vector2Int RoundToMultiple(this Vector2Int @this, int a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a));

    // Clamp
    public static Vector2Int Clamp01(this Vector2Int @this)
    => new(@this.x.Clamp01(), @this.y.Clamp01());

    public static Vector2 Clamp(this Vector2Int @this, Vector2 a, Vector2 b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y));
    public static Vector2 ClampMin(this Vector2Int @this, Vector2 a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y));
    public static Vector2 ClampMax(this Vector2Int @this, Vector2 a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y));
    public static Vector2 Lerp(this Vector2Int @this, Vector2 a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b));
    public static Vector2 LerpClamped(this Vector2Int @this, Vector2 a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b));
    public static Vector2 Map(this Vector2Int @this, Vector2 a, Vector2 b, Vector2 c, Vector2 d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y));
    public static Vector2 MapClamped(this Vector2Int @this, Vector2 a, Vector2 b, Vector2 c, Vector2 d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y));

    public static Vector2 Clamp(this Vector2Int @this, float ax, float ay, float bx, float by)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by));
    public static Vector2 ClampMin(this Vector2Int @this, float x, float y)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y));
    public static Vector2 ClampMax(this Vector2Int @this, float x, float y)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y));
    public static Vector2 Lerp(this Vector2Int @this, float x, float y, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b));
    public static Vector2 LerpClamped(this Vector2Int @this, float x, float y, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b));
    public static Vector2 Map(this Vector2Int @this, float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy));
    public static Vector2 MapClamped(this Vector2Int @this, float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy));

    public static Vector2 Clamp(this Vector2Int @this, float a, float b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b));
    public static Vector2 ClampMin(this Vector2Int @this, float a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a));
    public static Vector2 ClampMax(this Vector2Int @this, float a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a));
    public static Vector2 Lerp(this Vector2Int @this, float a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b));
    public static Vector2 LerpClamped(this Vector2Int @this, float a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b));
    public static Vector2 Map(this Vector2Int @this, float a, float b, float c, float d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d));
    public static Vector2 MapClamped(this Vector2Int @this, float a, float b, float c, float d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d));

    public static Vector2Int Clamp(this Vector2Int @this, Vector2Int a, Vector2Int b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y));
    public static Vector2Int ClampMin(this Vector2Int @this, Vector2Int a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y));
    public static Vector2Int ClampMax(this Vector2Int @this, Vector2Int a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y));
    public static Vector2 Lerp(this Vector2Int @this, Vector2Int a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b));
    public static Vector2 LerpClamped(this Vector2Int @this, Vector2Int a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b));
    public static Vector2 Map(this Vector2Int @this, Vector2Int a, Vector2Int b, Vector2Int c, Vector2Int d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y));
    public static Vector2 MapClamped(this Vector2Int @this, Vector2Int a, Vector2Int b, Vector2Int c, Vector2Int d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y));

    public static Vector2Int Clamp(this Vector2Int @this, int ax, int ay, int bx, int by)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by));
    public static Vector2Int ClampMin(this Vector2Int @this, int x, int y)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y));
    public static Vector2Int ClampMax(this Vector2Int @this, int x, int y)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y));
    public static Vector2 Lerp(this Vector2Int @this, int x, int y, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b));
    public static Vector2 LerpClamped(this Vector2Int @this, int x, int y, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b));
    public static Vector2 Map(this Vector2Int @this, int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy));
    public static Vector2 MapClamped(this Vector2Int @this, int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy));

    public static Vector2Int Clamp(this Vector2Int @this, int a, int b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b));
    public static Vector2Int ClampMin(this Vector2Int @this, int a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a));
    public static Vector2Int ClampMax(this Vector2Int @this, int a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a));
    public static Vector2 Lerp(this Vector2Int @this, int a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b));
    public static Vector2 LerpClamped(this Vector2Int @this, int a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b));
    public static Vector2 Map(this Vector2Int @this, int a, int b, int c, int d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d));
    public static Vector2 MapClamped(this Vector2Int @this, int a, int b, int c, int d)
    => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d));

    // Rotate
    public static Vector3 Rotate(this Vector2Int @this, Quaternion a)
    => a * @this.ToVector3();
    public static Vector3 Unrotate(this Vector2Int @this, Quaternion a)
    => a.Neg() * @this.ToVector3();
    public static Vector2 RotateCW(this Vector2Int @this)
    => new(@this.y, -@this.x);
    public static Vector2 RotateCCW(this Vector2Int @this)
    => new(-@this.y, @this.x);

    public static Quaternion RotationTo(this Vector2Int @this, Vector2 a)
    => Quaternion.FromToRotation(@this.ToVector3(), a);
    public static Quaternion RotationFrom(this Vector2Int @this, Vector2 a)
    => Quaternion.FromToRotation(a, @this.ToVector3());

    public static Quaternion RotationTo(this Vector2Int @this, float x, float y)
    => Quaternion.FromToRotation(@this.ToVector3(), new(x, y));
    public static Quaternion RotationFrom(this Vector2Int @this, float x, float y)
    => Quaternion.FromToRotation(new(x, y), @this.ToVector3());

    public static Quaternion RotationTo(this Vector2Int @this, Vector2Int a)
    => Quaternion.FromToRotation(@this.ToVector3(), a.ToVector3());
    public static Quaternion RotationFrom(this Vector2Int @this, Vector2Int a)
    => Quaternion.FromToRotation(a.ToVector3(), @this.ToVector3());

    public static Quaternion RotationTo(this Vector2Int @this, int x, int y)
    => Quaternion.FromToRotation(@this.ToVector3(), new(x, y));
    public static Quaternion RotationFrom(this Vector2Int @this, int x, int y)
    => Quaternion.FromToRotation(new(x, y), @this.ToVector3());

    // Spatial
    public static float Dot(this Vector2Int @this, Vector2 a)
    => Vector2.Dot(@this, a);
    public static float DistanceTo(this Vector2Int @this, Vector2 a)
    => (a - @this).magnitude;
    public static Vector2 OffsetTo(this Vector2Int @this, Vector2 a)
    => a - @this;
    public static Vector2 OffsetFrom(this Vector2Int @this, Vector2 a)
    => @this - a;
    public static Vector2 DirectionTowards(this Vector2Int @this, Vector2 a)
    => (a - @this).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2Int @this, Vector2 a)
    => (@this - a).normalized;

    public static float Dot(this Vector2Int @this, float x, float y)
    => Vector2.Dot(@this, new(x, y));
    public static float DistanceTo(this Vector2Int @this, float x, float y)
    => new Vector2(x - @this.x, y - @this.y).magnitude;
    public static Vector2 OffsetTo(this Vector2Int @this, float x, float y)
    => new(x - @this.x, y - @this.y);
    public static Vector2 OffsetFrom(this Vector2Int @this, float x, float y)
    => new(@this.x - x, @this.y - y);
    public static Vector2 DirectionTowards(this Vector2Int @this, float x, float y)
    => new Vector2(x - @this.x, y - @this.y).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2Int @this, float x, float y)
    => new Vector2(@this.x - x, @this.y - y).normalized;

    public static float Dot(this Vector2Int @this, Vector2Int a)
    => Vector2.Dot(@this, a.ToVector2());
    public static float DistanceTo(this Vector2Int @this, Vector2Int a)
    => (a - @this).magnitude;
    public static Vector2 OffsetTo(this Vector2Int @this, Vector2Int a)
    => a - @this;
    public static Vector2 OffsetFrom(this Vector2Int @this, Vector2Int a)
    => @this - a;
    public static Vector2 DirectionTowards(this Vector2Int @this, Vector2Int a)
    => (a - @this).ToVector2().normalized;
    public static Vector2 DirectionAwayFrom(this Vector2Int @this, Vector2Int a)
    => (@this - a).ToVector2().normalized;

    public static float Dot(this Vector2Int @this, int x, int y)
    => Vector2.Dot(@this, new(x, y));
    public static float DistanceTo(this Vector2Int @this, int x, int y)
    => new Vector2(x - @this.x, y - @this.y).magnitude;
    public static Vector2 OffsetTo(this Vector2Int @this, int x, int y)
    => new(x - @this.x, y - @this.y);
    public static Vector2 OffsetFrom(this Vector2Int @this, int x, int y)
    => new(@this.x - x, @this.y - y);
    public static Vector2 DirectionTowards(this Vector2Int @this, int x, int y)
    => new Vector2(x - @this.x, y - @this.y).normalized;
    public static Vector2 DirectionAwayFrom(this Vector2Int @this, int x, int y)
    => new Vector2(@this.x - x, @this.y - y).normalized;

    // Transform
    public static Vector3 Transform(this Vector2Int @this, Transform a)
    => a.TransformPoint(@this.ToVector3());
    public static Vector3 Untransform(this Vector2Int @this, Transform a)
    => a.InverseTransformPoint(@this.ToVector3());
    public static Vector3 TransformNoScale(this Vector2Int @this, Transform a)
    => a.TransformPoint(@this.Div(a.localScale));
    public static Vector3 UntransformNoScale(this Vector2Int @this, Transform a)
    => a.InverseTransformPoint(@this.ToVector3()).Mul(a.localScale);
    public static Vector3 TransformDirection(this Vector2Int @this, Transform a)
    => a.TransformDirection(@this.ToVector3());
    public static Vector3 UntransformDirection(this Vector2Int @this, Transform a)
    => a.InverseTransformDirection(@this.ToVector3());

    // Comps
    public static IEnumerable<int> Comps(this Vector2Int @this)
    {
        yield return @this.x;
        yield return @this.y;
    }
    public static int CompSum(this Vector2Int @this)
    => @this.x + @this.y;
    public static int CompProduct(this Vector2Int @this)
    => @this.x * @this.y;
    public static int CompMin(this Vector2Int @this)
    => Mathf.Min(@this.x, @this.y);
    public static int CompMax(this Vector2Int @this)
    => Mathf.Max(@this.x, @this.y);
    public static float CompAvg(this Vector2Int @this)
    => (@this.x + @this.y) / 2f;
    public static bool Any(this Vector2Int @this, Func<int, bool> test)
    => test(@this.x) || test(@this.y);
    public static bool All(this Vector2Int @this, Func<int, bool> test)
    => test(@this.x) && test(@this.y);

    public static Vector2 CompDistanceTo(this Vector2Int @this, Vector2 a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y));
    public static Vector2 CompDistanceTo(this Vector2Int @this, float x, float y)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y));
    public static Vector2 CompDistanceTo(this Vector2Int @this, float a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a));

    public static Vector3Int CompDistanceTo(this Vector2Int @this, Vector2Int a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y));
    public static Vector3Int CompDistanceTo(this Vector2Int @this, int x, int y)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y));
    public static Vector3Int CompDistanceTo(this Vector2Int @this, int a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a));

    // Conversions
    public static Vector2 ToVector2(this Vector2Int @this)
    => new(@this.x, @this.y);
    public static Vector3 ToVector3(this Vector2Int @this)
    => new(@this.x, @this.y, 0f);
    public static Vector4 ToVector4(this Vector2Int @this)
    => new(@this.x, @this.y, 0f, 0f);

    public static Vector3Int Append(this Vector2Int @this)
    => new(@this.x, @this.y, 0);
    public static Vector3Int Append(this Vector2Int @this, int z)
    => new(@this.x, @this.y, z);
    public static Vector4Int Append(this Vector2Int @this, int z, int w)
    => new(@this.x, @this.y, z, w);
    public static Vector4Int Append(this Vector2Int @this, Vector2Int a)
    => new(@this.x, @this.y, a.x, a.y);

    // XYZW
    #region XYZW
    public static Vector2 NewX(this Vector2Int @this, float x)
    => new(x, @this.y);
    public static Vector2 NewY(this Vector2Int @this, float y)
    => new(@this.x, y);

    public static Vector2Int XX(this Vector2Int @this)
    => new(@this.x, @this.x);
    public static Vector2Int XY(this Vector2Int @this)
    => new(@this.x, @this.y);
    public static Vector2Int YX(this Vector2Int @this)
    => new(@this.y, @this.x);
    public static Vector2Int YY(this Vector2Int @this)
    => new(@this.y, @this.y);

    public static Vector3Int XXX(this Vector2Int @this)
    => new(@this.x, @this.x, @this.x);
    public static Vector3Int XXY(this Vector2Int @this)
    => new(@this.x, @this.x, @this.y);
    public static Vector3Int XYX(this Vector2Int @this)
    => new(@this.x, @this.y, @this.x);
    public static Vector3Int XYY(this Vector2Int @this)
    => new(@this.x, @this.y, @this.y);
    public static Vector3Int YXX(this Vector2Int @this)
    => new(@this.y, @this.x, @this.x);
    public static Vector3Int YXY(this Vector2Int @this)
    => new(@this.y, @this.x, @this.y);
    public static Vector3Int YYX(this Vector2Int @this)
    => new(@this.y, @this.y, @this.x);
    public static Vector3Int YYY(this Vector2Int @this)
    => new(@this.y, @this.y, @this.y);

    public static Vector4 XXXX(this Vector2Int @this)
    => new(@this.x, @this.x, @this.x, @this.x);
    public static Vector4 XXXY(this Vector2Int @this)
    => new(@this.x, @this.x, @this.x, @this.y);
    public static Vector4 XXYX(this Vector2Int @this)
    => new(@this.x, @this.x, @this.y, @this.x);
    public static Vector4 XXYY(this Vector2Int @this)
    => new(@this.x, @this.x, @this.y, @this.y);
    public static Vector4 XYXX(this Vector2Int @this)
    => new(@this.x, @this.y, @this.x, @this.x);
    public static Vector4 XYXY(this Vector2Int @this)
    => new(@this.x, @this.y, @this.x, @this.y);
    public static Vector4 XYYX(this Vector2Int @this)
    => new(@this.x, @this.y, @this.y, @this.x);
    public static Vector4 XYYY(this Vector2Int @this)
    => new(@this.x, @this.y, @this.y, @this.y);
    public static Vector4 YXXX(this Vector2Int @this)
    => new(@this.y, @this.x, @this.x, @this.x);
    public static Vector4 YXXY(this Vector2Int @this)
    => new(@this.y, @this.x, @this.x, @this.y);
    public static Vector4 YXYX(this Vector2Int @this)
    => new(@this.y, @this.x, @this.y, @this.x);
    public static Vector4 YXYY(this Vector2Int @this)
    => new(@this.y, @this.x, @this.y, @this.y);
    public static Vector4 YYXX(this Vector2Int @this)
    => new(@this.y, @this.y, @this.x, @this.x);
    public static Vector4 YYXY(this Vector2Int @this)
    => new(@this.y, @this.y, @this.x, @this.y);
    public static Vector4 YYYX(this Vector2Int @this)
    => new(@this.y, @this.y, @this.y, @this.x);
    public static Vector4 YYYY(this Vector2Int @this)
    => new(@this.y, @this.y, @this.y, @this.y);
    #endregion
}
#endif