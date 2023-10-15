namespace Vheos.Helpers.Math;

public static class Extensions_Vector3
{
    // Binary
    public static f3 Add(this (f x, f y, f z) t, f3 a)
        => new(t.x.Add(a.X), t.y.Add(a.Y), t.z.Add(a.Z));
    public static f3 Sub(this f3 t, f3 a)
        => new(t.X.Sub(a.X), t.Y.Sub(a.Y), t.Z.Sub(a.Z));
    public static f3 Mul(this f3 t, f3 a)
        => new(t.X.Mul(a.X), t.Y.Mul(a.Y), t.Z.Mul(a.Z));
    public static f3 Div(this f3 t, f3 a)
        => new(t.X.Div(a.X), t.Y.Div(a.Y), t.Z.Div(a.Z));
    public static f3 Pow(this f3 t, f3 a)
        => new(t.X.Pow(a.X), t.Y.Pow(a.Y), t.Z.Pow(a.Z));
    public static f3 Root(this f3 t, f3 a)
        => new(t.X.Root(a.X), t.Y.Root(a.Y), t.Z.Root(a.Z));
    public static f3 Mod(this f3 t, f3 a)
        => new(t.X.Mod(a.X), t.Y.Mod(a.Y), t.Z.Mod(a.Z));
    public static f3 PosMod(this f3 t, f3 a)
        => new(t.X.PosMod(a.X), t.Y.PosMod(a.Y), t.Z.PosMod(a.Z));
    public static f3 Min(this f3 t, f3 a)
        => new(t.X.Min(a.X), t.Y.Min(a.Y), t.Z.Min(a.Z));
    public static f3 Max(this f3 t, f3 a)
        => new(t.X.Max(a.X), t.Y.Max(a.Y), t.Z.Max(a.Z));
    public static f3 Avg(this f3 t, f3 a)
        => new(t.X.Avg(a.X), t.Y.Avg(a.Y), t.Z.Avg(a.Z));

    public static f3 Add(this f3 t, f x, f y, f z)
        => new(t.X.Add(x), t.Y.Add(y), t.Z.Add(z));
    public static f3 Sub(this f3 t, f x, f y, f z)
        => new(t.X.Sub(x), t.Y.Sub(y), t.Z.Sub(z));
    public static f3 Mul(this f3 t, f x, f y, f z)
        => new(t.X.Mul(x), t.Y.Mul(y), t.Z.Mul(z));
    public static f3 Div(this f3 t, f x, f y, f z)
        => new(t.X.Div(x), t.Y.Div(y), t.Z.Div(z));
    public static f3 Pow(this f3 t, f x, f y, f z)
        => new(t.X.Pow(x), t.Y.Pow(y), t.Z.Pow(z));
    public static f3 Root(this f3 t, f x, f y, f z)
        => new(t.X.Root(x), t.Y.Root(y), t.Z.Root(z));
    public static f3 Mod(this f3 t, f x, f y, f z)
        => new(t.X.Mod(x), t.Y.Mod(y), t.Z.Mod(z));
    public static f3 PosMod(this f3 t, f x, f y, f z)
        => new(t.X.PosMod(x), t.Y.PosMod(y), t.Z.PosMod(z));
    public static f3 Min(this f3 t, f x, f y, f z)
        => new(t.X.Min(x), t.Y.Min(y), t.Z.Min(z));
    public static f3 Max(this f3 t, f x, f y, f z)
        => new(t.X.Max(x), t.Y.Max(y), t.Z.Max(z));
    public static f3 Avg(this f3 t, f x, f y, f z)
        => new(t.X.Avg(x), t.Y.Avg(y), t.Z.Avg(z));

    public static f3 Add(this f3 t, f a)
        => new(t.X.Add(a), t.Y.Add(a), t.Z.Add(a));
    public static f3 Sub(this f3 t, f a)
        => new(t.X.Sub(a), t.Y.Sub(a), t.Z.Sub(a));
    public static f3 Mul(this f3 t, f a)
        => new(t.X.Mul(a), t.Y.Mul(a), t.Z.Mul(a));
    public static f3 Div(this f3 t, f a)
        => new(t.X.Div(a), t.Y.Div(a), t.Z.Div(a));
    public static f3 Pow(this f3 t, f a)
        => new(t.X.Pow(a), t.Y.Pow(a), t.Z.Pow(a));
    public static f3 Root(this f3 t, f a)
        => new(t.X.Root(a), t.Y.Root(a), t.Z.Root(a));
    public static f3 Mod(this f3 t, f a)
        => new(t.X.Mod(a), t.Y.Mod(a), t.Z.Mod(a));
    public static f3 PosMod(this f3 t, f a)
        => new(t.X.PosMod(a), t.Y.PosMod(a), t.Z.PosMod(a));
    public static f3 Min(this f3 t, f a)
        => new(t.X.Min(a), t.Y.Min(a), t.Z.Min(a));
    public static f3 Max(this f3 t, f a)
        => new(t.X.Max(a), t.Y.Max(a), t.Z.Max(a));
    public static f3 Avg(this f3 t, f a)
        => new(t.X.Avg(a), t.Y.Avg(a), t.Z.Avg(a));

