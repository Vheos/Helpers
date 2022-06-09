#if UNITY
namespace Vheos.Helpers.Math;

public static class Extensions_Vector3Int
{
    // Binary
    public static Vector3 Add(this Vector3Int @this, Vector3 a)
    => new(@this.x.Add(a.x), @this.y.Add(a.y), @this.z.Add(a.z));
    public static Vector3 Sub(this Vector3Int @this, Vector3 a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y), @this.z.Sub(a.z));
    public static Vector3 Mul(this Vector3Int @this, Vector3 a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y), @this.z.Mul(a.z));
    public static Vector3 Div(this Vector3Int @this, Vector3 a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y), @this.z.Div(a.z));
    public static Vector3 Pow(this Vector3Int @this, Vector3 a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y), @this.z.Pow(a.z));
    public static Vector3 Root(this Vector3Int @this, Vector3 a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y), @this.z.Root(a.z));
    public static Vector3 Mod(this Vector3Int @this, Vector3 a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y), @this.z.Mod(a.z));
    public static Vector3 PosMod(this Vector3Int @this, Vector3 a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y), @this.z.PosMod(a.z));
    public static Vector3 Min(this Vector3Int @this, Vector3 a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y), @this.z.Min(a.z));
    public static Vector3 Max(this Vector3Int @this, Vector3 a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y), @this.z.Max(a.z));
    public static Vector3 Avg(this Vector3Int @this, Vector3 a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y), @this.z.Avg(a.z));

    public static Vector3 Add(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Add(x), @this.y.Add(y), @this.z.Add(z));
    public static Vector3 Sub(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Sub(x), @this.y.Sub(y), @this.z.Sub(z));
    public static Vector3 Mul(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Mul(x), @this.y.Mul(y), @this.z.Mul(z));
    public static Vector3 Div(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Div(x), @this.y.Div(y), @this.z.Div(z));
    public static Vector3 Pow(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Pow(x), @this.y.Pow(y), @this.z.Pow(z));
    public static Vector3 Root(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Root(x), @this.y.Root(y), @this.z.Root(z));
    public static Vector3 Mod(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Mod(x), @this.y.Mod(y), @this.z.Mod(z));
    public static Vector3 PosMod(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.PosMod(x), @this.y.PosMod(y), @this.z.PosMod(z));
    public static Vector3 Min(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Min(x), @this.y.Min(y), @this.z.Min(z));
    public static Vector3 Max(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Max(x), @this.y.Max(y), @this.z.Max(z));
    public static Vector3 Avg(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.Avg(x), @this.y.Avg(y), @this.z.Avg(z));

    public static Vector3 Add(this Vector3Int @this, float a)
    => new(@this.x.Add(a), @this.y.Add(a), @this.z.Add(a));
    public static Vector3 Sub(this Vector3Int @this, float a)
    => new(@this.x.Sub(a), @this.y.Sub(a), @this.z.Sub(a));
    public static Vector3 Mul(this Vector3Int @this, float a)
    => new(@this.x.Mul(a), @this.y.Mul(a), @this.z.Mul(a));
    public static Vector3 Div(this Vector3Int @this, float a)
    => new(@this.x.Div(a), @this.y.Div(a), @this.z.Div(a));
    public static Vector3 Pow(this Vector3Int @this, float a)
    => new(@this.x.Pow(a), @this.y.Pow(a), @this.z.Pow(a));
    public static Vector3 Root(this Vector3Int @this, float a)
    => new(@this.x.Root(a), @this.y.Root(a), @this.z.Root(a));
    public static Vector3 Mod(this Vector3Int @this, float a)
    => new(@this.x.Mod(a), @this.y.Mod(a), @this.z.Mod(a));
    public static Vector3 PosMod(this Vector3Int @this, float a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a), @this.z.PosMod(a));
    public static Vector3 Min(this Vector3Int @this, float a)
    => new(@this.x.Min(a), @this.y.Min(a), @this.z.Min(a));
    public static Vector3 Max(this Vector3Int @this, float a)
    => new(@this.x.Max(a), @this.y.Max(a), @this.z.Max(a));
    public static Vector3 Avg(this Vector3Int @this, float a)
    => new(@this.x.Avg(a), @this.y.Avg(a), @this.z.Avg(a));

    public static Vector3Int Add(this Vector3Int @this, Vector3Int a)
