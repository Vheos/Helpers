#if UNITY
namespace Vheos.Helpers.Math;

static public class Extensions_Vector3
{
    // Binary
    static public Vector3 Add(this Vector3 @this, Vector3 a)
    => new(@this.x.Add(a.x), @this.y.Add(a.y), @this.z.Add(a.z));
    static public Vector3 Sub(this Vector3 @this, Vector3 a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y), @this.z.Sub(a.z));
    static public Vector3 Mul(this Vector3 @this, Vector3 a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y), @this.z.Mul(a.z));
    static public Vector3 Div(this Vector3 @this, Vector3 a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y), @this.z.Div(a.z));
    static public Vector3 Pow(this Vector3 @this, Vector3 a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y), @this.z.Pow(a.z));
    static public Vector3 Root(this Vector3 @this, Vector3 a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y), @this.z.Root(a.z));
    static public Vector3 Mod(this Vector3 @this, Vector3 a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y), @this.z.Mod(a.z));
    static public Vector3 PosMod(this Vector3 @this, Vector3 a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y), @this.z.PosMod(a.z));
    static public Vector3 Min(this Vector3 @this, Vector3 a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y), @this.z.Min(a.z));
    static public Vector3 Max(this Vector3 @this, Vector3 a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y), @this.z.Max(a.z));
    static public Vector3 Avg(this Vector3 @this, Vector3 a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y), @this.z.Avg(a.z));

    static public Vector3 Add(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Add(x), @this.y.Add(y), @this.z.Add(z));
    static public Vector3 Sub(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Sub(x), @this.y.Sub(y), @this.z.Sub(z));
    static public Vector3 Mul(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Mul(x), @this.y.Mul(y), @this.z.Mul(z));
    static public Vector3 Div(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Div(x), @this.y.Div(y), @this.z.Div(z));
    static public Vector3 Pow(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Pow(x), @this.y.Pow(y), @this.z.Pow(z));
    static public Vector3 Root(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Root(x), @this.y.Root(y), @this.z.Root(z));
    static public Vector3 Mod(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Mod(x), @this.y.Mod(y), @this.z.Mod(z));
    static public Vector3 PosMod(this Vector3 @this, float x, float y, float z)
    => new(@this.x.PosMod(x), @this.y.PosMod(y), @this.z.PosMod(z));
    static public Vector3 Min(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Min(x), @this.y.Min(y), @this.z.Min(z));
    static public Vector3 Max(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Max(x), @this.y.Max(y), @this.z.Max(z));
    static public Vector3 Avg(this Vector3 @this, float x, float y, float z)
    => new(@this.x.Avg(x), @this.y.Avg(y), @this.z.Avg(z));

    static public Vector3 Add(this Vector3 @this, float a)
    => new(@this.x.Add(a), @this.y.Add(a), @this.z.Add(a));
    static public Vector3 Sub(this Vector3 @this, float a)
    => new(@this.x.Sub(a), @this.y.Sub(a), @this.z.Sub(a));
    static public Vector3 Mul(this Vector3 @this, float a)
    => new(@this.x.Mul(a), @this.y.Mul(a), @this.z.Mul(a));
    static public Vector3 Div(this Vector3 @this, float a)
    => new(@this.x.Div(a), @this.y.Div(a), @this.z.Div(a));
    static public Vector3 Pow(this Vector3 @this, float a)
    => new(@this.x.Pow(a), @this.y.Pow(a), @this.z.Pow(a));
    static public Vector3 Root(this Vector3 @this, float a)
    => new(@this.x.Root(a), @this.y.Root(a), @this.z.Root(a));
    static public Vector3 Mod(this Vector3 @this, float a)
    => new(@this.x.Mod(a), @this.y.Mod(a), @this.z.Mod(a));
    static public Vector3 PosMod(this Vector3 @this, float a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a), @this.z.PosMod(a));
    static public Vector3 Min(this Vector3 @this, float a)
    => new(@this.x.Min(a), @this.y.Min(a), @this.z.Min(a));
    static public Vector3 Max(this Vector3 @this, float a)
    => new(@this.x.Max(a), @this.y.Max(a), @this.z.Max(a));
    static public Vector3 Avg(this Vector3 @this, float a)
    => new(@this.x.Avg(a), @this.y.Avg(a), @this.z.Avg(a));

    static public Vector3 Add(this Vector3 @this, Vector3Int a)
    => new(@this.x.Add(a.x), @this.y.Add(a.y), @this.z.Add(a.z));
    static public Vector3 Sub(this Vector3 @this, Vector3Int a)
    => new(@this.x.Sub(a.x), @this.y.Sub(a.y), @this.z.Sub(a.z));
    static public Vector3 Mul(this Vector3 @this, Vector3Int a)
    => new(@this.x.Mul(a.x), @this.y.Mul(a.y), @this.z.Mul(a.z));
    static public Vector3 Div(this Vector3 @this, Vector3Int a)
    => new(@this.x.Div(a.x), @this.y.Div(a.y), @this.z.Div(a.z));
    static public Vector3 Pow(this Vector3 @this, Vector3Int a)
    => new(@this.x.Pow(a.x), @this.y.Pow(a.y), @this.z.Pow(a.z));
    static public Vector3 Root(this Vector3 @this, Vector3Int a)
    => new(@this.x.Root(a.x), @this.y.Root(a.y), @this.z.Root(a.z));
    static public Vector3 Mod(this Vector3 @this, Vector3Int a)
    => new(@this.x.Mod(a.x), @this.y.Mod(a.y), @this.z.Mod(a.z));
    static public Vector3 PosMod(this Vector3 @this, Vector3Int a)
    => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y), @this.z.PosMod(a.z));
    static public Vector3 Min(this Vector3 @this, Vector3Int a)
    => new(@this.x.Min(a.x), @this.y.Min(a.y), @this.z.Min(a.z));
    static public Vector3 Max(this Vector3 @this, Vector3Int a)
    => new(@this.x.Max(a.x), @this.y.Max(a.y), @this.z.Max(a.z));
    static public Vector3 Avg(this Vector3 @this, Vector3Int a)
    => new(@this.x.Avg(a.x), @this.y.Avg(a.y), @this.z.Avg(a.z));

    static public Vector3 Add(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Add(x), @this.y.Add(y), @this.z.Add(z));
    static public Vector3 Sub(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Sub(x), @this.y.Sub(y), @this.z.Sub(z));
    static public Vector3 Mul(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Mul(x), @this.y.Mul(y), @this.z.Mul(z));
    static public Vector3 Div(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Div(x), @this.y.Div(y), @this.z.Div(z));
    static public Vector3 Pow(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Pow(x), @this.y.Pow(y), @this.z.Pow(z));
    static public Vector3 Root(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Root(x), @this.y.Root(y), @this.z.Root(z));
    static public Vector3 Mod(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Mod(x), @this.y.Mod(y), @this.z.Mod(z));
    static public Vector3 PosMod(this Vector3 @this, int x, int y, int z)
    => new(@this.x.PosMod(x), @this.y.PosMod(y), @this.z.PosMod(z));
    static public Vector3 Min(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Min(x), @this.y.Min(y), @this.z.Min(z));
    static public Vector3 Max(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Max(x), @this.y.Max(y), @this.z.Max(z));
    static public Vector3 Avg(this Vector3 @this, int x, int y, int z)
    => new(@this.x.Avg(x), @this.y.Avg(y), @this.z.Avg(z));

    static public Vector3 Add(this Vector3 @this, int a)
    => new(@this.x.Add(a), @this.y.Add(a), @this.z.Add(a));
    static public Vector3 Sub(this Vector3 @this, int a)
    => new(@this.x.Sub(a), @this.y.Sub(a), @this.z.Sub(a));
    static public Vector3 Mul(this Vector3 @this, int a)
    => new(@this.x.Mul(a), @this.y.Mul(a), @this.z.Mul(a));
    static public Vector3 Div(this Vector3 @this, int a)
    => new(@this.x.Div(a), @this.y.Div(a), @this.z.Div(a));
    static public Vector3 Pow(this Vector3 @this, int a)
    => new(@this.x.Pow(a), @this.y.Pow(a), @this.z.Pow(a));
    static public Vector3 Root(this Vector3 @this, int a)
    => new(@this.x.Root(a), @this.y.Root(a), @this.z.Root(a));
    static public Vector3 Mod(this Vector3 @this, int a)
    => new(@this.x.Mod(a), @this.y.Mod(a), @this.z.Mod(a));
    static public Vector3 PosMod(this Vector3 @this, int a)
    => new(@this.x.PosMod(a), @this.y.PosMod(a), @this.z.PosMod(a));
    static public Vector3 Min(this Vector3 @this, int a)
    => new(@this.x.Min(a), @this.y.Min(a), @this.z.Min(a));
    static public Vector3 Max(this Vector3 @this, int a)
    => new(@this.x.Max(a), @this.y.Max(a), @this.z.Max(a));
    static public Vector3 Avg(this Vector3 @this, int a)
    => new(@this.x.Avg(a), @this.y.Avg(a), @this.z.Avg(a));

    // Unary
    static public Vector3 Neg(this Vector3 @this)
    => new(@this.x.Neg(), @this.y.Neg(), @this.z.Neg());
    static public Vector3 Inv(this Vector3 @this)
    => new(@this.x.Inv(), @this.y.Inv(), @this.z.Inv());
    static public Vector3 Abs(this Vector3 @this)
    => new(@this.x.Abs(), @this.y.Abs(), @this.z.Abs());
    static public Vector3Int Sig(this Vector3 @this)
    => new(@this.x.Sig(), @this.y.Sig(), @this.z.Sig());
    static public Vector3 Sqrd(this Vector3 @this)
    => new(@this.x.Sqrd(), @this.y.Sqrd(), @this.z.Sqrd());
    static public Vector3 Sqrt(this Vector3 @this)
    => new(@this.x.Sqrt(), @this.y.Sqrt(), @this.z.Sqrt());

    // Trig
    static public Vector3 Sin(this Vector3 @this, bool degrees = false)
    => new(@this.x.Sin(degrees), @this.y.Sin(degrees), @this.z.Sin(degrees));
    static public Vector3 Cos(this Vector3 @this, bool degrees = false)
    => new(@this.x.Cos(degrees), @this.y.Cos(degrees), @this.z.Cos(degrees));
    static public Vector3 Tan(this Vector3 @this, bool degrees = false)
    => new(@this.x.Tan(degrees), @this.y.Tan(degrees), @this.z.Tan(degrees));
    static public Vector3 Cot(this Vector3 @this, bool degrees = false)
    => new(@this.x.Cot(degrees), @this.y.Cot(degrees), @this.z.Cot(degrees));
    static public Vector3 Sec(this Vector3 @this, bool degrees = false)
    => new(@this.x.Sec(degrees), @this.y.Sec(degrees), @this.z.Sec(degrees));
    static public Vector3 Csc(this Vector3 @this, bool degrees = false)
    => new(@this.x.Csc(degrees), @this.y.Csc(degrees), @this.z.Csc(degrees));
    static public Vector3 ArcSin(this Vector3 @this, bool degrees = false)
    => new(@this.x.ArcSin(degrees), @this.y.ArcSin(degrees), @this.z.ArcSin(degrees));
    static public Vector3 ArcCos(this Vector3 @this, bool degrees = false)
    => new(@this.x.ArcCos(degrees), @this.y.ArcCos(degrees), @this.z.ArcCos(degrees));
    static public Vector3 ArcTan(this Vector3 @this, bool degrees = false)
    => new(@this.x.ArcTan(degrees), @this.y.ArcTan(degrees), @this.z.ArcTan(degrees));

    // Round
    static public Vector3Int Round(this Vector3 @this)
    => new(@this.x.Round(), @this.y.Round(), @this.z.Round());
    static public Vector3Int RoundDown(this Vector3 @this)
    => new(@this.x.RoundDown(), @this.y.RoundDown(), @this.z.RoundDown());
    static public Vector3Int RoundUp(this Vector3 @this)
    => new(@this.x.RoundUp(), @this.y.RoundUp(), @this.z.RoundUp());
    static public Vector3Int RoundTowardsZero(this Vector3 @this)
    => new(@this.x.RoundTowardsZero(), @this.y.RoundTowardsZero(), @this.z.RoundTowardsZero());
    static public Vector3Int RoundAwayFromZero(this Vector3 @this)
    => new(@this.x.RoundAwayFromZero(), @this.y.RoundAwayFromZero(), @this.z.RoundAwayFromZero());
    static public Vector3 RoundToDecimalDigits(this Vector3 @this, int a)
    => new(@this.x.RoundToDecimalDigits(a), @this.y.RoundToDecimalDigits(a), @this.z.RoundToDecimalDigits(a));

    static public Vector3 RoundToMultiple(this Vector3 @this, Vector3 a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y), @this.z.RoundToMultiple(a.z));
    static public Vector3 RoundToMultiple(this Vector3 @this, float x, float y, float z)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y), @this.z.RoundToMultiple(z));
    static public Vector3 RoundToMultiple(this Vector3 @this, float a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a), @this.z.RoundToMultiple(a));

    static public Vector3Int RoundToMultiple(this Vector3 @this, Vector3Int a)
    => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y), @this.z.RoundToMultiple(a.z));
    static public Vector3Int RoundToMultiple(this Vector3 @this, int x, int y, int z)
    => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y), @this.z.RoundToMultiple(z));
    static public Vector3Int RoundToMultiple(this Vector3 @this, int a)
    => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a), @this.z.RoundToMultiple(a));

    // Clamp
    static public Vector3 Clamp01(this Vector3 @this)
    => new(@this.x.Clamp01(), @this.y.Clamp01(), @this.z.Clamp01());

    static public Vector3 Clamp(this Vector3 @this, Vector3 a, Vector3 b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y), @this.z.Clamp(a.z, b.z));
    static public Vector3 ClampMin(this Vector3 @this, Vector3 a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y), @this.z.ClampMin(a.z));
    static public Vector3 ClampMax(this Vector3 @this, Vector3 a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y), @this.z.ClampMax(a.z));
    static public Vector3 Lerp(this Vector3 @this, Vector3 a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b), @this.z.Lerp(a.z, b));
    static public Vector3 LerpClamped(this Vector3 @this, Vector3 a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b), @this.z.LerpClamped(a.z, b));
    static public Vector3 Map(this Vector3 @this, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y), @this.z.Map(a.z, b.z, c.z, d.z));
    static public Vector3 MapClamped(this Vector3 @this, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y), @this.z.MapClamped(a.z, b.z, c.z, d.z));
    static public Vector3 MapFrom01(this Vector3 @this, Vector3 a, Vector3 b)
    => new(@this.x.MapFrom01(a.x, b.x), @this.y.MapFrom01(a.y, b.y), @this.z.MapFrom01(a.z, b.z));
    static public Vector3 MapTo01(this Vector3 @this, Vector3 a, Vector3 b)
    => new(@this.x.MapTo01(a.x, b.x), @this.y.MapTo01(a.y, b.y), @this.z.MapTo01(a.z, b.z));

    static public Vector3 Clamp(this Vector3 @this, float ax, float ay, float az, float bx, float by, float bz)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by), @this.z.Clamp(az, bz));
    static public Vector3 ClampMin(this Vector3 @this, float x, float y, float z)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y), @this.z.ClampMin(z));
    static public Vector3 ClampMax(this Vector3 @this, float x, float y, float z)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y), @this.z.ClampMax(z));
    static public Vector3 Lerp(this Vector3 @this, float x, float y, float z, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b), @this.z.Lerp(z, b));
    static public Vector3 LerpClamped(this Vector3 @this, float x, float y, float z, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b), @this.z.LerpClamped(z, b));
    static public Vector3 Map(this Vector3 @this, float ax, float ay, float az, float bx, float by, float bz, float cx, float cy, float cz, float dx, float dy, float dz)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy), @this.z.Map(az, bz, cz, dz));
    static public Vector3 MapClamped(this Vector3 @this, float ax, float ay, float az, float bx, float by, float bz, float cx, float cy, float cz, float dx, float dy, float dz)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy), @this.z.MapClamped(az, bz, cz, dz));
    static public Vector3 MapFrom01(this Vector3 @this, float ax, float ay, float az, float bx, float by, float bz)
    => new(@this.x.MapFrom01(ax, bx), @this.y.MapFrom01(ay, by), @this.z.MapFrom01(az, bz));
    static public Vector3 MapTo01(this Vector3 @this, float ax, float ay, float az, float bx, float by, float bz)
    => new(@this.x.MapTo01(ax, bx), @this.y.MapTo01(ay, by), @this.z.MapTo01(az, bz));

    static public Vector3 Clamp(this Vector3 @this, float a, float b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b), @this.z.Clamp(a, b));
    static public Vector3 ClampMin(this Vector3 @this, float a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a), @this.z.ClampMin(a));
    static public Vector3 ClampMax(this Vector3 @this, float a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a), @this.z.ClampMax(a));
    static public Vector3 Lerp(this Vector3 @this, float a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b), @this.z.Lerp(a, b));
    static public Vector3 LerpClamped(this Vector3 @this, float a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b), @this.z.LerpClamped(a, b));
    static public Vector3 Map(this Vector3 @this, float a, float b, float c, float d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d), @this.z.Map(a, b, c, d));
    static public Vector3 MapClamped(this Vector3 @this, float a, float b, float c, float d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d), @this.z.MapClamped(a, b, c, d));
    static public Vector3 MapFrom01(this Vector3 @this, float a, float b)
    => new(@this.x.MapFrom01(a, b), @this.y.MapFrom01(a, b), @this.z.MapFrom01(a, b));
    static public Vector3 MapTo01(this Vector3 @this, float a, float b)
    => new(@this.x.MapTo01(a, b), @this.y.MapTo01(a, b), @this.z.MapTo01(a, b));

    static public Vector3 Clamp(this Vector3 @this, Vector3Int a, Vector3Int b)
    => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y), @this.z.Clamp(a.z, b.z));
    static public Vector3 ClampMin(this Vector3 @this, Vector3Int a)
    => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y), @this.z.ClampMin(a.z));
    static public Vector3 ClampMax(this Vector3 @this, Vector3Int a)
    => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y), @this.z.ClampMax(a.z));
    static public Vector3 Lerp(this Vector3 @this, Vector3Int a, float b)
    => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b), @this.z.Lerp(a.z, b));
    static public Vector3 LerpClamped(this Vector3 @this, Vector3Int a, float b)
    => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b), @this.z.LerpClamped(a.z, b));
    static public Vector3 Map(this Vector3 @this, Vector3Int a, Vector3Int b, Vector3Int c, Vector3Int d)
    => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y), @this.z.Map(a.z, b.z, c.z, d.z));
    static public Vector3 MapClamped(this Vector3 @this, Vector3Int a, Vector3Int b, Vector3Int c, Vector3Int d)
    => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y), @this.z.MapClamped(a.z, b.z, c.z, d.z));
    static public Vector3 MapFrom01(this Vector3 @this, Vector3Int a, Vector3Int b)
    => new(@this.x.MapFrom01(a.x, b.x), @this.y.MapFrom01(a.y, b.y), @this.z.MapFrom01(a.z, b.z));
    static public Vector3 MapTo01(this Vector3 @this, Vector3Int a, Vector3Int b)
    => new(@this.x.MapTo01(a.x, b.x), @this.y.MapTo01(a.y, b.y), @this.z.MapTo01(a.z, b.z));

    static public Vector3 Clamp(this Vector3 @this, int ax, int ay, int az, int bx, int by, int bz)
    => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by), @this.z.Clamp(az, bz));
    static public Vector3 ClampMin(this Vector3 @this, int x, int y, int z)
    => new(@this.x.ClampMin(x), @this.y.ClampMin(y), @this.z.ClampMin(z));
    static public Vector3 ClampMax(this Vector3 @this, int x, int y, int z)
    => new(@this.x.ClampMax(x), @this.y.ClampMax(y), @this.z.ClampMax(z));
    static public Vector3 Lerp(this Vector3 @this, int x, int y, int z, float b)
    => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b), @this.z.Lerp(z, b));
    static public Vector3 LerpClamped(this Vector3 @this, int x, int y, int z, float b)
    => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b), @this.z.LerpClamped(z, b));
    static public Vector3 Map(this Vector3 @this, int ax, int ay, int az, int bx, int by, int bz, int cx, int cy, int cz, int dx, int dy, int dz)
    => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy), @this.z.Map(az, bz, cz, dz));
    static public Vector3 MapClamped(this Vector3 @this, int ax, int ay, int az, int bx, int by, int bz, int cx, int cy, int cz, int dx, int dy, int dz)
    => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy), @this.z.MapClamped(az, bz, cz, dz));
    static public Vector3 MapFrom01(this Vector3 @this, int ax, int ay, int az, int bx, int by, int bz)
    => new(@this.x.MapFrom01(ax, bx), @this.y.MapFrom01(ay, by), @this.z.MapFrom01(az, bz));
    static public Vector3 MapTo01(this Vector3 @this, int ax, int ay, int az, int bx, int by, int bz)
    => new(@this.x.MapTo01(ax, bx), @this.y.MapTo01(ay, by), @this.z.MapTo01(az, bz));

    static public Vector3 Clamp(this Vector3 @this, int a, int b)
    => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b), @this.z.Clamp(a, b));
    static public Vector3 ClampMin(this Vector3 @this, int a)
    => new(@this.x.ClampMin(a), @this.y.ClampMin(a), @this.z.ClampMin(a));
    static public Vector3 ClampMax(this Vector3 @this, int a)
    => new(@this.x.ClampMax(a), @this.y.ClampMax(a), @this.z.ClampMax(a));
    static public Vector3 Lerp(this Vector3 @this, int a, float b)
    => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b), @this.z.Lerp(a, b));
    static public Vector3 LerpClamped(this Vector3 @this, int a, float b)
    => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b), @this.z.LerpClamped(a, b));
    static public Vector3 Map(this Vector3 @this, int a, int b, int c, int d)
    => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d), @this.z.Map(a, b, c, d));
    static public Vector3 MapClamped(this Vector3 @this, int a, int b, int c, int d)
     => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d), @this.z.MapClamped(a, b, c, d));
    static public Vector3 MapFrom01(this Vector3 @this, int a, int b)
    => new(@this.x.MapFrom01(a, b), @this.y.MapFrom01(a, b), @this.z.MapFrom01(a, b));
    static public Vector3 MapTo01(this Vector3 @this, int a, int b)
    => new(@this.x.MapTo01(a, b), @this.y.MapTo01(a, b), @this.z.MapTo01(a, b));

    // Rotate
    static public Vector3 Rotate(this Vector3 @this, Quaternion a)
    => a * @this;
    static public Vector3 Unrotate(this Vector3 @this, Quaternion a)
    => a.Neg() * @this;

    static public Quaternion RotationTo(this Vector3 @this, Vector3 a)
    => Quaternion.FromToRotation(@this, a);
    static public Quaternion RotationFrom(this Vector3 @this, Vector3 a)
    => Quaternion.FromToRotation(a, @this);

    static public Quaternion RotationTo(this Vector3 @this, float x, float y, float z)
    => Quaternion.FromToRotation(@this, new(x, y, z));
    static public Quaternion RotationFrom(this Vector3 @this, float x, float y, float z)
    => Quaternion.FromToRotation(new(x, y, z), @this);

    static public Quaternion RotationTo(this Vector3 @this, Vector3Int a)
    => Quaternion.FromToRotation(@this, a);
    static public Quaternion RotationFrom(this Vector3 @this, Vector3Int a)
    => Quaternion.FromToRotation(a, @this);

    static public Quaternion RotationTo(this Vector3 @this, int x, int y, int z)
    => Quaternion.FromToRotation(@this, new(x, y, z));
    static public Quaternion RotationFrom(this Vector3 @this, int x, int y, int z)
    => Quaternion.FromToRotation(new(x, y, z), @this);

    // Spatial
    static public float Dot(this Vector3 @this, Vector3 a)
    => @this.x * a.x + @this.y * a.y + @this.z * a.z;
    static public float DistanceTo(this Vector3 @this, Vector3 a)
    => (a - @this).magnitude;
    static public Vector3 OffsetTo(this Vector3 @this, Vector3 a)
    => a - @this;
    static public Vector3 OffsetFrom(this Vector3 @this, Vector3 a)
    => @this - a;
    static public Vector3 DirectionTowards(this Vector3 @this, Vector3 a)
    => (a - @this).normalized;
    static public Vector3 DirectionAwayFrom(this Vector3 @this, Vector3 a)
    => (@this - a).normalized;

    static public float Dot(this Vector3 @this, float x, float y, float z)
    => @this.x * x + @this.y * y + @this.z * z;
    static public float DistanceTo(this Vector3 @this, float x, float y, float z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).magnitude;
    static public Vector3 OffsetTo(this Vector3 @this, float x, float y, float z)
    => new(x - @this.x, y - @this.y, z - @this.z);
    static public Vector3 OffsetFrom(this Vector3 @this, float x, float y, float z)
    => new(@this.x - x, @this.y - y, @this.z - z);
    static public Vector3 DirectionTowards(this Vector3 @this, float x, float y, float z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).normalized;
    static public Vector3 DirectionAwayFrom(this Vector3 @this, float x, float y, float z)
    => new Vector3(@this.x - x, @this.y - y, @this.z - z).normalized;

    static public float Dot(this Vector3 @this, Vector3Int a)
    => @this.x * a.x + @this.y * a.y + @this.z * a.z;
    static public float DistanceTo(this Vector3 @this, Vector3Int a)
    => (a - @this).magnitude;
    static public Vector3 OffsetTo(this Vector3 @this, Vector3Int a)
    => a - @this;
    static public Vector3 OffsetFrom(this Vector3 @this, Vector3Int a)
    => @this - a;
    static public Vector3 DirectionTowards(this Vector3 @this, Vector3Int a)
    => (a - @this).normalized;
    static public Vector3 DirectionAwayFrom(this Vector3 @this, Vector3Int a)
    => (@this - a).normalized;

    static public float Dot(this Vector3 @this, int x, int y, int z)
    => @this.x * x + @this.y * y + @this.z * z;
    static public float DistanceTo(this Vector3 @this, int x, int y, int z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).magnitude;
    static public Vector3 OffsetTo(this Vector3 @this, int x, int y, int z)
    => new(x - @this.x, y - @this.y, z - @this.z);
    static public Vector3 OffsetFrom(this Vector3 @this, int x, int y, int z)
    => new(@this.x - x, @this.y - y, @this.z - z);
    static public Vector3 DirectionTowards(this Vector3 @this, int x, int y, int z)
    => new Vector3(x - @this.x, y - @this.y, z - @this.z).normalized;
    static public Vector3 DirectionAwayFrom(this Vector3 @this, int x, int y, int z)
    => new Vector3(@this.x - x, @this.y - y, @this.z - z).normalized;

    static public float Dot(this Vector3 @this, GameObject a)
    {
        Vector3 apos = a.transform.position;
        return @this.x * apos.x + @this.y * apos.y + @this.z * apos.z;
    }
    static public float DistanceTo(this Vector3 @this, GameObject a)
    => (a.transform.position - @this).magnitude;
    static public Vector3 OffsetTo(this Vector3 @this, GameObject a)
    => a.transform.position - @this;
    static public Vector3 OffsetFrom(this Vector3 @this, GameObject a)
    => @this - a.transform.position;
    static public Vector3 DirectionTowards(this Vector3 @this, GameObject a)
    => (a.transform.position - @this).normalized;
    static public Vector3 DirectionAwayFrom(this Vector3 @this, GameObject a)
    => (@this - a.transform.position).normalized;

    static public float Dot(this Vector3 @this, Component a)
    {
        Vector3 apos = a.transform.position;
        return @this.x * apos.x + @this.y * apos.y + @this.z * apos.z;
    }
    static public float DistanceTo(this Vector3 @this, Component a)
    => (a.transform.position - @this).magnitude;
    static public Vector3 OffsetTo(this Vector3 @this, Component a)
    => a.transform.position - @this;
    static public Vector3 OffsetFrom(this Vector3 @this, Component a)
    => @this - a.transform.position;
    static public Vector3 DirectionTowards(this Vector3 @this, Component a)
    => (a.transform.position - @this).normalized;
    static public Vector3 DirectionAwayFrom(this Vector3 @this, Component a)
    => (@this - a.transform.position).normalized;

    // 3D uniques
    static public Vector3 Cross(this Vector3 @this, Vector3 a)
    => new(@this.y * a.z - @this.z * a.y, @this.z * a.x - @this.x * a.z, @this.x * a.y - @this.y * a.x);
    static public Ray RayTowards(this Vector3 @this, Vector3 a)
    => new(@this, @this.DirectionTowards(a));
    static public Ray RayAwayFrom(this Vector3 @this, Vector3 a)
    => new(@this, @this.DirectionAwayFrom(a));

    static public Vector3 Cross(this Vector3 @this, float x, float y, float z)
    => new(@this.y * z - @this.z * y, @this.z * x - @this.x * z, @this.x * y - @this.y * x);
    static public Ray RayTowards(this Vector3 @this, float x, float y, float z)
    => new(@this, @this.DirectionTowards(x, y, z));
    static public Ray RayAwayFrom(this Vector3 @this, float x, float y, float z)
    => new(@this, @this.DirectionAwayFrom(x, y, z));

    static public Vector3 Cross(this Vector3 @this, Vector3Int a)
    => new(@this.y * a.z - @this.z * a.y, @this.z * a.x - @this.x * a.z, @this.x * a.y - @this.y * a.x);
    static public Ray RayTowards(this Vector3 @this, Vector3Int a)
    => new(@this, @this.DirectionTowards(a));
    static public Ray RayAwayFrom(this Vector3 @this, Vector3Int a)
    => new(@this, @this.DirectionAwayFrom(a));

    static public Vector3 Cross(this Vector3 @this, int x, int y, int z)
    => new(@this.y * z - @this.z * y, @this.z * x - @this.x * z, @this.x * y - @this.y * x);
    static public Ray RayTowards(this Vector3 @this, int x, int y, int z)
    => new(@this, @this.DirectionTowards(x, y, z));
    static public Ray RayAwayFrom(this Vector3 @this, int x, int y, int z)
    => new(@this, @this.DirectionAwayFrom(x, y, z));

    static public Vector3 Cross(this Vector3 @this, GameObject a)
    {
        Vector3 apos = a.transform.position;
        return new(@this.y * apos.z - @this.z * apos.y, @this.z * apos.x - @this.x * apos.z, @this.x * apos.y - @this.y * apos.x);
    }
    static public Ray RayTowards(this Vector3 @this, GameObject a)
    => new(@this, @this.DirectionTowards(a));
    static public Ray RayAwayFrom(this Vector3 @this, GameObject a)
    => new(@this, @this.DirectionAwayFrom(a));

    static public Vector3 Cross(this Vector3 @this, Component a)
    {
        Vector3 apos = a.transform.position;
        return new(@this.y * apos.z - @this.z * apos.y, @this.z * apos.x - @this.x * apos.z, @this.x * apos.y - @this.y * apos.x);
    }
    static public Ray RayTowards(this Vector3 @this, Component a)
    => new(@this, @this.DirectionTowards(a));
    static public Ray RayAwayFrom(this Vector3 @this, Component a)
    => new(@this, @this.DirectionAwayFrom(a));

    // Spatial (screen)
    static public float ScreenDistanceTo(this Vector3 @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().magnitude;
    static public Vector2 ScreenOffsetTo(this Vector3 @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY();
    static public Vector2 ScreenOffsetFrom(this Vector3 @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY();
    static public Vector2 ScreenDirectionTowards(this Vector3 @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().normalized;
    static public Vector2 ScreenDirectionAwayFrom(this Vector3 @this, Vector3 a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY().normalized;

    static public float ScreenDistanceTo(this Vector3 @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().magnitude;
    static public Vector2 ScreenOffsetTo(this Vector3 @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY();
    static public Vector2 ScreenOffsetFrom(this Vector3 @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY();
    static public Vector2 ScreenDirectionTowards(this Vector3 @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().normalized;
    static public Vector2 ScreenDirectionAwayFrom(this Vector3 @this, float x, float y, float z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY().normalized;

    static public float ScreenDistanceTo(this Vector3 @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().magnitude;
    static public Vector2 ScreenOffsetTo(this Vector3 @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY();
    static public Vector2 ScreenOffsetFrom(this Vector3 @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY();
    static public Vector2 ScreenDirectionTowards(this Vector3 @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(a) - b.WorldToScreenPoint(@this)).XY().normalized;
    static public Vector2 ScreenDirectionAwayFrom(this Vector3 @this, Vector3Int a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a)).XY().normalized;

    static public float ScreenDistanceTo(this Vector3 @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().magnitude;
    static public Vector2 ScreenOffsetTo(this Vector3 @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY();
    static public Vector2 ScreenOffsetFrom(this Vector3 @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY();
    static public Vector2 ScreenDirectionTowards(this Vector3 @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(new(x, y, z)) - b.WorldToScreenPoint(@this)).XY().normalized;
    static public Vector2 ScreenDirectionAwayFrom(this Vector3 @this, int x, int y, int z, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(new(x, y, z))).XY().normalized;

    static public float ScreenDistanceTo(this Vector3 @this, GameObject a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).XY().magnitude;
    static public Vector2 ScreenOffsetTo(this Vector3 @this, GameObject a, Camera b)
    => b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this);
    static public Vector2 ScreenOffsetFrom(this Vector3 @this, GameObject a, Camera b)
    => b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position);
    static public Vector2 ScreenDirectionTowards(this Vector3 @this, GameObject a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).normalized;
    static public Vector2 ScreenDirectionAwayFrom(this Vector3 @this, GameObject a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position)).normalized;

    static public float ScreenDistanceTo(this Vector3 @this, Component a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).XY().magnitude;
    static public Vector2 ScreenOffsetTo(this Vector3 @this, Component a, Camera b)
    => b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this);
    static public Vector2 ScreenOffsetFrom(this Vector3 @this, Component a, Camera b)
    => b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position);
    static public Vector2 ScreenDirectionTowards(this Vector3 @this, Component a, Camera b)
    => (b.WorldToScreenPoint(a.transform.position) - b.WorldToScreenPoint(@this)).normalized;
    static public Vector2 ScreenDirectionAwayFrom(this Vector3 @this, Component a, Camera b)
    => (b.WorldToScreenPoint(@this) - b.WorldToScreenPoint(a.transform.position)).normalized;

    // Transform
    static public Vector3 Transform(this Vector3 @this, Transform a)
    => a.TransformPoint(@this);
    static public Vector3 Untransform(this Vector3 @this, Transform a)
    => a.InverseTransformPoint(@this);
    static public Vector3 TransformNoScale(this Vector3 @this, Transform a)
    => a.TransformPoint(@this.Div(a.localScale));
    static public Vector3 UntransformNoScale(this Vector3 @this, Transform a)
    => a.InverseTransformPoint(@this).Mul(a.localScale);
    static public Vector3 TransformDirection(this Vector3 @this, Transform a)
    => a.TransformDirection(@this);
    static public Vector3 UntransformDirection(this Vector3 @this, Transform a)
    => a.InverseTransformDirection(@this);

    // Comps
    static public IEnumerable<float> Comps(this Vector3 @this)
    {
        yield return @this.x;
        yield return @this.y;
        yield return @this.z;
    }
    static public float CompSum(this Vector3 @this)
    => @this.x + @this.y + @this.z;
    static public float CompProduct(this Vector3 @this)
    => @this.x * @this.y * @this.z;
    static public float CompMin(this Vector3 @this)
    => Mathf.Min(@this.x, @this.y, @this.z);
    static public float CompMax(this Vector3 @this)
    => Mathf.Max(@this.x, @this.y, @this.z);
    static public float CompAvg(this Vector3 @this)
    => (@this.x + @this.y + @this.z) / 3f;
    static public bool Any(this Vector3 @this, Func<float, bool> test)
    => test(@this.x) || test(@this.y) || test(@this.z);
    static public bool All(this Vector3 @this, Func<float, bool> test)
    => test(@this.x) && test(@this.y) && test(@this.z);

    static public Vector3 CompDistanceTo(this Vector3 @this, Vector3 a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y), @this.z.DistanceTo(a.z));
    static public Vector3 CompDistanceTo(this Vector3 @this, float x, float y, float z)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y), @this.z.DistanceTo(z));
    static public Vector3 CompDistanceTo(this Vector3 @this, float a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a), @this.z.DistanceTo(a));

    static public Vector3 CompDistanceTo(this Vector3 @this, Vector3Int a)
    => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y), @this.z.DistanceTo(a.z));
    static public Vector3 CompDistanceTo(this Vector3 @this, int x, int y, int z)
    => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y), @this.z.DistanceTo(z));
    static public Vector3 CompDistanceTo(this Vector3 @this, int a)
    => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a), @this.z.DistanceTo(a));

    // Conversions
    static public Vector2Int ToVector2Int(this Vector3 @this)
    => new((int)@this.x, (int)@this.y);
    static public Vector3Int ToVector3Int(this Vector3 @this)
    => new((int)@this.x, (int)@this.y, (int)@this.z);
    static public Vector4Int ToVector4Int(this Vector3 @this)
    => new((int)@this.x, (int)@this.y, (int)@this.z, 0);

    static public Vector4 Append(this Vector3 @this)
    => new(@this.x, @this.y, @this.z, 0f);
    static public Vector4 Append(this Vector3 @this, float w)
    => new(@this.x, @this.y, @this.z, w);

    // XYZW
    #region XYZW
    static public Vector3 NewX(this Vector3 @this, float x)
    => new(x, @this.y, @this.z);
    static public Vector3 NewY(this Vector3 @this, float y)
    => new(@this.x, y, @this.z);
    static public Vector3 NewZ(this Vector3 @this, float z)
    => new(@this.x, @this.y, z);

    static public Vector3 NewXY(this Vector3 @this, float x, float y)
    => new(x, y, @this.z);
    static public Vector3 NewXZ(this Vector3 @this, float x, float z)
    => new(x, @this.y, z);
    static public Vector3 NewYX(this Vector3 @this, float y, float x)
    => new(x, y, @this.z);
    static public Vector3 NewYZ(this Vector3 @this, float y, float z)
    => new(@this.x, y, z);
    static public Vector3 NewZX(this Vector3 @this, float z, float x)
    => new(x, @this.y, z);
    static public Vector3 NewZY(this Vector3 @this, float z, float y)
    => new(@this.x, y, z);

    static public Vector2 XX(this Vector3 @this)
    => new(@this.x, @this.x);
    static public Vector2 XY(this Vector3 @this)
    => new(@this.x, @this.y);
    static public Vector2 XZ(this Vector3 @this)
    => new(@this.x, @this.z);
    static public Vector2 YX(this Vector3 @this)
    => new(@this.y, @this.x);
    static public Vector2 YY(this Vector3 @this)
    => new(@this.y, @this.y);
    static public Vector2 YZ(this Vector3 @this)
    => new(@this.y, @this.z);
    static public Vector2 ZX(this Vector3 @this)
    => new(@this.z, @this.x);
    static public Vector2 ZY(this Vector3 @this)
    => new(@this.z, @this.y);
    static public Vector2 ZZ(this Vector3 @this)
    => new(@this.z, @this.z);

    static public Vector3 XXX(this Vector3 @this)
    => new(@this.x, @this.x, @this.x);
    static public Vector3 XXY(this Vector3 @this)
    => new(@this.x, @this.x, @this.y);
    static public Vector3 XXZ(this Vector3 @this)
    => new(@this.x, @this.x, @this.z);
    static public Vector3 XYX(this Vector3 @this)
    => new(@this.x, @this.y, @this.x);
    static public Vector3 XYY(this Vector3 @this)
    => new(@this.x, @this.y, @this.y);
    static public Vector3 XYZ(this Vector3 @this)
    => new(@this.x, @this.y, @this.z);
    static public Vector3 XZX(this Vector3 @this)
    => new(@this.x, @this.z, @this.x);
    static public Vector3 XZY(this Vector3 @this)
    => new(@this.x, @this.z, @this.y);
    static public Vector3 XZZ(this Vector3 @this)
    => new(@this.x, @this.z, @this.z);

    static public Vector3 YXX(this Vector3 @this)
    => new(@this.y, @this.x, @this.x);
    static public Vector3 YXY(this Vector3 @this)
    => new(@this.y, @this.x, @this.y);
    static public Vector3 YXZ(this Vector3 @this)
    => new(@this.y, @this.x, @this.z);
    static public Vector3 YYX(this Vector3 @this)
    => new(@this.y, @this.y, @this.x);
    static public Vector3 YYY(this Vector3 @this)
    => new(@this.y, @this.y, @this.y);
    static public Vector3 YYZ(this Vector3 @this)
    => new(@this.y, @this.y, @this.z);
    static public Vector3 YZX(this Vector3 @this)
    => new(@this.y, @this.z, @this.x);
    static public Vector3 YZY(this Vector3 @this)
    => new(@this.y, @this.z, @this.y);
    static public Vector3 YZZ(this Vector3 @this)
    => new(@this.y, @this.z, @this.z);

    static public Vector3 ZXX(this Vector3 @this)
    => new(@this.z, @this.x, @this.x);
    static public Vector3 ZXY(this Vector3 @this)
    => new(@this.z, @this.x, @this.y);
    static public Vector3 ZXZ(this Vector3 @this)
    => new(@this.z, @this.x, @this.z);
    static public Vector3 ZYX(this Vector3 @this)
    => new(@this.z, @this.y, @this.x);
    static public Vector3 ZYY(this Vector3 @this)
    => new(@this.z, @this.y, @this.y);
    static public Vector3 ZYZ(this Vector3 @this)
    => new(@this.z, @this.y, @this.z);
    static public Vector3 ZZX(this Vector3 @this)
    => new(@this.z, @this.z, @this.x);
    static public Vector3 ZZY(this Vector3 @this)
    => new(@this.z, @this.z, @this.y);
    static public Vector3 ZZZ(this Vector3 @this)
    => new(@this.z, @this.z, @this.z);

    static public Vector4 XXXX(this Vector3 @this)
    => new(@this.x, @this.x, @this.x, @this.x);
    static public Vector4 XXXY(this Vector3 @this)
    => new(@this.x, @this.x, @this.x, @this.y);
    static public Vector4 XXXZ(this Vector3 @this)
    => new(@this.x, @this.x, @this.x, @this.z);
    static public Vector4 XXYX(this Vector3 @this)
    => new(@this.x, @this.x, @this.y, @this.x);
    static public Vector4 XXYY(this Vector3 @this)
    => new(@this.x, @this.x, @this.y, @this.y);
    static public Vector4 XXYZ(this Vector3 @this)
    => new(@this.x, @this.x, @this.y, @this.z);
    static public Vector4 XXZX(this Vector3 @this)
    => new(@this.x, @this.x, @this.z, @this.x);
    static public Vector4 XXZY(this Vector3 @this)
    => new(@this.x, @this.x, @this.z, @this.y);
    static public Vector4 XXZZ(this Vector3 @this)
    => new(@this.x, @this.x, @this.z, @this.z);

    static public Vector4 XYXX(this Vector3 @this)
    => new(@this.x, @this.y, @this.x, @this.x);
    static public Vector4 XYXY(this Vector3 @this)
    => new(@this.x, @this.y, @this.x, @this.y);
    static public Vector4 XYXZ(this Vector3 @this)
    => new(@this.x, @this.y, @this.x, @this.z);
    static public Vector4 XYYX(this Vector3 @this)
    => new(@this.x, @this.y, @this.y, @this.x);
    static public Vector4 XYYY(this Vector3 @this)
    => new(@this.x, @this.y, @this.y, @this.y);
    static public Vector4 XYYZ(this Vector3 @this)
    => new(@this.x, @this.y, @this.y, @this.z);
    static public Vector4 XYZX(this Vector3 @this)
    => new(@this.x, @this.y, @this.z, @this.x);
    static public Vector4 XYZY(this Vector3 @this)
    => new(@this.x, @this.y, @this.z, @this.y);
    static public Vector4 XYZZ(this Vector3 @this)
    => new(@this.x, @this.y, @this.z, @this.z);

    static public Vector4 XZXX(this Vector3 @this)
    => new(@this.x, @this.z, @this.x, @this.x);
    static public Vector4 XZXY(this Vector3 @this)
    => new(@this.x, @this.z, @this.x, @this.y);
    static public Vector4 XZXZ(this Vector3 @this)
    => new(@this.x, @this.z, @this.x, @this.z);
    static public Vector4 XZYX(this Vector3 @this)
    => new(@this.x, @this.z, @this.y, @this.x);
    static public Vector4 XZYY(this Vector3 @this)
    => new(@this.x, @this.z, @this.y, @this.y);
    static public Vector4 XZYZ(this Vector3 @this)
    => new(@this.x, @this.z, @this.y, @this.z);
    static public Vector4 XZZX(this Vector3 @this)
    => new(@this.x, @this.z, @this.z, @this.x);
    static public Vector4 XZZY(this Vector3 @this)
    => new(@this.x, @this.z, @this.z, @this.y);
    static public Vector4 XZZZ(this Vector3 @this)
    => new(@this.x, @this.z, @this.z, @this.z);

    static public Vector4 YXXX(this Vector3 @this)
    => new(@this.y, @this.x, @this.x, @this.x);
    static public Vector4 YXXY(this Vector3 @this)
    => new(@this.y, @this.x, @this.x, @this.y);
    static public Vector4 YXXZ(this Vector3 @this)
    => new(@this.y, @this.x, @this.x, @this.z);
    static public Vector4 YXYX(this Vector3 @this)
    => new(@this.y, @this.x, @this.y, @this.x);
    static public Vector4 YXYY(this Vector3 @this)
    => new(@this.y, @this.x, @this.y, @this.y);
    static public Vector4 YXYZ(this Vector3 @this)
    => new(@this.y, @this.x, @this.y, @this.z);
    static public Vector4 YXZX(this Vector3 @this)
    => new(@this.y, @this.x, @this.z, @this.x);
    static public Vector4 YXZY(this Vector3 @this)
    => new(@this.y, @this.x, @this.z, @this.y);
    static public Vector4 YXZZ(this Vector3 @this)
    => new(@this.y, @this.x, @this.z, @this.z);

    static public Vector4 YYXX(this Vector3 @this)
    => new(@this.y, @this.y, @this.x, @this.x);
    static public Vector4 YYXY(this Vector3 @this)
    => new(@this.y, @this.y, @this.x, @this.y);
    static public Vector4 YYXZ(this Vector3 @this)
    => new(@this.y, @this.y, @this.x, @this.z);
    static public Vector4 YYYX(this Vector3 @this)
    => new(@this.y, @this.y, @this.y, @this.x);
    static public Vector4 YYYY(this Vector3 @this)
    => new(@this.y, @this.y, @this.y, @this.y);
    static public Vector4 YYYZ(this Vector3 @this)
    => new(@this.y, @this.y, @this.y, @this.z);
    static public Vector4 YYZX(this Vector3 @this)
    => new(@this.y, @this.y, @this.z, @this.x);
    static public Vector4 YYZY(this Vector3 @this)
    => new(@this.y, @this.y, @this.z, @this.y);
    static public Vector4 YYZZ(this Vector3 @this)
    => new(@this.y, @this.y, @this.z, @this.z);

    static public Vector4 YZXX(this Vector3 @this)
    => new(@this.y, @this.z, @this.x, @this.x);
    static public Vector4 YZXY(this Vector3 @this)
    => new(@this.y, @this.z, @this.x, @this.y);
    static public Vector4 YZXZ(this Vector3 @this)
    => new(@this.y, @this.z, @this.x, @this.z);
    static public Vector4 YZYX(this Vector3 @this)
    => new(@this.y, @this.z, @this.y, @this.x);
    static public Vector4 YZYY(this Vector3 @this)
    => new(@this.y, @this.z, @this.y, @this.y);
    static public Vector4 YZYZ(this Vector3 @this)
    => new(@this.y, @this.z, @this.y, @this.z);
    static public Vector4 YZZX(this Vector3 @this)
    => new(@this.y, @this.z, @this.z, @this.x);
    static public Vector4 YZZY(this Vector3 @this)
    => new(@this.y, @this.z, @this.z, @this.y);
    static public Vector4 YZZZ(this Vector3 @this)
    => new(@this.y, @this.z, @this.z, @this.z);

    static public Vector4 ZXXX(this Vector3 @this)
    => new(@this.z, @this.x, @this.x, @this.x);
    static public Vector4 ZXXY(this Vector3 @this)
    => new(@this.z, @this.x, @this.x, @this.y);
    static public Vector4 ZXXZ(this Vector3 @this)
    => new(@this.z, @this.x, @this.x, @this.z);
    static public Vector4 ZXYX(this Vector3 @this)
    => new(@this.z, @this.x, @this.y, @this.x);
    static public Vector4 ZXYY(this Vector3 @this)
    => new(@this.z, @this.x, @this.y, @this.y);
    static public Vector4 ZXYZ(this Vector3 @this)
    => new(@this.z, @this.x, @this.y, @this.z);
    static public Vector4 ZXZX(this Vector3 @this)
    => new(@this.z, @this.x, @this.z, @this.x);
    static public Vector4 ZXZY(this Vector3 @this)
    => new(@this.z, @this.x, @this.z, @this.y);
    static public Vector4 ZXZZ(this Vector3 @this)
    => new(@this.z, @this.x, @this.z, @this.z);

    static public Vector4 ZYXX(this Vector3 @this)
    => new(@this.z, @this.y, @this.x, @this.x);
    static public Vector4 ZYXY(this Vector3 @this)
    => new(@this.z, @this.y, @this.x, @this.y);
    static public Vector4 ZYXZ(this Vector3 @this)
    => new(@this.z, @this.y, @this.x, @this.z);
    static public Vector4 ZYYX(this Vector3 @this)
    => new(@this.z, @this.y, @this.y, @this.x);
    static public Vector4 ZYYY(this Vector3 @this)
    => new(@this.z, @this.y, @this.y, @this.y);
    static public Vector4 ZYYZ(this Vector3 @this)
    => new(@this.z, @this.y, @this.y, @this.z);
    static public Vector4 ZYZX(this Vector3 @this)
    => new(@this.z, @this.y, @this.z, @this.x);
    static public Vector4 ZYZY(this Vector3 @this)
    => new(@this.z, @this.y, @this.z, @this.y);
    static public Vector4 ZYZZ(this Vector3 @this)
    => new(@this.z, @this.y, @this.z, @this.z);

    static public Vector4 ZZXX(this Vector3 @this)
    => new(@this.z, @this.z, @this.x, @this.x);
    static public Vector4 ZZXY(this Vector3 @this)
    => new(@this.z, @this.z, @this.x, @this.y);
    static public Vector4 ZZXZ(this Vector3 @this)
    => new(@this.z, @this.z, @this.x, @this.z);
    static public Vector4 ZZYX(this Vector3 @this)
    => new(@this.z, @this.z, @this.y, @this.x);
    static public Vector4 ZZYY(this Vector3 @this)
    => new(@this.z, @this.z, @this.y, @this.y);
    static public Vector4 ZZYZ(this Vector3 @this)
    => new(@this.z, @this.z, @this.y, @this.z);
    static public Vector4 ZZZX(this Vector3 @this)
    => new(@this.z, @this.z, @this.z, @this.x);
    static public Vector4 ZZZY(this Vector3 @this)
    => new(@this.z, @this.z, @this.z, @this.y);
    static public Vector4 ZZZZ(this Vector3 @this)
    => new(@this.z, @this.z, @this.z, @this.z);
    #endregion
}
#endif