    public static f3 Add(this f3 t, i3 a)
        => new(t.X.Add(a.X), t.Y.Add(a.Y), t.Z.Add(a.Z));
    public static f3 Sub(this f3 t, i3 a)
        => new(t.X.Sub(a.X), t.Y.Sub(a.Y), t.Z.Sub(a.Z));
    public static f3 Mul(this f3 t, i3 a)
        => new(t.X.Mul(a.X), t.Y.Mul(a.Y), t.Z.Mul(a.Z));
    public static f3 Div(this f3 t, i3 a)
        => new(t.X.Div(a.X), t.Y.Div(a.Y), t.Z.Div(a.Z));
    public static f3 Pow(this f3 t, i3 a)
        => new(t.X.Pow(a.X), t.Y.Pow(a.Y), t.Z.Pow(a.Z));
    public static f3 Root(this f3 t, i3 a)
        => new(t.X.Root(a.X), t.Y.Root(a.Y), t.Z.Root(a.Z));
    public static f3 Mod(this f3 t, i3 a)
        => new(t.X.Mod(a.X), t.Y.Mod(a.Y), t.Z.Mod(a.Z));
    public static f3 PosMod(this f3 t, i3 a)
        => new(t.X.PosMod(a.X), t.Y.PosMod(a.Y), t.Z.PosMod(a.Z));
    public static f3 Min(this f3 t, i3 a)
        => new(t.X.Min(a.X), t.Y.Min(a.Y), t.Z.Min(a.Z));
    public static f3 Max(this f3 t, i3 a)
        => new(t.X.Max(a.X), t.Y.Max(a.Y), t.Z.Max(a.Z));
    public static f3 Avg(this f3 t, i3 a)
        => new(t.X.Avg(a.X), t.Y.Avg(a.Y), t.Z.Avg(a.Z));

    public static f3 Add(this f3 t, int x, int y, int z)
        => new(t.X.Add(x), t.Y.Add(y), t.Z.Add(z));
    public static f3 Sub(this f3 t, int x, int y, int z)
        => new(t.X.Sub(x), t.Y.Sub(y), t.Z.Sub(z));
    public static f3 Mul(this f3 t, int x, int y, int z)
        => new(t.X.Mul(x), t.Y.Mul(y), t.Z.Mul(z));
    public static f3 Div(this f3 t, int x, int y, int z)
        => new(t.X.Div(x), t.Y.Div(y), t.Z.Div(z));
    public static f3 Pow(this f3 t, int x, int y, int z)
        => new(t.X.Pow(x), t.Y.Pow(y), t.Z.Pow(z));
    public static f3 Root(this f3 t, int x, int y, int z)
        => new(t.X.Root(x), t.Y.Root(y), t.Z.Root(z));
    public static f3 Mod(this f3 t, int x, int y, int z)
        => new(t.X.Mod(x), t.Y.Mod(y), t.Z.Mod(z));
    public static f3 PosMod(this f3 t, int x, int y, int z)
        => new(t.X.PosMod(x), t.Y.PosMod(y), t.Z.PosMod(z));
    public static f3 Min(this f3 t, int x, int y, int z)
        => new(t.X.Min(x), t.Y.Min(y), t.Z.Min(z));
    public static f3 Max(this f3 t, int x, int y, int z)
        => new(t.X.Max(x), t.Y.Max(y), t.Z.Max(z));
    public static f3 Avg(this f3 t, int x, int y, int z)
        => new(t.X.Avg(x), t.Y.Avg(y), t.Z.Avg(z));

    public static f3 Add(this f3 t, int a)
        => new(t.X.Add(a), t.Y.Add(a), t.Z.Add(a));
    public static f3 Sub(this f3 t, int a)
        => new(t.X.Sub(a), t.Y.Sub(a), t.Z.Sub(a));
    public static f3 Mul(this f3 t, int a)
        => new(t.X.Mul(a), t.Y.Mul(a), t.Z.Mul(a));
    public static f3 Div(this f3 t, int a)
        => new(t.X.Div(a), t.Y.Div(a), t.Z.Div(a));
    public static f3 Pow(this f3 t, int a)
        => new(t.X.Pow(a), t.Y.Pow(a), t.Z.Pow(a));
    public static f3 Root(this f3 t, int a)
        => new(t.X.Root(a), t.Y.Root(a), t.Z.Root(a));
    public static f3 Mod(this f3 t, int a)
        => new(t.X.Mod(a), t.Y.Mod(a), t.Z.Mod(a));
    public static f3 PosMod(this f3 t, int a)
        => new(t.X.PosMod(a), t.Y.PosMod(a), t.Z.PosMod(a));
    public static f3 Min(this f3 t, int a)
        => new(t.X.Min(a), t.Y.Min(a), t.Z.Min(a));
    public static f3 Max(this f3 t, int a)
        => new(t.X.Max(a), t.Y.Max(a), t.Z.Max(a));
    public static f3 Avg(this f3 t, int a)
        => new(t.X.Avg(a), t.Y.Avg(a), t.Z.Avg(a));

    // Unary
    public static f3 Neg(this f3 t)
        => new(t.X.Neg(), t.Y.Neg(), t.Z.Neg());
    public static f3 Inv(this f3 t)
        => new(t.X.Inv(), t.Y.Inv(), t.Z.Inv());
    public static f3 Abs(this f3 t)
        => new(t.X.Abs(), t.Y.Abs(), t.Z.Abs());
    public static i3 Sig(this f3 t)
        => new(t.X.Sig(), t.Y.Sig(), t.Z.Sig());
    public static f3 Sqrd(this f3 t)
        => new(t.X.Sqrd(), t.Y.Sqrd(), t.Z.Sqrd());
    public static f3 Sqrt(this f3 t)
        => new(t.X.Sqrt(), t.Y.Sqrt(), t.Z.Sqrt());