=> new(@this.x.Add(a.x), @this.y.Add(a.y), @this.z.Add(a.z));
    public static Vector3Int Sub(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y), @this.z.Sub(a.z));
    public static Vector3Int Mul(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y), @this.z.Mul(a.z));
    public static Vector3Int Div(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y), @this.z.Div(a.z));
    public static Vector3Int Pow(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y), @this.z.Pow(a.z));
    public static Vector3 Root(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y), @this.z.Root(a.z));
    public static Vector3Int Mod(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y), @this.z.Mod(a.z));
    public static Vector3Int PosMod(this Vector3Int @this, Vector3Int a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y), @this.z.PosMod(a.z));
    public static Vector3Int Min(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y), @this.z.Min(a.z));
    public static Vector3Int Max(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y), @this.z.Max(a.z));
    public static Vector3 Avg(this Vector3Int @this, Vector3Int a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y), @this.z.Avg(a.z));

    public static Vector3Int Add(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Add(x), @this.y.Add(y), @this.z.Add(z));
    public static Vector3Int Sub(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Sub(x), @this.y.Sub(y), @this.z.Sub(z));
    public static Vector3Int Mul(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Mul(x), @this.y.Mul(y), @this.z.Mul(z));
    public static Vector3Int Div(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Div(x), @this.y.Div(y), @this.z.Div(z));
    public static Vector3Int Pow(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Pow(x), @this.y.Pow(y), @this.z.Pow(z));
    public static Vector3 Root(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Root(x), @this.y.Root(y), @this.z.Root(z));
    public static Vector3Int Mod(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Mod(x), @this.y.Mod(y), @this.z.Mod(z));
    public static Vector3Int PosMod(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.PosMod(x), @this.y.PosMod(y), @this.z.PosMod(z));
    public static Vector3Int Min(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Min(x), @this.y.Min(y), @this.z.Min(z));
    public static Vector3Int Max(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Max(x), @this.y.Max(y), @this.z.Max(z));
    public static Vector3 Avg(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.Avg(x), @this.y.Avg(y), @this.z.Avg(z));

    public static Vector3Int Add(this Vector3Int @this, int a)
    => new(@this.x.Add(a), @this.y.Add(a), @this.z.Add(a));
    public static Vector3Int Sub(this Vector3Int @this, int a)
    => new(@this.x.Sub(a), @this.y.Sub(a), @this.z.Sub(a));
    public static Vector3Int Mul(this Vector3Int @this, int a)
    => new(@this.x.Mul(a), @this.y.Mul(a), @this.z.Mul(a));
    public static Vector3Int Div(this Vector3Int @this, int a)
    => new(@this.x.Div(a), @this.y.Div(a), @this.z.Div(a));
    public static Vector3Int Pow(this Vector3Int @this, int a)
    => new(@this.x.Pow(a), @this.y.Pow(a), @this.z.Pow(a));
    public static Vector3 Root(this Vector3Int @this, int a)
    => new(@this.x.Root(a), @this.y.Root(a), @this.z.Root(a));
    public static Vector3Int Mod(this Vector3Int @this, int a)
    => new(@this.x.Mod(a), @this.y.Mod(a), @this.z.Mod(a));
    public static Vector3Int PosMod(this Vector3Int @this, int a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a), @this.z.PosMod(a));
    public static Vector3Int Min(this Vector3Int @this, int a)
    => new(@this.x.Min(a), @this.y.Min(a), @this.z.Min(a));
    public static Vector3Int Max(this Vector3Int @this, int a)
    => new(@this.x.Max(a), @this.y.Max(a), @this.z.Max(a));
    public static Vector3 Avg(this Vector3Int @this, int a)
    => new(@this.x.Avg(a), @this.y.Avg(a), @this.z.Avg(a));

    // Unary
    public static Vector3Int Neg(this Vector3Int @this)
    => new(@this.x.Neg(), @this.y.Neg(), @this.z.Neg());
    public static Vector3 Inv(this Vector3Int @this)
    => new(@this.x.Inv(), @this.y.Inv(), @this.z.Inv());
    public static Vector3Int Abs(this Vector3Int @this)
    => new(@this.x.Abs(), @this.y.Abs(), @this.z.Abs());
    public static Vector3Int Sig(this Vector3Int @this)
    => new(@this.x.Sig(), @this.y.Sig(), @this.z.Sig());
    public static Vector3Int Sqrd(this Vector3Int @this)
    => new(@this.x.Sqrd(), @this.y.Sqrd(), @this.z.Sqrd());
    public static Vector3 Sqrt(this Vector3Int @this)
    => new(@this.x.Sqrt(), @this.y.Sqrt(), @this.z.Sqrt());

    // Trig
    public static Vector3 Sin(this Vector3Int @this)
    => new(@this.x.Sin(), @this.y.Sin(), @this.z.Sin());
    public static Vector3 Cos(this Vector3Int @this)
    => new(@this.x.Cos(), @this.y.Cos(), @this.z.Cos());
    public static Vector3 Tan(this Vector3Int @this)
    => new(@this.x.Tan(), @this.y.Tan(), @this.z.Tan());
    public static Vector3 Cot(this Vector3Int @this)
    => new(@this.x.Cot(), @this.y.Cot(), @this.z.Cot());
    public static Vector3 Sec(this Vector3Int @this)
    => new(@this.x.Sec(), @this.y.Sec(), @this.z.Sec());
    public static Vector3 Csc(this Vector3Int @this)
    => new(@this.x.Csc(), @this.y.Csc(), @this.z.Csc());
    public static Vector3 ArcSin(this Vector3Int @this)
    => new(@this.x.ArcSin(), @this.y.ArcSin(), @this.z.ArcSin());
    public static Vector3 ArcCos(this Vector3Int @this)
    => new(@this.x.ArcCos(), @this.y.ArcCos(), @this.z.ArcCos());
    public static Vector3 ArcTan(this Vector3Int @this)
    => new(@this.x.ArcTan(), @this.y.ArcTan(), @this.z.ArcTan());

    // Round
    public static Vector3 RoundToMultiple(this Vector3Int @this, Vector3 a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y), @this.z.RoundToMultiple(a.z));
    public static Vector3 RoundToMultiple(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y), @this.z.RoundToMultiple(z));
    public static Vector3 RoundToMultiple(this Vector3Int @this, float a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a), @this.z.RoundToMultiple(a));

    public static Vector3Int RoundToMultiple(this Vector3Int @this, Vector3Int a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y), @this.z.RoundToMultiple(a.z));
    public static Vector3Int RoundToMultiple(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y), @this.z.RoundToMultiple(z));
    public static Vector3Int RoundToMultiple(this Vector3Int @this, int a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a), @this.z.RoundToMultiple(a));

    // Clamp
    public static Vector3Int Clamp01(this Vector3Int @this)
    => new(@this.x.Clamp01(), @this.y.Clamp01(), @this.z.Clamp01());

    public static Vector3 Clamp(this Vector3Int @this, Vector3 a, Vector3 b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y), @this.z.Clamp(a.z, b.z));
    public static Vector3 ClampMin(this Vector3Int @this, Vector3 a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y), @this.z.ClampMin(a.z));
    public static Vector3 ClampMax(this Vector3Int @this, Vector3 a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y), @this.z.ClampMax(a.z));
    public static Vector3 Lerp(this Vector3Int @this, Vector3 a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b), @this.z.Lerp(a.z, b));
    public static Vector3 LerpClamped(this Vector3Int @this, Vector3 a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b), @this.z.LerpClamped(a.z, b));
    public static Vector3 Map(this Vector3Int @this, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y), @this.z.Map(a.z, b.z, c.z, d.z));
    public static Vector3 MapClamped(this Vector3Int @this, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y), @this.z.MapClamped(a.z, b.z, c.z, d.z));

    public static Vector3 Clamp(this Vector3Int @this, float ax, float ay, float az, float bx, float by, float bz)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by), @this.z.Clamp(az, bz));
    public static Vector3 ClampMin(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y), @this.z.ClampMin(z));
    public static Vector3 ClampMax(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y), @this.z.ClampMax(z));
    public static Vector3 Lerp(this Vector3Int @this, float x, float y, float z, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b), @this.z.Lerp(z, b));
    public static Vector3 LerpClamped(this Vector3Int @this, float x, float y, float z, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b), @this.z.LerpClamped(z, b));
    public static Vector3 Map(this Vector3Int @this, float ax, float ay, float az, float bx, float by, float bz, float cx, float cy, float cz, float dx, float dy, float dz)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy), @this.z.Map(az, bz, cz, dz));
    public static Vector3 MapClamped(this Vector3Int @this, float ax, float ay, float az, float bx, float by, float bz, float cx, float cy, float cz, float dx, float dy, float dz)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy), @this.z.MapClamped(az, bz, cz, dz));

    public static Vector3 Clamp(this Vector3Int @this, float a, float b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b), @this.z.Clamp(a, b));
    public static Vector3 ClampMin(this Vector3Int @this, float a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a), @this.z.ClampMin(a));
    public static Vector3 ClampMax(this Vector3Int @this, float a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a), @this.z.ClampMax(a));
    public static Vector3 Lerp(this Vector3Int @this, float a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b), @this.z.Lerp(a, b));
    public static Vector3 LerpClamped(this Vector3Int @this, float a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b), @this.z.LerpClamped(a, b));
    public static Vector3 Map(this Vector3Int @this, float a, float b, float c, float d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d), @this.z.Map(a, b, c, d));
    public static Vector3 MapClamped(this Vector3Int @this, float a, float b, float c, float d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d), @this.z.MapClamped(a, b, c, d));

    public static Vector3Int Clamp(this Vector3Int @this, Vector3Int a, Vector3Int b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y), @this.z.Clamp(a.z, b.z));
    public static Vector3Int ClampMin(this Vector3Int @this, Vector3Int a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y), @this.z.ClampMin(a.z));
    public static Vector3Int ClampMax(this Vector3Int @this, Vector3Int a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y), @this.z.ClampMax(a.z));
    public static Vector3 Lerp(this Vector3Int @this, Vector3Int a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b), @this.z.Lerp(a.z, b));
    public static Vector3 LerpClamped(this Vector3Int @this, Vector3Int a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b), @this.z.LerpClamped(a.z, b));
    public static Vector3 Map(this Vector3Int @this, Vector3Int a, Vector3Int b, Vector3Int c, Vector3Int d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y), @this.z.Map(a.z, b.z, c.z, d.z));
    public static Vector3 MapClamped(this Vector3Int @this, Vector3Int a, Vector3Int b, Vector3Int c, Vector3Int d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y), @this.z.MapClamped(a.z, b.z, c.z, d.z));

    public static Vector3Int Clamp(this Vector3Int @this, int ax, int ay, int az, int bx, int by, int bz)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by), @this.z.Clamp(az, bz));
    public static Vector3Int ClampMin(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y), @this.z.ClampMin(z));
    public static Vector3Int ClampMax(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y), @this.z.ClampMax(z));
    public static Vector3 Lerp(this Vector3Int @this, int x, int y, int z, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b), @this.z.Lerp(z, b));
    public static Vector3 LerpClamped(this Vector3Int @this, int x, int y, int z, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b), @this.z.LerpClamped(z, b));
    public static Vector3 Map(this Vector3Int @this, int ax, int ay, int az, int bx, int by, int bz, int cx, int cy, int cz, int dx, int dy, int dz)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy), @this.z.Map(az, bz, cz, dz));
    public static Vector3 MapClamped(this Vector3Int @this, int ax, int ay, int az, int bx, int by, int bz, int cx, int cy, int cz, int dx, int dy, int dz)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy), @this.z.MapClamped(az, bz, cz, dz));

    public static Vector3Int Clamp(this Vector3Int @this, int a, int b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b), @this.z.Clamp(a, b));
    public static Vector3Int ClampMin(this Vector3Int @this, int a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a), @this.z.ClampMin(a));
    public static Vector3Int ClampMax(this Vector3Int @this, int a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a), @this.z.ClampMax(a));
    public static Vector3 Lerp(this Vector3Int @this, int a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b), @this.z.Lerp(a, b));
    public static Vector3 LerpClamped(this Vector3Int @this, int a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b), @this.z.LerpClamped(a, b));
    public static Vector3 Map(this Vector3Int @this, int a, int b, int c, int d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d), @this.z.Map(a, b, c, d));
    public static Vector3 MapClamped(this Vector3Int @this, int a, int b, int c, int d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d), @this.z.MapClamped(a, b, c, d));

    // Rotate
    public static Vector3 Rotate(this Vector3Int @this, Quaternion a)
    => a * @this;
    public static Vector3 Unrotate(this Vector3Int @this, Quaternion a)
    => a.Neg() * @this;

    public static Quaternion RotationTo(this Vector3Int @this, Vector3 a)
    => Quaternion.FromToRotation(@this, a);
    public static Quaternion RotationFrom(this Vector3Int @this, Vector3 a)
    => Quaternion.FromToRotation(a, @this);

    public static Quaternion RotationTo(this Vector3Int @this, float x, float y, float z)
    => Quaternion.FromToRotation(@this, new(x, y, z));
    public static Quaternion RotationFrom(this Vector3Int @this, float x, float y, float z)
    => Quaternion.FromToRotation(new(x, y, z), @this);

    public static Quaternion RotationTo(this Vector3Int @this, Vector3Int a)
    => Quaternion.FromToRotation(@this, a);
    public static Quaternion RotationFrom(this Vector3Int @this, Vector3Int a)
    => Quaternion.FromToRotation(a, @this);

    public static Quaternion RotationTo(this Vector3Int @this, int x, int y, int z)
    => Quaternion.FromToRotation(@this, new(x, y, z));
    public static Quaternion RotationFrom(this Vector3Int @this, int x, int y, int z)
    => Quaternion.FromToRotation(new(x, y, z), @this);

    // Spatial
    public static float Dot(this Vector3Int @this, Vector3 a)
    => @this.x * a.x + @this.y * a.y + @this.z * a.z;
    public static float DistanceTo(this Vector3Int @this, Vector3 a)
    => (a - @this).magnitude;
    public static Vector3 OffsetTo(this Vector3Int @this, Vector3 a)
    => a - @this;
    public static Vector3 OffsetFrom(this Vector3Int @this, Vector3 a)
    => @this - a;
    public static Vector3 DirectionTowards(this Vector3Int @this, Vector3 a)
    => (a - @this).normalized;
    public static Vector3 DirectionAwayFrom(this Vector3Int @this, Vector3 a)
    => (@this - a).normalized;

    public static float Dot(this Vector3Int @this, float x, float y, float z)
    => @this.x * x + @this.y * y + @this.z * z;
    public static float DistanceTo(this Vector3Int @this, float x, float y, float z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).magnitude;
    public static Vector3 OffsetTo(this Vector3Int @this, float x, float y, float z)
    => new(x - @this.x, y - @this.y, z - @this.z);
    public static Vector3 OffsetFrom(this Vector3Int @this, float x, float y, float z)
    => new(@this.x - x, @this.y - y, @this.z - z);
    public static Vector3 DirectionTowards(this Vector3Int @this, float x, float y, float z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).normalized;
    public static Vector3 DirectionAwayFrom(this Vector3Int @this, float x, float y, float z)
    => new Vector3(@this.x - x, @this.y - y, @this.z - z).normalized;

    public static int Dot(this Vector3Int @this, Vector3Int a)
    => @this.x * a.x + @this.y * a.y + @this.z * a.z;
    public static float DistanceTo(this Vector3Int @this, Vector3Int a)
    => (a - @this).magnitude;
    public static Vector3 OffsetTo(this Vector3Int @this, Vector3Int a)
    => a - @this;
    public static Vector3 OffsetFrom(this Vector3Int @this, Vector3Int a)
    => @this - a;
    public static Vector3 DirectionTowards(this Vector3Int @this, Vector3Int a)
    => (a - @this).ToVector3().normalized;
    public static Vector3 DirectionAwayFrom(this Vector3Int @this, Vector3Int a)
    => (@this - a).ToVector3().normalized;

    public static int Dot(this Vector3Int @this, int x, int y, int z)
    => @this.x * x + @this.y * y + @this.z * z;
    public static float DistanceTo(this Vector3Int @this, int x, int y, int z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).magnitude;
    public static Vector3 OffsetTo(this Vector3Int @this, int x, int y, int z)
    => new(x - @this.x, y - @this.y, z - @this.z);
    public static Vector3 OffsetFrom(this Vector3Int @this, int x, int y, int z)
    => new(@this.x - x, @this.y - y, @this.z - z);
    public static Vector3 DirectionTowards(this Vector3Int @this, int x, int y, int z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).normalized;
    public static Vector3 DirectionAwayFrom(this Vector3Int @this, int x, int y, int z)
    => new Vector3(@this.x - x, @this.y - y, @this.z - z).normalized;

    public static float Dot(this Vector3Int @this, GameObject a)
    {
        Vector3 apos = a.transform.position;
        return @this.x * apos.x + @this.y * apos.y + @this.z * apos.z;
    }
    public static float DistanceTo(this Vector3Int @this, GameObject a)
    => (a.transform.position - @this).magnitude;
    public static Vector3 OffsetTo(this Vector3Int @this, GameObject a)
    => a.transform.position - @this;
    public static Vector3 OffsetFrom(this Vector3Int @this, GameObject a)
    => @this - a.transform.position;
    public static Vector3 DirectionTowards(this Vector3Int @this, GameObject a)
    => (a.transform.position - @this).normalized;
    public static Vector3 DirectionAwayFrom(this Vector3Int @this, GameObject a)
    => (@this - a.transform.position).normalized;

    public static float Dot(this Vector3Int @this, Component a)
    {
        Vector3 apos = a.transform.position;
        return @this.x * apos.x + @this.y * apos.y + @this.z * apos.z;
    }
    public static float DistanceTo(this Vector3Int @this, Component a)
    => (a.transform.position - @this).magnitude;
    public static Vector3 OffsetTo(this Vector3Int @this, Component a)
    => a.transform.position - @this;
    public static Vector3 OffsetFrom(this Vector3Int @this, Component a)
    => @this - a.transform.position;
    public static Vector3 DirectionTowards(this Vector3Int @this, Component a)
    => (a.transform.position - @this).normalized;
    public static Vector3 DirectionAwayFrom(this Vector3Int @this, Component a)
    => (@this - a.transform.position).normalized;

    // 3D uniques
    public static Vector3 Cross(this Vector3Int @this, Vector3 a)
    => new(@this.y * a.z - @this.z * a.y, @this.z * a.x - @this.x * a.z, @this.x * a.y - @this.y * a.x);
    public static Ray RayTowards(this Vector3Int @this, Vector3 a)
    => new(@this, @this.DirectionTowards(a));
    public static Ray RayAwayFrom(this Vector3Int @this, Vector3 a)
    => new(@this, @this.DirectionAwayFrom(a));

    public static Vector3 Cross(this Vector3Int @this, float x, float y, float z)
    => new(@this.y * z - @this.z * y, @this.z * x - @this.x * z, @this.x * y - @this.y * x);
    public static Ray RayTowards(this Vector3Int @this, float x, float y, float z)
    => new(@this, @this.DirectionTowards(x, y, z));
    public static Ray RayAwayFrom(this Vector3Int @this, float x, float y, float z)
    => new(@this, @this.DirectionAwayFrom(x, y, z));

    public static Vector3Int Cross(this Vector3Int @this, Vector3Int a)
    => new(@this.y * a.z - @this.z * a.y, @this.z * a.x - @this.x * a.z, @this.x * a.y - @this.y * a.x);
    public static Ray RayTowards(this Vector3Int @this, Vector3Int a)
    => new(@this, @this.DirectionTowards(a));
    public static Ray RayAwayFrom(this Vector3Int @this, Vector3Int a)
    => new(@this, @this.DirectionAwayFrom(a));

    public static Vector3Int Cross(this Vector3Int @this, int x, int y, int z)
    => new(@this.y * z - @this.z * y, @this.z * x - @this.x * z, @this.x * y - @this.y * x);
    public static Ray RayTowards(this Vector3Int @this, int x, int y, int z)
    => new(@this, @this.DirectionTowards(x, y, z));
    public static Ray RayAwayFrom(this Vector3Int @this, int x, int y, int z)
    => new(@this, @this.DirectionAwayFrom(x, y, z));

    public static Vector3 Cross(this Vector3Int @this, GameObject a)
    {
        Vector3 apos = a.transform.position;
        return new(@this.y * apos.z - @this.z * apos.y, @this.z * apos.x - @this.x * apos.z, @this.x * apos.y - @this.y * apos.x);
    }
    public static Ray RayTowards(this Vector3Int @this, GameObject a)
    => new(@this, @this.DirectionTowards(a));
    public static Ray RayAwayFrom(this Vector3Int @this, GameObject a)
    => new(@this, @this.DirectionAwayFrom(a));

    public static Vector3 Cross(this Vector3Int @this, Component a)
    {
        Vector3 apos = a.transform.position;
        return new(@this.y * apos.z - @this.z * apos.y, @this.z * apos.x - @this.x * apos.z, @this.x * apos.y - @this.y * apos.x);
    }
    public static Ray RayTowards(this Vector3Int @this, Component a)
    => new(@this, @this.DirectionTowards(a));
    public static Ray RayAwayFrom(this Vector3Int @this, Component a)
    => new(@this, @this.DirectionAwayFrom(a));

    // Spatial (screen)
    public static float ScreenDistanceTo(this Vector3Int @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().magnitude;
    public static Vector2 ScreenOffsetTo(this Vector3Int @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY();
    public static Vector2 ScreenOffsetFrom(this Vector3Int @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY();
    public static Vector2 ScreenDirectionTowards(this Vector3Int @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().normalized;
    public static Vector2 ScreenDirectionAwayFrom(this Vector3Int @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY().normalized;

    public static float ScreenDistanceTo(this Vector3Int @this, GameObject a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).XY().magnitude;
    public static Vector2 ScreenOffsetTo(this Vector3Int @this, GameObject a, Camera b)
    => b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this);
    public static Vector2 ScreenOffsetFrom(this Vector3Int @this, GameObject a, Camera b)
    => b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position);
    public static Vector2 ScreenDirectionTowards(this Vector3Int @this, GameObject a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).normalized;
    public static Vector2 ScreenDirectionAwayFrom(this Vector3Int @this, GameObject a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position)).normalized;

    public static float ScreenDistanceTo(this Vector3Int @this, Component a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).XY().magnitude;
    public static Vector2 ScreenOffsetTo(this Vector3Int @this, Component a, Camera b)
    => b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this);
    public static Vector2 ScreenOffsetFrom(this Vector3Int @this, Component a, Camera b)
    => b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position);
    public static Vector2 ScreenDirectionTowards(this Vector3Int @this, Component a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).normalized;
    public static Vector2 ScreenDirectionAwayFrom(this Vector3Int @this, Component a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position)).normalized;

    public static float ScreenDistanceTo(this Vector3Int @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().magnitude;
    public static Vector2 ScreenOffsetTo(this Vector3Int @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY();
    public static Vector2 ScreenOffsetFrom(this Vector3Int @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY();
    public static Vector2 ScreenDirectionTowards(this Vector3Int @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().normalized;
    public static Vector2 ScreenDirectionAwayFrom(this Vector3Int @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY().normalized;

    public static float ScreenDistanceTo(this Vector3Int @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().magnitude;
    public static Vector2 ScreenOffsetTo(this Vector3Int @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY();
    public static Vector2 ScreenOffsetFrom(this Vector3Int @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY();
    public static Vector2 ScreenDirectionTowards(this Vector3Int @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().normalized;
    public static Vector2 ScreenDirectionAwayFrom(this Vector3Int @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY().normalized;

    public static float ScreenDistanceTo(this Vector3Int @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().magnitude;
    public static Vector2 ScreenOffsetTo(this Vector3Int @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY();
    public static Vector2 ScreenOffsetFrom(this Vector3Int @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY();
    public static Vector2 ScreenDirectionTowards(this Vector3Int @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().normalized;
    public static Vector2 ScreenDirectionAwayFrom(this Vector3Int @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY().normalized;

    // Transform
    public static Vector3 Transform(this Vector3Int @this, Transform a)
    => a.TransformPoint(@this);
    public static Vector3 Untransform(this Vector3Int @this, Transform a)
    => a.InverseTransformPoint(@this);
    public static Vector3 TransformNoScale(this Vector3Int @this, Transform a)
    => a.TransformPoint(@this.Div(a.localScale));
    public static Vector3 UntransformNoScale(this Vector3Int @this, Transform a)
    => a.InverseTransformPoint(@this).Mul(a.localScale);
    public static Vector3 TransformDirection(this Vector3Int @this, Transform a)
    => a.TransformDirection(@this);
    public static Vector3 UntransformDirection(this Vector3Int @this, Transform a)
    => a.InverseTransformDirection(@this);

    // Comps
    public static IEnumerable<int> Comps(this Vector3Int @this)
    {
        yield return @this.x;
        yield return @this.y;
        yield return @this.z;
    }
    public static int CompSum(this Vector3Int @this)
    => @this.x + @this.y + @this.z;
    public static int CompProduct(this Vector3Int @this)
    => @this.x * @this.y * @this.z;
    public static int CompMin(this Vector3Int @this)
    => Mathf.Min(@this.x, @this.y, @this.z);
    public static int CompMax(this Vector3Int @this)
    => Mathf.Max(@this.x, @this.y, @this.z);
    public static float CompAvg(this Vector3Int @this)
    => (@this.x + @this.y + @this.z) / 3f;
    public static bool Any(this Vector3Int @this, Func<int, bool> test)
    => test(@this.x) || test(@this.y) || test(@this.z);
    public static bool All(this Vector3Int @this, Func<int, bool> test)
    => test(@this.x) && test(@this.y) && test(@this.z);

    public static Vector3 CompDistanceTo(this Vector3Int @this, Vector3 a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y), @this.z.DistanceTo(a.z));
    public static Vector3 CompDistanceTo(this Vector3Int @this, float x, float y, float z)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y), @this.z.DistanceTo(z));
    public static Vector3 CompDistanceTo(this Vector3Int @this, float a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a), @this.z.DistanceTo(a));

    public static Vector3Int CompDistanceTo(this Vector3Int @this, Vector3Int a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y), @this.z.DistanceTo(a.z));
    public static Vector3Int CompDistanceTo(this Vector3Int @this, int x, int y, int z)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y), @this.z.DistanceTo(z));
    public static Vector3Int CompDistanceTo(this Vector3Int @this, int a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a), @this.z.DistanceTo(a));

    // Conversions
    public static Vector2 ToVector2(this Vector3Int @this)
    => new(@this.x, @this.y);
    public static Vector3 ToVector3(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z);
    public static Vector4 ToVector4(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z, 0);

    public static Vector4Int Append(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z, 0);
    public static Vector4Int Append(this Vector3Int @this, int w)
    => new(@this.x, @this.y, @this.z, w);
    // XYZW
    #region XYZW
    public static Vector3Int NewX(this Vector3Int @this, int x)
    => new(x, @this.y, @this.z);
    public static Vector3Int NewY(this Vector3Int @this, int y)
    => new(@this.x, y, @this.z);
    public static Vector3Int NewZ(this Vector3Int @this, int z)
    => new(@this.x, @this.y, z);

    public static Vector3Int NewXY(this Vector3Int @this, int x, int y)
    => new(x, y, @this.z);
    public static Vector3Int NewXZ(this Vector3Int @this, int x, int z)
    => new(x, @this.y, z);
    public static Vector3Int NewYX(this Vector3Int @this, int y, int x)
    => new(x, y, @this.z);
    public static Vector3Int NewYZ(this Vector3Int @this, int y, int z)
    => new(@this.x, y, z);
    public static Vector3Int NewZX(this Vector3Int @this, int z, int x)
    => new(x, @this.y, z);
    public static Vector3Int NewZY(this Vector3Int @this, int z, int y)
    => new(@this.x, y, z);

    public static Vector2Int XX(this Vector3Int @this)
    => new(@this.x, @this.x);
    public static Vector2Int XY(this Vector3Int @this)
    => new(@this.x, @this.y);
    public static Vector2Int XZ(this Vector3Int @this)
    => new(@this.x, @this.z);
    public static Vector2Int YX(this Vector3Int @this)
    => new(@this.y, @this.x);
    public static Vector2Int YY(this Vector3Int @this)
    => new(@this.y, @this.y);
    public static Vector2Int YZ(this Vector3Int @this)
    => new(@this.y, @this.z);
    public static Vector2Int ZX(this Vector3Int @this)
    => new(@this.z, @this.x);
    public static Vector2Int ZY(this Vector3Int @this)
    => new(@this.z, @this.y);
    public static Vector2Int ZZ(this Vector3Int @this)
    => new(@this.z, @this.z);

    public static Vector3Int XXX(this Vector3Int @this)
    => new(@this.x, @this.x, @this.x);
    public static Vector3Int XXY(this Vector3Int @this)
    => new(@this.x, @this.x, @this.y);
    public static Vector3Int XXZ(this Vector3Int @this)
    => new(@this.x, @this.x, @this.z);
    public static Vector3Int XYX(this Vector3Int @this)
    => new(@this.x, @this.y, @this.x);
    public static Vector3Int XYY(this Vector3Int @this)
    => new(@this.x, @this.y, @this.y);
    public static Vector3Int XYZ(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z);
    public static Vector3Int XZX(this Vector3Int @this)
    => new(@this.x, @this.z, @this.x);
    public static Vector3Int XZY(this Vector3Int @this)
    => new(@this.x, @this.z, @this.y);
    public static Vector3Int XZZ(this Vector3Int @this)
    => new(@this.x, @this.z, @this.z);

    public static Vector3Int YXX(this Vector3Int @this)
    => new(@this.y, @this.x, @this.x);
    public static Vector3Int YXY(this Vector3Int @this)
    => new(@this.y, @this.x, @this.y);
    public static Vector3Int YXZ(this Vector3Int @this)
    => new(@this.y, @this.x, @this.z);
    public static Vector3Int YYX(this Vector3Int @this)
    => new(@this.y, @this.y, @this.x);
    public static Vector3Int YYY(this Vector3Int @this)
    => new(@this.y, @this.y, @this.y);
    public static Vector3Int YYZ(this Vector3Int @this)
    => new(@this.y, @this.y, @this.z);
    public static Vector3Int YZX(this Vector3Int @this)
    => new(@this.y, @this.z, @this.x);
    public static Vector3Int YZY(this Vector3Int @this)
    => new(@this.y, @this.z, @this.y);
    public static Vector3Int YZZ(this Vector3Int @this)
    => new(@this.y, @this.z, @this.z);

    public static Vector3Int ZXX(this Vector3Int @this)
    => new(@this.z, @this.x, @this.x);
    public static Vector3Int ZXY(this Vector3Int @this)
    => new(@this.z, @this.x, @this.y);
    public static Vector3Int ZXZ(this Vector3Int @this)
    => new(@this.z, @this.x, @this.z);
    public static Vector3Int ZYX(this Vector3Int @this)
    => new(@this.z, @this.y, @this.x);
    public static Vector3Int ZYY(this Vector3Int @this)
    => new(@this.z, @this.y, @this.y);
    public static Vector3Int ZYZ(this Vector3Int @this)
    => new(@this.z, @this.y, @this.z);
    public static Vector3Int ZZX(this Vector3Int @this)
    => new(@this.z, @this.z, @this.x);
    public static Vector3Int ZZY(this Vector3Int @this)
    => new(@this.z, @this.z, @this.y);
    public static Vector3Int ZZZ(this Vector3Int @this)
    => new(@this.z, @this.z, @this.z);

    public static Vector4Int XXXX(this Vector3Int @this)
    => new(@this.x, @this.x, @this.x, @this.x);
    public static Vector4Int XXXY(this Vector3Int @this)
    => new(@this.x, @this.x, @this.x, @this.y);
    public static Vector4Int XXXZ(this Vector3Int @this)
    => new(@this.x, @this.x, @this.x, @this.z);
    public static Vector4Int XXYX(this Vector3Int @this)
    => new(@this.x, @this.x, @this.y, @this.x);
    public static Vector4Int XXYY(this Vector3Int @this)
    => new(@this.x, @this.x, @this.y, @this.y);
    public static Vector4Int XXYZ(this Vector3Int @this)
    => new(@this.x, @this.x, @this.y, @this.z);
    public static Vector4Int XXZX(this Vector3Int @this)
    => new(@this.x, @this.x, @this.z, @this.x);
    public static Vector4Int XXZY(this Vector3Int @this)
    => new(@this.x, @this.x, @this.z, @this.y);
    public static Vector4Int XXZZ(this Vector3Int @this)
    => new(@this.x, @this.x, @this.z, @this.z);

    public static Vector4Int XYXX(this Vector3Int @this)
    => new(@this.x, @this.y, @this.x, @this.x);
    public static Vector4Int XYXY(this Vector3Int @this)
    => new(@this.x, @this.y, @this.x, @this.y);
    public static Vector4Int XYXZ(this Vector3Int @this)
    => new(@this.x, @this.y, @this.x, @this.z);
    public static Vector4Int XYYX(this Vector3Int @this)
    => new(@this.x, @this.y, @this.y, @this.x);
    public static Vector4Int XYYY(this Vector3Int @this)
    => new(@this.x, @this.y, @this.y, @this.y);
    public static Vector4Int XYYZ(this Vector3Int @this)
    => new(@this.x, @this.y, @this.y, @this.z);
    public static Vector4Int XYZX(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z, @this.x);
    public static Vector4Int XYZY(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z, @this.y);
    public static Vector4Int XYZZ(this Vector3Int @this)
    => new(@this.x, @this.y, @this.z, @this.z);

    public static Vector4Int XZXX(this Vector3Int @this)
    => new(@this.x, @this.z, @this.x, @this.x);
    public static Vector4Int XZXY(this Vector3Int @this)
    => new(@this.x, @this.z, @this.x, @this.y);
    public static Vector4Int XZXZ(this Vector3Int @this)
    => new(@this.x, @this.z, @this.x, @this.z);
    public static Vector4Int XZYX(this Vector3Int @this)
    => new(@this.x, @this.z, @this.y, @this.x);
    public static Vector4Int XZYY(this Vector3Int @this)
    => new(@this.x, @this.z, @this.y, @this.y);
    public static Vector4Int XZYZ(this Vector3Int @this)
    => new(@this.x, @this.z, @this.y, @this.z);
    public static Vector4Int XZZX(this Vector3Int @this)
    => new(@this.x, @this.z, @this.z, @this.x);
    public static Vector4Int XZZY(this Vector3Int @this)
    => new(@this.x, @this.z, @this.z, @this.y);
    public static Vector4Int XZZZ(this Vector3Int @this)
    => new(@this.x, @this.z, @this.z, @this.z);

    public static Vector4Int YXXX(this Vector3Int @this)
    => new(@this.y, @this.x, @this.x, @this.x);
    public static Vector4Int YXXY(this Vector3Int @this)
    => new(@this.y, @this.x, @this.x, @this.y);
    public static Vector4Int YXXZ(this Vector3Int @this)
    => new(@this.y, @this.x, @this.x, @this.z);
    public static Vector4Int YXYX(this Vector3Int @this)
    => new(@this.y, @this.x, @this.y, @this.x);
    public static Vector4Int YXYY(this Vector3Int @this)
    => new(@this.y, @this.x, @this.y, @this.y);
    public static Vector4Int YXYZ(this Vector3Int @this)
    => new(@this.y, @this.x, @this.y, @this.z);
    public static Vector4Int YXZX(this Vector3Int @this)
    => new(@this.y, @this.x, @this.z, @this.x);
    public static Vector4Int YXZY(this Vector3Int @this)
    => new(@this.y, @this.x, @this.z, @this.y);
    public static Vector4Int YXZZ(this Vector3Int @this)
    => new(@this.y, @this.x, @this.z, @this.z);

    public static Vector4Int YYXX(this Vector3Int @this)
    => new(@this.y, @this.y, @this.x, @this.x);
    public static Vector4Int YYXY(this Vector3Int @this)
    => new(@this.y, @this.y, @this.x, @this.y);
    public static Vector4Int YYXZ(this Vector3Int @this)
    => new(@this.y, @this.y, @this.x, @this.z);
    public static Vector4Int YYYX(this Vector3Int @this)
    => new(@this.y, @this.y, @this.y, @this.x);
    public static Vector4Int YYYY(this Vector3Int @this)
    => new(@this.y, @this.y, @this.y, @this.y);
    public static Vector4Int YYYZ(this Vector3Int @this)
    => new(@this.y, @this.y, @this.y, @this.z);
    public static Vector4Int YYZX(this Vector3Int @this)
    => new(@this.y, @this.y, @this.z, @this.x);
    public static Vector4Int YYZY(this Vector3Int @this)
    => new(@this.y, @this.y, @this.z, @this.y);
    public static Vector4Int YYZZ(this Vector3Int @this)
    => new(@this.y, @this.y, @this.z, @this.z);

    public static Vector4Int YZXX(this Vector3Int @this)
    => new(@this.y, @this.z, @this.x, @this.x);
    public static Vector4Int YZXY(this Vector3Int @this)
    => new(@this.y, @this.z, @this.x, @this.y);
    public static Vector4Int YZXZ(this Vector3Int @this)
    => new(@this.y, @this.z, @this.x, @this.z);
    public static Vector4Int YZYX(this Vector3Int @this)
    => new(@this.y, @this.z, @this.y, @this.x);
    public static Vector4Int YZYY(this Vector3Int @this)
    => new(@this.y, @this.z, @this.y, @this.y);
    public static Vector4Int YZYZ(this Vector3Int @this)
    => new(@this.y, @this.z, @this.y, @this.z);
    public static Vector4Int YZZX(this Vector3Int @this)
    => new(@this.y, @this.z, @this.z, @this.x);
    public static Vector4Int YZZY(this Vector3Int @this)
    => new(@this.y, @this.z, @this.z, @this.y);
    public static Vector4Int YZZZ(this Vector3Int @this)
    => new(@this.y, @this.z, @this.z, @this.z);

    public static Vector4Int ZXXX(this Vector3Int @this)
    => new(@this.z, @this.x, @this.x, @this.x);
    public static Vector4Int ZXXY(this Vector3Int @this)
    => new(@this.z, @this.x, @this.x, @this.y);
    public static Vector4Int ZXXZ(this Vector3Int @this)
    => new(@this.z, @this.x, @this.x, @this.z);
    public static Vector4Int ZXYX(this Vector3Int @this)
    => new(@this.z, @this.x, @this.y, @this.x);
    public static Vector4Int ZXYY(this Vector3Int @this)
    => new(@this.z, @this.x, @this.y, @this.y);
    public static Vector4Int ZXYZ(this Vector3Int @this)
    => new(@this.z, @this.x, @this.y, @this.z);
    public static Vector4Int ZXZX(this Vector3Int @this)
    => new(@this.z, @this.x, @this.z, @this.x);
    public static Vector4Int ZXZY(this Vector3Int @this)
    => new(@this.z, @this.x, @this.z, @this.y);
    public static Vector4Int ZXZZ(this Vector3Int @this)
    => new(@this.z, @this.x, @this.z, @this.z);

    public static Vector4Int ZYXX(this Vector3Int @this)
    => new(@this.z, @this.y, @this.x, @this.x);
    public static Vector4Int ZYXY(this Vector3Int @this)
    => new(@this.z, @this.y, @this.x, @this.y);
    public static Vector4Int ZYXZ(this Vector3Int @this)
    => new(@this.z, @this.y, @this.x, @this.z);
    public static Vector4Int ZYYX(this Vector3Int @this)
    => new(@this.z, @this.y, @this.y, @this.x);
    public static Vector4Int ZYYY(this Vector3Int @this)
    => new(@this.z, @this.y, @this.y, @this.y);
    public static Vector4Int ZYYZ(this Vector3Int @this)
    => new(@this.z, @this.y, @this.y, @this.z);
    public static Vector4Int ZYZX(this Vector3Int @this)
    => new(@this.z, @this.y, @this.z, @this.x);
    public static Vector4Int ZYZY(this Vector3Int @this)
    => new(@this.z, @this.y, @this.z, @this.y);
    public static Vector4Int ZYZZ(this Vector3Int @this)
    => new(@this.z, @this.y, @this.z, @this.z);

    public static Vector4Int ZZXX(this Vector3Int @this)
    => new(@this.z, @this.z, @this.x, @this.x);
    public static Vector4Int ZZXY(this Vector3Int @this)
    => new(@this.z, @this.z, @this.x, @this.y);
    public static Vector4Int ZZXZ(this Vector3Int @this)
    => new(@this.z, @this.z, @this.x, @this.z);
    public static Vector4Int ZZYX(this Vector3Int @this)
    => new(@this.z, @this.z, @this.y, @this.x);
    public static Vector4Int ZZYY(this Vector3Int @this)
    => new(@this.z, @this.z, @this.y, @this.y);
    public static Vector4Int ZZYZ(this Vector3Int @this)
    => new(@this.z, @this.z, @this.y, @this.z);
    public static Vector4Int ZZZX(this Vector3Int @this)
    => new(@this.z, @this.z, @this.z, @this.x);
    public static Vector4Int ZZZY(this Vector3Int @this)
    => new(@this.z, @this.z, @this.z, @this.y);
    public static Vector4Int ZZZZ(this Vector3Int @this)
    => new(@this.z, @this.z, @this.z, @this.z);
    #endregion
}
#endif