    // Trig
    public static f3 Sin(this f3 t, bool degrees = false)
        => new(t.X.Sin(degrees), t.Y.Sin(degrees), t.Z.Sin(degrees));
    public static f3 Cos(this f3 t, bool degrees = false)
        => new(t.X.Cos(degrees), t.Y.Cos(degrees), t.Z.Cos(degrees));
    public static f3 Tan(this f3 t, bool degrees = false)
        => new(t.X.Tan(degrees), t.Y.Tan(degrees), t.Z.Tan(degrees));
    public static f3 Cot(this f3 t, bool degrees = false)
        => new(t.X.Cot(degrees), t.Y.Cot(degrees), t.Z.Cot(degrees));
    public static f3 Sec(this f3 t, bool degrees = false)
        => new(t.X.Sec(degrees), t.Y.Sec(degrees), t.Z.Sec(degrees));
    public static f3 Csc(this f3 t, bool degrees = false)
        => new(t.X.Csc(degrees), t.Y.Csc(degrees), t.Z.Csc(degrees));
    public static f3 ArcSin(this f3 t, bool degrees = false)
        => new(t.X.ArcSin(degrees), t.Y.ArcSin(degrees), t.Z.ArcSin(degrees));
    public static f3 ArcCos(this f3 t, bool degrees = false)
        => new(t.X.ArcCos(degrees), t.Y.ArcCos(degrees), t.Z.ArcCos(degrees));
    public static f3 ArcTan(this f3 t, bool degrees = false)
        => new(t.X.ArcTan(degrees), t.Y.ArcTan(degrees), t.Z.ArcTan(degrees));

    // Round
    public static i3 Round(this f3 t)
        => new(t.X.Round(), t.Y.Round(), t.Z.Round());
    public static i3 RoundDown(this f3 t)
        => new(t.X.RoundDown(), t.Y.RoundDown(), t.Z.RoundDown());
    public static i3 RoundUp(this f3 t)
        => new(t.X.RoundUp(), t.Y.RoundUp(), t.Z.RoundUp());
    public static i3 RoundTowardsZero(this f3 t)
        => new(t.X.RoundTowardsZero(), t.Y.RoundTowardsZero(), t.Z.RoundTowardsZero());
    public static i3 RoundAwayFromZero(this f3 t)
        => new(t.X.RoundAwayFromZero(), t.Y.RoundAwayFromZero(), t.Z.RoundAwayFromZero());
    public static f3 RoundToDecimalDigits(this f3 t, int a)
        => new(t.X.RoundToDecimalDigits(a), t.Y.RoundToDecimalDigits(a), t.Z.RoundToDecimalDigits(a));

    public static f3 RoundToMultiple(this f3 t, f3 a)
        => new(t.X.RoundToMultiple(a.X), t.Y.RoundToMultiple(a.Y), t.Z.RoundToMultiple(a.Z));
    public static f3 RoundToMultiple(this f3 t, f x, f y, f z)
        => new(t.X.RoundToMultiple(x), t.Y.RoundToMultiple(y), t.Z.RoundToMultiple(z));
    public static f3 RoundToMultiple(this f3 t, f a)
        => new(t.X.RoundToMultiple(a), t.Y.RoundToMultiple(a), t.Z.RoundToMultiple(a));

    public static i3 RoundToMultiple(this f3 t, i3 a)
        => new(t.X.RoundToMultiple(a.X), t.Y.RoundToMultiple(a.Y), t.Z.RoundToMultiple(a.Z));
    public static i3 RoundToMultiple(this f3 t, int x, int y, int z)
        => new(t.X.RoundToMultiple(x), t.Y.RoundToMultiple(y), t.Z.RoundToMultiple(z));
    public static i3 RoundToMultiple(this f3 t, int a)
        => new(t.X.RoundToMultiple(a), t.Y.RoundToMultiple(a), t.Z.RoundToMultiple(a));

    // Clamp
    public static f3 Clamp01(this f3 t)
        => new(t.X.Clamp01(), t.Y.Clamp01(), t.Z.Clamp01());

    public static f3 Clamp(this f3 t, f3 a, f3 b)
        => new(t.X.Clamp(a.X, b.X), t.Y.Clamp(a.Y, b.Y), t.Z.Clamp(a.Z, b.Z));
    public static f3 ClampMin(this f3 t, f3 a)
        => new(t.X.ClampMin(a.X), t.Y.ClampMin(a.Y), t.Z.ClampMin(a.Z));
    public static f3 ClampMax(this f3 t, f3 a)
        => new(t.X.ClampMax(a.X), t.Y.ClampMax(a.Y), t.Z.ClampMax(a.Z));
    public static f3 Lerp(this f3 t, f3 a, f b)
        => new(t.X.Lerp(a.X, b), t.Y.Lerp(a.Y, b), t.Z.Lerp(a.Z, b));
    public static f3 LerpClamped(this f3 t, f3 a, f b)
        => new(t.X.LerpClamped(a.X, b), t.Y.LerpClamped(a.Y, b), t.Z.LerpClamped(a.Z, b));
    public static f3 Map(this f3 t, f3 a, f3 b, f3 c, f3 d)
        => new(t.X.Map(a.X, b.X, c.X, d.X), t.Y.Map(a.Y, b.Y, c.Y, d.Y), t.Z.Map(a.Z, b.Z, c.Z, d.Z));
    public static f3 MapClamped(this f3 t, f3 a, f3 b, f3 c, f3 d)
        => new(t.X.MapClamped(a.X, b.X, c.X, d.X), t.Y.MapClamped(a.Y, b.Y, c.Y, d.Y), t.Z.MapClamped(a.Z, b.Z, c.Z, d.Z));
    public static f3 MapFrom01(this f3 t, f3 a, f3 b)
        => new(t.X.MapFrom01(a.X, b.X), t.Y.MapFrom01(a.Y, b.Y), t.Z.MapFrom01(a.Z, b.Z));
    public static f3 MapTo01(this f3 t, f3 a, f3 b)
        => new(t.X.MapTo01(a.X, b.X), t.Y.MapTo01(a.Y, b.Y), t.Z.MapTo01(a.Z, b.Z));

    public static f3 Clamp(this f3 t, f ax, f ay, f az, f bx, f by, f bz)
        => new(t.X.Clamp(ax, bx), t.Y.Clamp(ay, by), t.Z.Clamp(az, bz));
    public static f3 ClampMin(this f3 t, f x, f y, f z)
        => new(t.X.ClampMin(x), t.Y.ClampMin(y), t.Z.ClampMin(z));
    public static f3 ClampMax(this f3 t, f x, f y, f z)
        => new(t.X.ClampMax(x), t.Y.ClampMax(y), t.Z.ClampMax(z));
    public static f3 Lerp(this f3 t, f x, f y, f z, f b)
        => new(t.X.Lerp(x, b), t.Y.Lerp(y, b), t.Z.Lerp(z, b));
    public static f3 LerpClamped(this f3 t, f x, f y, f z, f b)
        => new(t.X.LerpClamped(x, b), t.Y.LerpClamped(y, b), t.Z.LerpClamped(z, b));
    public static f3 Map(this f3 t, f ax, f ay, f az, f bx, f by, f bz, f cx, f cy, f cz, f dx, f dy, f dz)
        => new(t.X.Map(ax, bx, cx, dx), t.Y.Map(ay, by, cy, dy), t.Z.Map(az, bz, cz, dz));
    public static f3 MapClamped(this f3 t, f ax, f ay, f az, f bx, f by, f bz, f cx, f cy, f cz, f dx, f dy, f dz)
        => new(t.X.MapClamped(ax, bx, cx, dx), t.Y.MapClamped(ay, by, cy, dy), t.Z.MapClamped(az, bz, cz, dz));
    public static f3 MapFrom01(this f3 t, f ax, f ay, f az, f bx, f by, f bz)
        => new(t.X.MapFrom01(ax, bx), t.Y.MapFrom01(ay, by), t.Z.MapFrom01(az, bz));
    public static f3 MapTo01(this f3 t, f ax, f ay, f az, f bx, f by, f bz)
        => new(t.X.MapTo01(ax, bx), t.Y.MapTo01(ay, by), t.Z.MapTo01(az, bz));

    public static f3 Clamp(this f3 t, f a, f b)
        => new(t.X.Clamp(a, b), t.Y.Clamp(a, b), t.Z.Clamp(a, b));
    public static f3 ClampMin(this f3 t, f a)
        => new(t.X.ClampMin(a), t.Y.ClampMin(a), t.Z.ClampMin(a));
    public static f3 ClampMax(this f3 t, f a)
        => new(t.X.ClampMax(a), t.Y.ClampMax(a), t.Z.ClampMax(a));
    public static f3 Lerp(this f3 t, f a, f b)
        => new(t.X.Lerp(a, b), t.Y.Lerp(a, b), t.Z.Lerp(a, b));
    public static f3 LerpClamped(this f3 t, f a, f b)
        => new(t.X.LerpClamped(a, b), t.Y.LerpClamped(a, b), t.Z.LerpClamped(a, b));
    public static f3 Map(this f3 t, f a, f b, f c, f d)
        => new(t.X.Map(a, b, c, d), t.Y.Map(a, b, c, d), t.Z.Map(a, b, c, d));
    public static f3 MapClamped(this f3 t, f a, f b, f c, f d)
     => new(t.X.MapClamped(a, b, c, d), t.Y.MapClamped(a, b, c, d), t.Z.MapClamped(a, b, c, d));
    public static f3 MapFrom01(this f3 t, f a, f b)
        => new(t.X.MapFrom01(a, b), t.Y.MapFrom01(a, b), t.Z.MapFrom01(a, b));
    public static f3 MapTo01(this f3 t, f a, f b)
        => new(t.X.MapTo01(a, b), t.Y.MapTo01(a, b), t.Z.MapTo01(a, b));

    public static f3 Clamp(this f3 t, i3 a, i3 b)
        => new(t.X.Clamp(a.X, b.X), t.Y.Clamp(a.Y, b.Y), t.Z.Clamp(a.Z, b.Z));
    public static f3 ClampMin(this f3 t, i3 a)
        => new(t.X.ClampMin(a.X), t.Y.ClampMin(a.Y), t.Z.ClampMin(a.Z));
    public static f3 ClampMax(this f3 t, i3 a)
        => new(t.X.ClampMax(a.X), t.Y.ClampMax(a.Y), t.Z.ClampMax(a.Z));
    public static f3 Lerp(this f3 t, i3 a, f b)
        => new(t.X.Lerp(a.X, b), t.Y.Lerp(a.Y, b), t.Z.Lerp(a.Z, b));
    public static f3 LerpClamped(this f3 t, i3 a, f b)
        => new(t.X.LerpClamped(a.X, b), t.Y.LerpClamped(a.Y, b), t.Z.LerpClamped(a.Z, b));
    public static f3 Map(this f3 t, i3 a, i3 b, i3 c, i3 d)
        => new(t.X.Map(a.X, b.X, c.X, d.X), t.Y.Map(a.Y, b.Y, c.Y, d.Y), t.Z.Map(a.Z, b.Z, c.Z, d.Z));
    public static f3 MapClamped(this f3 t, i3 a, i3 b, i3 c, i3 d)
        => new(t.X.MapClamped(a.X, b.X, c.X, d.X), t.Y.MapClamped(a.Y, b.Y, c.Y, d.Y), t.Z.MapClamped(a.Z, b.Z, c.Z, d.Z));
    public static f3 MapFrom01(this f3 t, i3 a, i3 b)
        => new(t.X.MapFrom01(a.X, b.X), t.Y.MapFrom01(a.Y, b.Y), t.Z.MapFrom01(a.Z, b.Z));
    public static f3 MapTo01(this f3 t, i3 a, i3 b)
        => new(t.X.MapTo01(a.X, b.X), t.Y.MapTo01(a.Y, b.Y), t.Z.MapTo01(a.Z, b.Z));

    public static f3 Clamp(this f3 t, int ax, int ay, int az, int bx, int by, int bz)
        => new(t.X.Clamp(ax, bx), t.Y.Clamp(ay, by), t.Z.Clamp(az, bz));
    public static f3 ClampMin(this f3 t, int x, int y, int z)
        => new(t.X.ClampMin(x), t.Y.ClampMin(y), t.Z.ClampMin(z));
    public static f3 ClampMax(this f3 t, int x, int y, int z)
        => new(t.X.ClampMax(x), t.Y.ClampMax(y), t.Z.ClampMax(z));
    public static f3 Lerp(this f3 t, int x, int y, int z, f b)
        => new(t.X.Lerp(x, b), t.Y.Lerp(y, b), t.Z.Lerp(z, b));
    public static f3 LerpClamped(this f3 t, int x, int y, int z, f b)
        => new(t.X.LerpClamped(x, b), t.Y.LerpClamped(y, b), t.Z.LerpClamped(z, b));
    public static f3 Map(this f3 t, int ax, int ay, int az, int bx, int by, int bz, int cx, int cy, int cz, int dx, int dy, int dz)
        => new(t.X.Map(ax, bx, cx, dx), t.Y.Map(ay, by, cy, dy), t.Z.Map(az, bz, cz, dz));
    public static f3 MapClamped(this f3 t, int ax, int ay, int az, int bx, int by, int bz, int cx, int cy, int cz, int dx, int dy, int dz)
        => new(t.X.MapClamped(ax, bx, cx, dx), t.Y.MapClamped(ay, by, cy, dy), t.Z.MapClamped(az, bz, cz, dz));
    public static f3 MapFrom01(this f3 t, int ax, int ay, int az, int bx, int by, int bz)
        => new(t.X.MapFrom01(ax, bx), t.Y.MapFrom01(ay, by), t.Z.MapFrom01(az, bz));
    public static f3 MapTo01(this f3 t, int ax, int ay, int az, int bx, int by, int bz)
        => new(t.X.MapTo01(ax, bx), t.Y.MapTo01(ay, by), t.Z.MapTo01(az, bz));

    public static f3 Clamp(this f3 t, int a, int b)
        => new(t.X.Clamp(a, b), t.Y.Clamp(a, b), t.Z.Clamp(a, b));
    public static f3 ClampMin(this f3 t, int a)
        => new(t.X.ClampMin(a), t.Y.ClampMin(a), t.Z.ClampMin(a));
    public static f3 ClampMax(this f3 t, int a)
        => new(t.X.ClampMax(a), t.Y.ClampMax(a), t.Z.ClampMax(a));
    public static f3 Lerp(this f3 t, int a, f b)
        => new(t.X.Lerp(a, b), t.Y.Lerp(a, b), t.Z.Lerp(a, b));
    public static f3 LerpClamped(this f3 t, int a, f b)
        => new(t.X.LerpClamped(a, b), t.Y.LerpClamped(a, b), t.Z.LerpClamped(a, b));
    public static f3 Map(this f3 t, int a, int b, int c, int d)
        => new(t.X.Map(a, b, c, d), t.Y.Map(a, b, c, d), t.Z.Map(a, b, c, d));
    public static f3 MapClamped(this f3 t, int a, int b, int c, int d)
     => new(t.X.MapClamped(a, b, c, d), t.Y.MapClamped(a, b, c, d), t.Z.MapClamped(a, b, c, d));
    public static f3 MapFrom01(this f3 t, int a, int b)
        => new(t.X.MapFrom01(a, b), t.Y.MapFrom01(a, b), t.Z.MapFrom01(a, b));
    public static f3 MapTo01(this f3 t, int a, int b)
        => new(t.X.MapTo01(a, b), t.Y.MapTo01(a, b), t.Z.MapTo01(a, b));

    // Spatial
    public static f Dot(this f3 t, f3 a)
        => t.X * a.X + t.Y * a.Y + t.Z * a.Z;
    public static f DistanceTo(this f3 t, f3 a)
        => (a - t).magnitude;
    public static f3 OffsetTo(this f3 t, f3 a)
        => a - t;
    public static f3 OffsetFrom(this f3 t, f3 a)
        => t - a;
    public static f3 DirectionTowards(this f3 t, f3 a)
        => (a - t).normalized;
    public static f3 DirectionAwayFrom(this f3 t, f3 a)
        => (t - a).normalized;

    public static f Dot(this f3 t, f x, f y, f z)
        => t.X * x + t.Y * y + t.Z * z;
    public static f DistanceTo(this f3 t, f x, f y, f z)
        => new Math.f3(x - t.X, y - t.Y, z - t.Z).magnitude;
    public static f3 OffsetTo(this f3 t, f x, f y, f z)
        => new(x - t.X, y - t.Y, z - t.Z);
    public static f3 OffsetFrom(this f3 t, f x, f y, f z)
        => new(t.X - x, t.Y - y, t.Z - z);
    public static f3 DirectionTowards(this f3 t, f x, f y, f z)
        => new Math.f3(x - t.X, y - t.Y, z - t.Z).normalized;
    public static f3 DirectionAwayFrom(this f3 t, f x, f y, f z)
        => new Math.f3(t.X - x, t.Y - y, t.Z - z).normalized;

    public static f Dot(this f3 t, i3 a)
        => t.X * a.X + t.Y * a.Y + t.Z * a.Z;
    public static f DistanceTo(this f3 t, i3 a)
        => (a - t).magnitude;
    public static f3 OffsetTo(this f3 t, i3 a)
        => a - t;
    public static f3 OffsetFrom(this f3 t, i3 a)
        => t - a;
    public static f3 DirectionTowards(this f3 t, i3 a)
        => (a - t).normalized;
    public static f3 DirectionAwayFrom(this f3 t, i3 a)
        => (t - a).normalized;

    public static f Dot(this f3 t, int x, int y, int z)
        => t.X * x + t.Y * y + t.Z * z;
    public static f DistanceTo(this f3 t, int x, int y, int z)
        => new Math.f3(x - t.X, y - t.Y, z - t.Z).magnitude;
    public static f3 OffsetTo(this f3 t, int x, int y, int z)
        => new(x - t.X, y - t.Y, z - t.Z);
    public static f3 OffsetFrom(this f3 t, int x, int y, int z)
        => new(t.X - x, t.Y - y, t.Z - z);
    public static f3 DirectionTowards(this f3 t, int x, int y, int z)
        => new Math.f3(x - t.X, y - t.Y, z - t.Z).normalized;
    public static f3 DirectionAwayFrom(this f3 t, int x, int y, int z)
        => new Math.f3(t.X - x, t.Y - y, t.Z - z).normalized;


    // 3D uniques
    public static f3 Cross(this f3 t, f3 a)
        => new(t.Y * a.Z - t.Z * a.Y, t.Z * a.X - t.X * a.Z, t.X * a.Y - t.Y * a.X);
    public static f3 Cross(this f3 t, f x, f y, f z)
        => new(t.Y * z - t.Z * y, t.Z * x - t.X * z, t.X * y - t.Y * x);
    public static f3 Cross(this f3 t, i3 a)
        => new(t.Y * a.Z - t.Z * a.Y, t.Z * a.X - t.X * a.Z, t.X * a.Y - t.Y * a.X);
    public static f3 Cross(this f3 t, int x, int y, int z)
        => new(t.Y * z - t.Z * y, t.Z * x - t.X * z, t.X * y - t.Y * x);

    // Comps
    public static IEnumerable<f> Comps(this f3 t)
    {
        yield return t.X;
        yield return t.Y;
        yield return t.Z;
    }
    public static f CompSum(this f3 t)
        => t.X + t.Y + t.Z;
    public static f CompProduct(this f3 t)
        => t.X * t.Y * t.Z;
    public static f CompMin(this f3 t)
        => Mathf.Min(t.X, t.Y, t.Z);
    public static f CompMax(this f3 t)
        => Mathf.Max(t.X, t.Y, t.Z);
    public static f CompAvg(this f3 t)
        => (t.X + t.Y + t.Z) / 3f;
    public static bool Any(this f3 t, Func<f, bool> test)
        => test(t.X) || test(t.Y) || test(t.Z);
    public static bool All(this f3 t, Func<f, bool> test)
        => test(t.X) && test(t.Y) && test(t.Z);

    public static f3 CompDistanceTo(this f3 t, f3 a)
        => new(t.X.DistanceTo(a.X), t.Y.DistanceTo(a.Y), t.Z.DistanceTo(a.Z));
    public static f3 CompDistanceTo(this f3 t, f x, f y, f z)
        => new(t.X.DistanceTo(x), t.Y.DistanceTo(y), t.Z.DistanceTo(z));
    public static f3 CompDistanceTo(this f3 t, f a)
        => new(t.X.DistanceTo(a), t.Y.DistanceTo(a), t.Z.DistanceTo(a));

    public static f3 CompDistanceTo(this f3 t, i3 a)
        => new(t.X.DistanceTo(a.X), t.Y.DistanceTo(a.Y), t.Z.DistanceTo(a.Z));
    public static f3 CompDistanceTo(this f3 t, int x, int y, int z)
        => new(t.X.DistanceTo(x), t.Y.DistanceTo(y), t.Z.DistanceTo(z));
    public static f3 CompDistanceTo(this f3 t, int a)
        => new(t.X.DistanceTo(a), t.Y.DistanceTo(a), t.Z.DistanceTo(a));

    // Conversions
    public static Math.i2 ToVector2Int(this f3 t)
        => new((int)t.X, (int)t.Y);
    public static i3 ToVector3Int(this f3 t)
        => new((int)t.X, (int)t.Y, (int)t.Z);
    public static Math.i4 ToVector4Int(this f3 t)
        => new((int)t.X, (int)t.Y, (int)t.Z, 0);

    public static Math.f4 Append(this f3 t)
        => new(t.X, t.Y, t.Z, 0f);
    public static Math.f4 Append(this f3 t, f w)
        => new(t.X, t.Y, t.Z, w);

    // XYZW
    #region XYZW
    public static f3 NewX(this f3 t, f x)
        => new(x, t.Y, t.Z);
    public static f3 NewY(this f3 t, f y)
        => new(t.X, y, t.Z);
    public static f3 NewZ(this f3 t, f z)
        => new(t.X, t.Y, z);

    public static f3 NewXY(this f3 t, f x, f y)
        => new(x, y, t.Z);
    public static f3 NewXZ(this f3 t, f x, f z)
        => new(x, t.Y, z);
    public static f3 NewYX(this f3 t, f y, f x)
        => new(x, y, t.Z);
    public static f3 NewYZ(this f3 t, f y, f z)
        => new(t.X, y, z);
    public static f3 NewZX(this f3 t, f z, f x)
        => new(x, t.Y, z);
    public static f3 NewZY(this f3 t, f z, f y)
        => new(t.X, y, z);

    public static Math.f2 XX(this f3 t)
        => new(t.X, t.X);
    public static Math.f2 XY(this f3 t)
        => new(t.X, t.Y);
    public static Math.f2 XZ(this f3 t)
        => new(t.X, t.Z);
    public static Math.f2 YX(this f3 t)
        => new(t.Y, t.X);
    public static Math.f2 YY(this f3 t)
        => new(t.Y, t.Y);
    public static Math.f2 YZ(this f3 t)
        => new(t.Y, t.Z);
    public static Math.f2 ZX(this f3 t)
        => new(t.Z, t.X);
    public static Math.f2 ZY(this f3 t)
        => new(t.Z, t.Y);
    public static Math.f2 ZZ(this f3 t)
        => new(t.Z, t.Z);

    public static f3 XXX(this f3 t)
        => new(t.X, t.X, t.X);
    public static f3 XXY(this f3 t)
        => new(t.X, t.X, t.Y);
    public static f3 XXZ(this f3 t)
        => new(t.X, t.X, t.Z);
    public static f3 XYX(this f3 t)
        => new(t.X, t.Y, t.X);
    public static f3 XYY(this f3 t)
        => new(t.X, t.Y, t.Y);
    public static f3 XYZ(this f3 t)
        => new(t.X, t.Y, t.Z);
    public static f3 XZX(this f3 t)
        => new(t.X, t.Z, t.X);
    public static f3 XZY(this f3 t)
        => new(t.X, t.Z, t.Y);
    public static f3 XZZ(this f3 t)
        => new(t.X, t.Z, t.Z);

    public static f3 YXX(this f3 t)
        => new(t.Y, t.X, t.X);
    public static f3 YXY(this f3 t)
        => new(t.Y, t.X, t.Y);
    public static f3 YXZ(this f3 t)
        => new(t.Y, t.X, t.Z);
    public static f3 YYX(this f3 t)
        => new(t.Y, t.Y, t.X);
    public static f3 YYY(this f3 t)
        => new(t.Y, t.Y, t.Y);
    public static f3 YYZ(this f3 t)
        => new(t.Y, t.Y, t.Z);
    public static f3 YZX(this f3 t)
        => new(t.Y, t.Z, t.X);
    public static f3 YZY(this f3 t)
        => new(t.Y, t.Z, t.Y);
    public static f3 YZZ(this f3 t)
        => new(t.Y, t.Z, t.Z);

    public static f3 ZXX(this f3 t)
        => new(t.Z, t.X, t.X);
    public static f3 ZXY(this f3 t)
        => new(t.Z, t.X, t.Y);
    public static f3 ZXZ(this f3 t)
        => new(t.Z, t.X, t.Z);
    public static f3 ZYX(this f3 t)
        => new(t.Z, t.Y, t.X);
    public static f3 ZYY(this f3 t)
        => new(t.Z, t.Y, t.Y);
    public static f3 ZYZ(this f3 t)
        => new(t.Z, t.Y, t.Z);
    public static f3 ZZX(this f3 t)
        => new(t.Z, t.Z, t.X);
    public static f3 ZZY(this f3 t)
        => new(t.Z, t.Z, t.Y);
    public static f3 ZZZ(this f3 t)
        => new(t.Z, t.Z, t.Z);

    public static Math.f4 XXXX(this f3 t)
        => new(t.X, t.X, t.X, t.X);
    public static Math.f4 XXXY(this f3 t)
        => new(t.X, t.X, t.X, t.Y);
    public static Math.f4 XXXZ(this f3 t)
        => new(t.X, t.X, t.X, t.Z);
    public static Math.f4 XXYX(this f3 t)
        => new(t.X, t.X, t.Y, t.X);
    public static Math.f4 XXYY(this f3 t)
        => new(t.X, t.X, t.Y, t.Y);
    public static Math.f4 XXYZ(this f3 t)
        => new(t.X, t.X, t.Y, t.Z);
    public static Math.f4 XXZX(this f3 t)
        => new(t.X, t.X, t.Z, t.X);
    public static Math.f4 XXZY(this f3 t)
        => new(t.X, t.X, t.Z, t.Y);
    public static Math.f4 XXZZ(this f3 t)
        => new(t.X, t.X, t.Z, t.Z);

    public static Math.f4 XYXX(this f3 t)
        => new(t.X, t.Y, t.X, t.X);
    public static Math.f4 XYXY(this f3 t)
        => new(t.X, t.Y, t.X, t.Y);
    public static Math.f4 XYXZ(this f3 t)
        => new(t.X, t.Y, t.X, t.Z);
    public static Math.f4 XYYX(this f3 t)
        => new(t.X, t.Y, t.Y, t.X);
    public static Math.f4 XYYY(this f3 t)
        => new(t.X, t.Y, t.Y, t.Y);
    public static Math.f4 XYYZ(this f3 t)
        => new(t.X, t.Y, t.Y, t.Z);
    public static Math.f4 XYZX(this f3 t)
        => new(t.X, t.Y, t.Z, t.X);
    public static Math.f4 XYZY(this f3 t)
        => new(t.X, t.Y, t.Z, t.Y);
    public static Math.f4 XYZZ(this f3 t)
        => new(t.X, t.Y, t.Z, t.Z);

    public static Math.f4 XZXX(this f3 t)
        => new(t.X, t.Z, t.X, t.X);
    public static Math.f4 XZXY(this f3 t)
        => new(t.X, t.Z, t.X, t.Y);
    public static Math.f4 XZXZ(this f3 t)
        => new(t.X, t.Z, t.X, t.Z);
    public static Math.f4 XZYX(this f3 t)
        => new(t.X, t.Z, t.Y, t.X);
    public static Math.f4 XZYY(this f3 t)
        => new(t.X, t.Z, t.Y, t.Y);
    public static Math.f4 XZYZ(this f3 t)
        => new(t.X, t.Z, t.Y, t.Z);
    public static Math.f4 XZZX(this f3 t)
        => new(t.X, t.Z, t.Z, t.X);
    public static Math.f4 XZZY(this f3 t)
        => new(t.X, t.Z, t.Z, t.Y);
    public static Math.f4 XZZZ(this f3 t)
        => new(t.X, t.Z, t.Z, t.Z);

    public static Math.f4 YXXX(this f3 t)
        => new(t.Y, t.X, t.X, t.X);
    public static Math.f4 YXXY(this f3 t)
        => new(t.Y, t.X, t.X, t.Y);
    public static Math.f4 YXXZ(this f3 t)
        => new(t.Y, t.X, t.X, t.Z);
    public static Math.f4 YXYX(this f3 t)
        => new(t.Y, t.X, t.Y, t.X);
    public static Math.f4 YXYY(this f3 t)
        => new(t.Y, t.X, t.Y, t.Y);
    public static Math.f4 YXYZ(this f3 t)
        => new(t.Y, t.X, t.Y, t.Z);
    public static Math.f4 YXZX(this f3 t)
        => new(t.Y, t.X, t.Z, t.X);
    public static Math.f4 YXZY(this f3 t)
        => new(t.Y, t.X, t.Z, t.Y);
    public static Math.f4 YXZZ(this f3 t)
        => new(t.Y, t.X, t.Z, t.Z);

    public static Math.f4 YYXX(this f3 t)
        => new(t.Y, t.Y, t.X, t.X);
    public static Math.f4 YYXY(this f3 t)
        => new(t.Y, t.Y, t.X, t.Y);
    public static Math.f4 YYXZ(this f3 t)
        => new(t.Y, t.Y, t.X, t.Z);
    public static Math.f4 YYYX(this f3 t)
        => new(t.Y, t.Y, t.Y, t.X);
    public static Math.f4 YYYY(this f3 t)
        => new(t.Y, t.Y, t.Y, t.Y);
    public static Math.f4 YYYZ(this f3 t)
        => new(t.Y, t.Y, t.Y, t.Z);
    public static Math.f4 YYZX(this f3 t)
        => new(t.Y, t.Y, t.Z, t.X);
    public static Math.f4 YYZY(this f3 t)
        => new(t.Y, t.Y, t.Z, t.Y);
    public static Math.f4 YYZZ(this f3 t)
        => new(t.Y, t.Y, t.Z, t.Z);

    public static Math.f4 YZXX(this f3 t)
        => new(t.Y, t.Z, t.X, t.X);
    public static Math.f4 YZXY(this f3 t)
        => new(t.Y, t.Z, t.X, t.Y);
    public static Math.f4 YZXZ(this f3 t)
        => new(t.Y, t.Z, t.X, t.Z);
    public static Math.f4 YZYX(this f3 t)
        => new(t.Y, t.Z, t.Y, t.X);
    public static Math.f4 YZYY(this f3 t)
        => new(t.Y, t.Z, t.Y, t.Y);
    public static Math.f4 YZYZ(this f3 t)
        => new(t.Y, t.Z, t.Y, t.Z);
    public static Math.f4 YZZX(this f3 t)
        => new(t.Y, t.Z, t.Z, t.X);
    public static Math.f4 YZZY(this f3 t)
        => new(t.Y, t.Z, t.Z, t.Y);
    public static Math.f4 YZZZ(this f3 t)
        => new(t.Y, t.Z, t.Z, t.Z);

    public static Math.f4 ZXXX(this f3 t)
        => new(t.Z, t.X, t.X, t.X);
    public static Math.f4 ZXXY(this f3 t)
        => new(t.Z, t.X, t.X, t.Y);
    public static Math.f4 ZXXZ(this f3 t)
        => new(t.Z, t.X, t.X, t.Z);
    public static Math.f4 ZXYX(this f3 t)
        => new(t.Z, t.X, t.Y, t.X);
    public static Math.f4 ZXYY(this f3 t)
        => new(t.Z, t.X, t.Y, t.Y);
    public static Math.f4 ZXYZ(this f3 t)
        => new(t.Z, t.X, t.Y, t.Z);
    public static Math.f4 ZXZX(this f3 t)
        => new(t.Z, t.X, t.Z, t.X);
    public static Math.f4 ZXZY(this f3 t)
        => new(t.Z, t.X, t.Z, t.Y);
    public static Math.f4 ZXZZ(this f3 t)
        => new(t.Z, t.X, t.Z, t.Z);

    public static Math.f4 ZYXX(this f3 t)
        => new(t.Z, t.Y, t.X, t.X);
    public static Math.f4 ZYXY(this f3 t)
        => new(t.Z, t.Y, t.X, t.Y);
    public static Math.f4 ZYXZ(this f3 t)
        => new(t.Z, t.Y, t.X, t.Z);
    public static Math.f4 ZYYX(this f3 t)
        => new(t.Z, t.Y, t.Y, t.X);
    public static Math.f4 ZYYY(this f3 t)
        => new(t.Z, t.Y, t.Y, t.Y);
    public static Math.f4 ZYYZ(this f3 t)
        => new(t.Z, t.Y, t.Y, t.Z);
    public static Math.f4 ZYZX(this f3 t)
        => new(t.Z, t.Y, t.Z, t.X);
    public static Math.f4 ZYZY(this f3 t)
        => new(t.Z, t.Y, t.Z, t.Y);
    public static Math.f4 ZYZZ(this f3 t)
        => new(t.Z, t.Y, t.Z, t.Z);

    public static Math.f4 ZZXX(this f3 t)
        => new(t.Z, t.Z, t.X, t.X);
    public static Math.f4 ZZXY(this f3 t)
        => new(t.Z, t.Z, t.X, t.Y);
    public static Math.f4 ZZXZ(this f3 t)
        => new(t.Z, t.Z, t.X, t.Z);
    public static Math.f4 ZZYX(this f3 t)
        => new(t.Z, t.Z, t.Y, t.X);
    public static Math.f4 ZZYY(this f3 t)
        => new(t.Z, t.Z, t.Y, t.Y);
    public static Math.f4 ZZYZ(this f3 t)
        => new(t.Z, t.Z, t.Y, t.Z);
    public static Math.f4 ZZZX(this f3 t)
        => new(t.Z, t.Z, t.Z, t.X);
    public static Math.f4 ZZZY(this f3 t)
        => new(t.Z, t.Z, t.Z, t.Y);
    public static Math.f4 ZZZZ(this f3 t)
        => new(t.Z, t.Z, t.Z, t.Z);
    #endregion
}