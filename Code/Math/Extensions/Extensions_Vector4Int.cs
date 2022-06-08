#if UNITY
namespace Vheos.Helpers.Math
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    static public class Extensions_Vector4Int
    {
        // Binary
        static public Vector4 Add(this Vector4Int @this, Vector4 a)
        => new(@this.x.Add(a.x), @this.y.Add(a.y), @this.z.Add(a.z), @this.w.Add(a.w));
        static public Vector4 Sub(this Vector4Int @this, Vector4 a)
        => new(@this.x.Sub(a.x), @this.y.Sub(a.y), @this.z.Sub(a.z), @this.w.Sub(a.w));
        static public Vector4 Mul(this Vector4Int @this, Vector4 a)
        => new(@this.x.Mul(a.x), @this.y.Mul(a.y), @this.z.Mul(a.z), @this.w.Mul(a.w));
        static public Vector4 Div(this Vector4Int @this, Vector4 a)
        => new(@this.x.Div(a.x), @this.y.Div(a.y), @this.z.Div(a.z), @this.w.Div(a.w));
        static public Vector4 Pow(this Vector4Int @this, Vector4 a)
        => new(@this.x.Pow(a.x), @this.y.Pow(a.y), @this.z.Pow(a.z), @this.w.Pow(a.w));
        static public Vector4 Root(this Vector4Int @this, Vector4 a)
        => new(@this.x.Root(a.x), @this.y.Root(a.y), @this.z.Root(a.z), @this.w.Root(a.w));
        static public Vector4 Mod(this Vector4Int @this, Vector4 a)
        => new(@this.x.Mod(a.x), @this.y.Mod(a.y), @this.z.Mod(a.z), @this.w.Mod(a.w));
        static public Vector4 PosMod(this Vector4Int @this, Vector4 a)
        => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y), @this.z.PosMod(a.z), @this.w.PosMod(a.w));
        static public Vector4 Min(this Vector4Int @this, Vector4 a)
        => new(@this.x.Min(a.x), @this.y.Min(a.y), @this.z.Min(a.z), @this.w.Min(a.w));
        static public Vector4 Max(this Vector4Int @this, Vector4 a)
        => new(@this.x.Max(a.x), @this.y.Max(a.y), @this.z.Max(a.z), @this.w.Max(a.w));
        static public Vector4 Avg(this Vector4Int @this, Vector4 a)
        => new(@this.x.Avg(a.x), @this.y.Avg(a.y), @this.z.Avg(a.z), @this.w.Avg(a.w));

        static public Vector4 Add(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Add(x), @this.y.Add(y), @this.z.Add(z), @this.w.Add(w));
        static public Vector4 Sub(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Sub(x), @this.y.Sub(y), @this.z.Sub(z), @this.w.Sub(w));
        static public Vector4 Mul(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Mul(x), @this.y.Mul(y), @this.z.Mul(z), @this.w.Mul(w));
        static public Vector4 Div(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Div(x), @this.y.Div(y), @this.z.Div(z), @this.w.Div(w));
        static public Vector4 Pow(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Pow(x), @this.y.Pow(y), @this.z.Pow(z), @this.w.Pow(w));
        static public Vector4 Root(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Root(x), @this.y.Root(y), @this.z.Root(z), @this.w.Root(w));
        static public Vector4 Mod(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Mod(x), @this.y.Mod(y), @this.z.Mod(z), @this.w.Mod(w));
        static public Vector4 PosMod(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.PosMod(x), @this.y.PosMod(y), @this.z.PosMod(z), @this.w.PosMod(w));
        static public Vector4 Min(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Min(x), @this.y.Min(y), @this.z.Min(z), @this.w.Min(w));
        static public Vector4 Max(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Max(x), @this.y.Max(y), @this.z.Max(z), @this.w.Max(w));
        static public Vector4 Avg(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.Avg(x), @this.y.Avg(y), @this.z.Avg(z), @this.w.Avg(w));

        static public Vector4 Add(this Vector4Int @this, float a)
        => new(@this.x.Add(a), @this.y.Add(a), @this.z.Add(a), @this.w.Add(a));
        static public Vector4 Sub(this Vector4Int @this, float a)
        => new(@this.x.Sub(a), @this.y.Sub(a), @this.z.Sub(a), @this.w.Sub(a));
        static public Vector4 Mul(this Vector4Int @this, float a)
        => new(@this.x.Mul(a), @this.y.Mul(a), @this.z.Mul(a), @this.w.Mul(a));
        static public Vector4 Div(this Vector4Int @this, float a)
        => new(@this.x.Div(a), @this.y.Div(a), @this.z.Div(a), @this.w.Div(a));
        static public Vector4 Pow(this Vector4Int @this, float a)
        => new(@this.x.Pow(a), @this.y.Pow(a), @this.z.Pow(a), @this.w.Pow(a));
        static public Vector4 Root(this Vector4Int @this, float a)
        => new(@this.x.Root(a), @this.y.Root(a), @this.z.Root(a), @this.w.Root(a));
        static public Vector4 Mod(this Vector4Int @this, float a)
        => new(@this.x.Mod(a), @this.y.Mod(a), @this.z.Mod(a), @this.w.Mod(a));
        static public Vector4 PosMod(this Vector4Int @this, float a)
        => new(@this.x.PosMod(a), @this.y.PosMod(a), @this.z.PosMod(a), @this.w.PosMod(a));
        static public Vector4 Min(this Vector4Int @this, float a)
        => new(@this.x.Min(a), @this.y.Min(a), @this.z.Min(a), @this.w.Min(a));
        static public Vector4 Max(this Vector4Int @this, float a)
        => new(@this.x.Max(a), @this.y.Max(a), @this.z.Max(a), @this.w.Max(a));
        static public Vector4 Avg(this Vector4Int @this, float a)
        => new(@this.x.Avg(a), @this.y.Avg(a), @this.z.Avg(a), @this.w.Avg(a));

        static public Vector4Int Add(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Add(a.x), @this.y.Add(a.y), @this.z.Add(a.z), @this.w.Add(a.w));
        static public Vector4Int Sub(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Sub(a.x), @this.y.Sub(a.y), @this.z.Sub(a.z), @this.w.Sub(a.w));
        static public Vector4Int Mul(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Mul(a.x), @this.y.Mul(a.y), @this.z.Mul(a.z), @this.w.Mul(a.w));
        static public Vector4Int Div(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Div(a.x), @this.y.Div(a.y), @this.z.Div(a.z), @this.w.Div(a.w));
        static public Vector4Int Pow(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Pow(a.x), @this.y.Pow(a.y), @this.z.Pow(a.z), @this.w.Pow(a.w));
        static public Vector4 Root(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Root(a.x), @this.y.Root(a.y), @this.z.Root(a.z), @this.w.Root(a.w));
        static public Vector4Int Mod(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Mod(a.x), @this.y.Mod(a.y), @this.z.Mod(a.z), @this.w.Mod(a.w));
        static public Vector4Int PosMod(this Vector4Int @this, Vector4Int a)
        => new(@this.x.PosMod(a.x), @this.y.PosMod(a.y), @this.z.PosMod(a.z), @this.w.PosMod(a.w));
        static public Vector4Int Min(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Min(a.x), @this.y.Min(a.y), @this.z.Min(a.z), @this.w.Min(a.w));
        static public Vector4Int Max(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Max(a.x), @this.y.Max(a.y), @this.z.Max(a.z), @this.w.Max(a.w));
        static public Vector4 Avg(this Vector4Int @this, Vector4Int a)
        => new(@this.x.Avg(a.x), @this.y.Avg(a.y), @this.z.Avg(a.z), @this.w.Avg(a.w));

        static public Vector4Int Add(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Add(x), @this.y.Add(y), @this.z.Add(z), @this.w.Add(w));
        static public Vector4Int Sub(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Sub(x), @this.y.Sub(y), @this.z.Sub(z), @this.w.Sub(w));
        static public Vector4Int Mul(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Mul(x), @this.y.Mul(y), @this.z.Mul(z), @this.w.Mul(w));
        static public Vector4Int Div(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Div(x), @this.y.Div(y), @this.z.Div(z), @this.w.Div(w));
        static public Vector4Int Pow(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Pow(x), @this.y.Pow(y), @this.z.Pow(z), @this.w.Pow(w));
        static public Vector4 Root(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Root(x), @this.y.Root(y), @this.z.Root(z), @this.w.Root(w));
        static public Vector4Int Mod(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Mod(x), @this.y.Mod(y), @this.z.Mod(z), @this.w.Mod(w));
        static public Vector4Int PosMod(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.PosMod(x), @this.y.PosMod(y), @this.z.PosMod(z), @this.w.PosMod(w));
        static public Vector4Int Min(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Min(x), @this.y.Min(y), @this.z.Min(z), @this.w.Min(w));
        static public Vector4Int Max(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Max(x), @this.y.Max(y), @this.z.Max(z), @this.w.Max(w));
        static public Vector4 Avg(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.Avg(x), @this.y.Avg(y), @this.z.Avg(z), @this.w.Avg(w));

        static public Vector4Int Add(this Vector4Int @this, int a)
        => new(@this.x.Add(a), @this.y.Add(a), @this.z.Add(a), @this.w.Add(a));
        static public Vector4Int Sub(this Vector4Int @this, int a)
        => new(@this.x.Sub(a), @this.y.Sub(a), @this.z.Sub(a), @this.w.Sub(a));
        static public Vector4Int Mul(this Vector4Int @this, int a)
        => new(@this.x.Mul(a), @this.y.Mul(a), @this.z.Mul(a), @this.w.Mul(a));
        static public Vector4Int Div(this Vector4Int @this, int a)
        => new(@this.x.Div(a), @this.y.Div(a), @this.z.Div(a), @this.w.Div(a));
        static public Vector4Int Pow(this Vector4Int @this, int a)
        => new(@this.x.Pow(a), @this.y.Pow(a), @this.z.Pow(a), @this.w.Pow(a));
        static public Vector4 Root(this Vector4Int @this, int a)
        => new(@this.x.Root(a), @this.y.Root(a), @this.z.Root(a), @this.w.Root(a));
        static public Vector4Int Mod(this Vector4Int @this, int a)
        => new(@this.x.Mod(a), @this.y.Mod(a), @this.z.Mod(a), @this.w.Mod(a));
        static public Vector4Int PosMod(this Vector4Int @this, int a)
        => new(@this.x.PosMod(a), @this.y.PosMod(a), @this.z.PosMod(a), @this.w.PosMod(a));
        static public Vector4Int Min(this Vector4Int @this, int a)
        => new(@this.x.Min(a), @this.y.Min(a), @this.z.Min(a), @this.w.Min(a));
        static public Vector4Int Max(this Vector4Int @this, int a)
        => new(@this.x.Max(a), @this.y.Max(a), @this.z.Max(a), @this.w.Max(a));
        static public Vector4 Avg(this Vector4Int @this, int a)
        => new(@this.x.Avg(a), @this.y.Avg(a), @this.z.Avg(a), @this.w.Avg(a));

        // Unary
        static public Vector4Int Neg(this Vector4Int @this)
        => new(@this.x.Neg(), @this.y.Neg(), @this.z.Neg(), @this.w.Neg());
        static public Vector4 Inv(this Vector4Int @this)
        => new(@this.x.Inv(), @this.y.Inv(), @this.z.Inv(), @this.w.Inv());
        static public Vector4Int Abs(this Vector4Int @this)
        => new(@this.x.Abs(), @this.y.Abs(), @this.z.Abs(), @this.w.Abs());
        static public Vector4Int Sig(this Vector4Int @this)
        => new(@this.x.Sig(), @this.y.Sig(), @this.z.Sig(), @this.w.Sig());
        static public Vector4Int Sqrd(this Vector4Int @this)
        => new(@this.x.Sqrd(), @this.y.Sqrd(), @this.z.Sqrd(), @this.w.Sqrd());
        static public Vector4 Sqrt(this Vector4Int @this)
        => new(@this.x.Sqrt(), @this.y.Sqrt(), @this.z.Sqrt(), @this.w.Sqrt());

        // Trig
        static public Vector4 Sin(this Vector4Int @this)
        => new(@this.x.Sin(), @this.y.Sin(), @this.z.Sin(), @this.w.Sin());
        static public Vector4 Cos(this Vector4Int @this)
        => new(@this.x.Cos(), @this.y.Cos(), @this.z.Cos(), @this.w.Cos());
        static public Vector4 Tan(this Vector4Int @this)
        => new(@this.x.Tan(), @this.y.Tan(), @this.z.Tan(), @this.w.Tan());
        static public Vector4 Cot(this Vector4Int @this)
        => new(@this.x.Cot(), @this.y.Cot(), @this.z.Cot(), @this.w.Cot());
        static public Vector4 Sec(this Vector4Int @this)
        => new(@this.x.Sec(), @this.y.Sec(), @this.z.Sec(), @this.w.Sec());
        static public Vector4 Csc(this Vector4Int @this)
        => new(@this.x.Csc(), @this.y.Csc(), @this.z.Csc(), @this.w.Csc());
        static public Vector4 ArcSin(this Vector4Int @this)
        => new(@this.x.ArcSin(), @this.y.ArcSin(), @this.z.ArcSin(), @this.w.ArcSin());
        static public Vector4 ArcCos(this Vector4Int @this)
        => new(@this.x.ArcCos(), @this.y.ArcCos(), @this.z.ArcCos(), @this.w.ArcCos());
        static public Vector4 ArcTan(this Vector4Int @this)
        => new(@this.x.ArcTan(), @this.y.ArcTan(), @this.z.ArcTan(), @this.w.ArcTan());

        // Round
        static public Vector4 RoundToMultiple(this Vector4Int @this, Vector4 a)
        => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y), @this.z.RoundToMultiple(a.z), @this.w.RoundToMultiple(a.w));
        static public Vector4 RoundToMultiple(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y), @this.z.RoundToMultiple(z), @this.w.RoundToMultiple(w));
        static public Vector4 RoundToMultiple(this Vector4Int @this, float a)
        => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a), @this.z.RoundToMultiple(a), @this.w.RoundToMultiple(a));

        static public Vector4Int RoundToMultiple(this Vector4Int @this, Vector4Int a)
        => new(@this.x.RoundToMultiple(a.x), @this.y.RoundToMultiple(a.y), @this.z.RoundToMultiple(a.z), @this.w.RoundToMultiple(a.w));
        static public Vector4Int RoundToMultiple(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.RoundToMultiple(x), @this.y.RoundToMultiple(y), @this.z.RoundToMultiple(z), @this.w.RoundToMultiple(w));
        static public Vector4Int RoundToMultiple(this Vector4Int @this, int a)
        => new(@this.x.RoundToMultiple(a), @this.y.RoundToMultiple(a), @this.z.RoundToMultiple(a), @this.w.RoundToMultiple(a));

        // Clamp
        static public Vector4 Clamp01(this Vector4Int @this)
        => new(@this.x.Clamp01(), @this.y.Clamp01(), @this.z.Clamp01(), @this.w.Clamp01());

        static public Vector4 Clamp(this Vector4Int @this, Vector4 a, Vector4 b)
        => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y), @this.z.Clamp(a.z, b.z), @this.w.Clamp(a.w, b.w));
        static public Vector4 ClampMin(this Vector4Int @this, Vector4 a)
        => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y), @this.z.ClampMin(a.z), @this.w.ClampMin(a.w));
        static public Vector4 ClampMax(this Vector4Int @this, Vector4 a)
        => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y), @this.z.ClampMax(a.z), @this.w.ClampMax(a.w));
        static public Vector4 Lerp(this Vector4Int @this, Vector4 a, float b)
        => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b), @this.z.Lerp(a.z, b), @this.w.Lerp(a.w, b));
        static public Vector4 LerpClamped(this Vector4Int @this, Vector4 a, float b)
        => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b), @this.z.LerpClamped(a.z, b), @this.w.LerpClamped(a.w, b));
        static public Vector4 Map(this Vector4Int @this, Vector4 a, Vector4 b, Vector4 c, Vector4 d)
        => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y), @this.z.Map(a.z, b.z, c.z, d.z), @this.w.Map(a.w, b.w, c.w, d.w));
        static public Vector4 MapClamped(this Vector4Int @this, Vector4 a, Vector4 b, Vector4 c, Vector4 d)
        => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y), @this.z.MapClamped(a.z, b.z, c.z, d.z), @this.w.MapClamped(a.w, b.w, c.w, d.w));

        static public Vector4 Clamp(this Vector4Int @this, float ax, float ay, float az, float aw, float bx, float by, float bz, float bw)
        => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by), @this.z.Clamp(az, bz), @this.w.Clamp(aw, bw));
        static public Vector4 ClampMin(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.ClampMin(x), @this.y.ClampMin(y), @this.z.ClampMin(z), @this.w.ClampMin(w));
        static public Vector4 ClampMax(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.ClampMax(x), @this.y.ClampMax(y), @this.z.ClampMax(z), @this.w.ClampMax(w));
        static public Vector4 Lerp(this Vector4Int @this, float x, float y, float z, float w, float b)
        => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b), @this.z.Lerp(z, b), @this.w.Lerp(w, b));
        static public Vector4 LerpClamped(this Vector4Int @this, float x, float y, float z, float w, float b)
        => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b), @this.z.LerpClamped(z, b), @this.w.LerpClamped(w, b));
        static public Vector4 Map(this Vector4Int @this, float ax, float ay, float az, float aw, float bx, float by, float bz, float bw, float cx, float cy, float cz, float cw, float dx, float dy, float dz, float dw)
        => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy), @this.z.Map(az, bz, cz, dz), @this.w.Map(aw, bw, cw, dw));
        static public Vector4 MapClamped(this Vector4Int @this, float ax, float ay, float az, float aw, float bx, float by, float bz, float bw, float cx, float cy, float cz, float cw, float dx, float dy, float dz, float dw)
        => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy), @this.z.MapClamped(az, bz, cz, dz), @this.w.MapClamped(aw, bw, cw, dw));

        static public Vector4 Clamp(this Vector4Int @this, float a, float b)
        => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b), @this.z.Clamp(a, b), @this.w.Clamp(a, b));
        static public Vector4 ClampMin(this Vector4Int @this, float a)
        => new(@this.x.ClampMin(a), @this.y.ClampMin(a), @this.z.ClampMin(a), @this.w.ClampMin(a));
        static public Vector4 ClampMax(this Vector4Int @this, float a)
        => new(@this.x.ClampMax(a), @this.y.ClampMax(a), @this.z.ClampMax(a), @this.w.ClampMax(a));
        static public Vector4 Lerp(this Vector4Int @this, float a, float b)
        => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b), @this.z.Lerp(a, b), @this.w.Lerp(a, b));
        static public Vector4 LerpClamped(this Vector4Int @this, float a, float b)
        => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b), @this.z.LerpClamped(a, b), @this.w.LerpClamped(a, b));
        static public Vector4 Map(this Vector4Int @this, float a, float b, float c, float d)
        => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d), @this.z.Map(a, b, c, d), @this.w.Map(a, b, c, d));
        static public Vector4 MapClamped(this Vector4Int @this, float a, float b, float c, float d)
         => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d), @this.z.MapClamped(a, b, c, d), @this.w.MapClamped(a, b, c, d));

        static public Vector4Int Clamp(this Vector4Int @this, Vector4Int a, Vector4Int b)
        => new(@this.x.Clamp(a.x, b.x), @this.y.Clamp(a.y, b.y), @this.z.Clamp(a.z, b.z), @this.w.Clamp(a.w, b.w));
        static public Vector4Int ClampMin(this Vector4Int @this, Vector4Int a)
        => new(@this.x.ClampMin(a.x), @this.y.ClampMin(a.y), @this.z.ClampMin(a.z), @this.w.ClampMin(a.w));
        static public Vector4Int ClampMax(this Vector4Int @this, Vector4Int a)
        => new(@this.x.ClampMax(a.x), @this.y.ClampMax(a.y), @this.z.ClampMax(a.z), @this.w.ClampMax(a.w));
        static public Vector4 Lerp(this Vector4Int @this, Vector4Int a, float b)
        => new(@this.x.Lerp(a.x, b), @this.y.Lerp(a.y, b), @this.z.Lerp(a.z, b), @this.w.Lerp(a.w, b));
        static public Vector4 LerpClamped(this Vector4Int @this, Vector4Int a, float b)
        => new(@this.x.LerpClamped(a.x, b), @this.y.LerpClamped(a.y, b), @this.z.LerpClamped(a.z, b), @this.w.LerpClamped(a.w, b));
        static public Vector4 Map(this Vector4Int @this, Vector4Int a, Vector4Int b, Vector4Int c, Vector4Int d)
        => new(@this.x.Map(a.x, b.x, c.x, d.x), @this.y.Map(a.y, b.y, c.y, d.y), @this.z.Map(a.z, b.z, c.z, d.z), @this.w.Map(a.w, b.w, c.w, d.w));
        static public Vector4 MapClamped(this Vector4Int @this, Vector4Int a, Vector4Int b, Vector4Int c, Vector4Int d)
        => new(@this.x.MapClamped(a.x, b.x, c.x, d.x), @this.y.MapClamped(a.y, b.y, c.y, d.y), @this.z.MapClamped(a.z, b.z, c.z, d.z), @this.w.MapClamped(a.w, b.w, c.w, d.w));

        static public Vector4Int Clamp(this Vector4Int @this, int ax, int ay, int az, int aw, int bx, int by, int bz, int bw)
        => new(@this.x.Clamp(ax, bx), @this.y.Clamp(ay, by), @this.z.Clamp(az, bz), @this.w.Clamp(aw, bw));
        static public Vector4Int ClampMin(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.ClampMin(x), @this.y.ClampMin(y), @this.z.ClampMin(z), @this.w.ClampMin(w));
        static public Vector4Int ClampMax(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.ClampMax(x), @this.y.ClampMax(y), @this.z.ClampMax(z), @this.w.ClampMax(w));
        static public Vector4 Lerp(this Vector4Int @this, int x, int y, int z, int w, float b)
        => new(@this.x.Lerp(x, b), @this.y.Lerp(y, b), @this.z.Lerp(z, b), @this.w.Lerp(w, b));
        static public Vector4 LerpClamped(this Vector4Int @this, int x, int y, int z, int w, float b)
        => new(@this.x.LerpClamped(x, b), @this.y.LerpClamped(y, b), @this.z.LerpClamped(z, b), @this.w.LerpClamped(w, b));
        static public Vector4 Map(this Vector4Int @this, int ax, int ay, int az, int aw, int bx, int by, int bz, int bw, int cx, int cy, int cz, int cw, int dx, int dy, int dz, int dw)
        => new(@this.x.Map(ax, bx, cx, dx), @this.y.Map(ay, by, cy, dy), @this.z.Map(az, bz, cz, dz), @this.w.Map(aw, bw, cw, dw));
        static public Vector4 MapClamped(this Vector4Int @this, int ax, int ay, int az, int aw, int bx, int by, int bz, int bw, int cx, int cy, int cz, int cw, int dx, int dy, int dz, int dw)
        => new(@this.x.MapClamped(ax, bx, cx, dx), @this.y.MapClamped(ay, by, cy, dy), @this.z.MapClamped(az, bz, cz, dz), @this.w.MapClamped(aw, bw, cw, dw));

        static public Vector4Int Clamp(this Vector4Int @this, int a, int b)
        => new(@this.x.Clamp(a, b), @this.y.Clamp(a, b), @this.z.Clamp(a, b), @this.w.Clamp(a, b));
        static public Vector4Int ClampMin(this Vector4Int @this, int a)
        => new(@this.x.ClampMin(a), @this.y.ClampMin(a), @this.z.ClampMin(a), @this.w.ClampMin(a));
        static public Vector4Int ClampMax(this Vector4Int @this, int a)
        => new(@this.x.ClampMax(a), @this.y.ClampMax(a), @this.z.ClampMax(a), @this.w.ClampMax(a));
        static public Vector4 Lerp(this Vector4Int @this, int a, float b)
        => new(@this.x.Lerp(a, b), @this.y.Lerp(a, b), @this.z.Lerp(a, b), @this.w.Lerp(a, b));
        static public Vector4 LerpClamped(this Vector4Int @this, int a, float b)
        => new(@this.x.LerpClamped(a, b), @this.y.LerpClamped(a, b), @this.z.LerpClamped(a, b), @this.w.LerpClamped(a, b));
        static public Vector4 Map(this Vector4Int @this, int a, int b, int c, int d)
        => new(@this.x.Map(a, b, c, d), @this.y.Map(a, b, c, d), @this.z.Map(a, b, c, d), @this.w.Map(a, b, c, d));
        static public Vector4 MapClamped(this Vector4Int @this, int a, int b, int c, int d)
         => new(@this.x.MapClamped(a, b, c, d), @this.y.MapClamped(a, b, c, d), @this.z.MapClamped(a, b, c, d), @this.w.MapClamped(a, b, c, d));

        // Spatial
        static public float Dot(this Vector4Int @this, Vector4 a)
        => @this.x * a.x + @this.y * a.y + @this.z * a.z + @this.w * a.w;
        static public float DistanceTo(this Vector4Int @this, Vector4 a)
        => (a - @this).magnitude;
        static public Vector4 OffsetTo(this Vector4Int @this, Vector4 a)
        => (a - @this);
        static public Vector4 OffsetFrom(this Vector4Int @this, Vector4 a)
        => (@this - a);
        static public Vector4 DirectionTowards(this Vector4Int @this, Vector4 a)
        => (a - @this).normalized;
        static public Vector4 DirectionAwayFrom(this Vector4Int @this, Vector4 a)
        => (@this - a).normalized;

        static public float Dot(this Vector4Int @this, float x, float y, float z, float w)
        => @this.x * x + @this.y * y + @this.z * z + @this.w * w;
        static public float DistanceTo(this Vector4Int @this, float x, float y, float z, float w)
        => new Vector4(x - @this.x, y - @this.y, z - @this.z).magnitude;
        static public Vector4 OffsetTo(this Vector4Int @this, float x, float y, float z, float w)
        => new(x - @this.x, y - @this.y, z - @this.z);
        static public Vector4 OffsetFrom(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x - x, @this.y - y, @this.z - z);
        static public Vector4 DirectionTowards(this Vector4Int @this, float x, float y, float z, float w)
        => new Vector4(x - @this.x, y - @this.y, z - @this.z).normalized;
        static public Vector4 DirectionAwayFrom(this Vector4Int @this, float x, float y, float z, float w)
        => new Vector4(@this.x - x, @this.y - y, @this.z - z).normalized;

        static public int Dot(this Vector4Int @this, Vector4Int a)
        => @this.x * a.x + @this.y * a.y + @this.z * a.z + @this.w * a.w;
        static public float DistanceTo(this Vector4Int @this, Vector4Int a)
        => (a - @this).magnitude;
        static public Vector4 OffsetTo(this Vector4Int @this, Vector4Int a)
        => (a - @this);
        static public Vector4 OffsetFrom(this Vector4Int @this, Vector4Int a)
        => (@this - a);
        static public Vector4 DirectionTowards(this Vector4Int @this, Vector4Int a)
        => (a - @this).normalized;
        static public Vector4 DirectionAwayFrom(this Vector4Int @this, Vector4Int a)
        => (@this - a).normalized;

        static public int Dot(this Vector4Int @this, int x, int y, int z, int w)
        => @this.x * x + @this.y * y + @this.z * z + @this.w * w;
        static public float DistanceTo(this Vector4Int @this, int x, int y, int z, int w)
        => new Vector4(x - @this.x, y - @this.y, z - @this.z).magnitude;
        static public Vector4 OffsetTo(this Vector4Int @this, int x, int y, int z, int w)
        => new(x - @this.x, y - @this.y, z - @this.z);
        static public Vector4 OffsetFrom(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x - x, @this.y - y, @this.z - z);
        static public Vector4 DirectionTowards(this Vector4Int @this, int x, int y, int z, int w)
        => new Vector4(x - @this.x, y - @this.y, z - @this.z).normalized;
        static public Vector4 DirectionAwayFrom(this Vector4Int @this, int x, int y, int z, int w)
        => new Vector4(@this.x - x, @this.y - y, @this.z - z).normalized;

        // Comps
        static public IEnumerable<int> Comps(this Vector4Int @this)
        {
            yield return @this.x;
            yield return @this.y;
            yield return @this.z;
            yield return @this.w;
        }
        static public int CompSum(this Vector4Int @this)
        => @this.x + @this.y + @this.z + @this.w;
        static public int CompProduct(this Vector4Int @this)
        => @this.x * @this.y * @this.z * @this.w;
        static public int CompMin(this Vector4Int @this)
        => Mathf.Min(@this.x, @this.y, @this.z, @this.w);
        static public int CompMax(this Vector4Int @this)
        => Mathf.Max(@this.x, @this.y, @this.z, @this.w);
        static public float CompAvg(this Vector4Int @this)
        => (@this.x + @this.y + @this.z + @this.w) / 4f;
        static public bool Any(this Vector4Int @this, Func<int, bool> test)
        => test(@this.x) || test(@this.y) || test(@this.z) || test(@this.w);
        static public bool All(this Vector4Int @this, Func<int, bool> test)
        => test(@this.x) && test(@this.y) && test(@this.z) && test(@this.w);

        static public Vector4 CompDistanceTo(this Vector4Int @this, Vector4 a)
        => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y), @this.z.DistanceTo(a.z), @this.w.DistanceTo(a.w));
        static public Vector4 CompDistanceTo(this Vector4Int @this, float x, float y, float z, float w)
        => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y), @this.z.DistanceTo(z), @this.w.DistanceTo(w));
        static public Vector4 CompDistanceTo(this Vector4Int @this, float a)
        => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a), @this.z.DistanceTo(a), @this.w.DistanceTo(a));

        static public Vector4 CompDistanceTo(this Vector4Int @this, Vector4Int a)
        => new(@this.x.DistanceTo(a.x), @this.y.DistanceTo(a.y), @this.z.DistanceTo(a.z), @this.w.DistanceTo(a.w));
        static public Vector4 CompDistanceTo(this Vector4Int @this, int x, int y, int z, int w)
        => new(@this.x.DistanceTo(x), @this.y.DistanceTo(y), @this.z.DistanceTo(z), @this.w.DistanceTo(w));
        static public Vector4 CompDistanceTo(this Vector4Int @this, int a)
        => new(@this.x.DistanceTo(a), @this.y.DistanceTo(a), @this.z.DistanceTo(a), @this.w.DistanceTo(a));

        // Conversions
        static public Vector2Int ToVector2Int(this Vector4Int @this)
        => new((int)@this.x, (int)@this.y);
        static public Vector3Int ToVector3Int(this Vector4Int @this)
        => new((int)@this.x, (int)@this.y, (int)@this.z);
        static public Vector4Int ToVector4Int(this Vector4Int @this)
        => new((int)@this.x, (int)@this.y, (int)@this.z, (int)@this.w);

        // XYZW
        #region XYZW
        static public Vector4 NewX(this Vector4Int @this, float x)
        => new(x, @this.y, @this.z, @this.w);
        static public Vector4 NewY(this Vector4Int @this, float y)
        => new(@this.x, y, @this.z, @this.w);
        static public Vector4 NewZ(this Vector4Int @this, float z)
        => new(@this.x, @this.y, z, @this.w);
        static public Vector4 NewW(this Vector4Int @this, float w)
        => new(@this.x, @this.y, @this.z, w);

        static public Vector4 NewXY(this Vector4Int @this, float x, float y)
        => new(x, y, @this.z, @this.w);
        static public Vector4 NewXZ(this Vector4Int @this, float x, float z)
        => new(x, @this.y, z, @this.w);
        static public Vector4 NewXW(this Vector4Int @this, float x, float w)
        => new(x, @this.y, @this.z, w);
        static public Vector4 NewYX(this Vector4Int @this, float y, float x)
        => new(x, y, @this.z, @this.w);
        static public Vector4 NewYZ(this Vector4Int @this, float y, float z)
        => new(@this.x, y, z, @this.w);
        static public Vector4 NewYW(this Vector4Int @this, float y, float w)
        => new(@this.x, y, @this.z, w);
        static public Vector4 NewZX(this Vector4Int @this, float z, float x)
        => new(x, @this.y, z, @this.w);
        static public Vector4 NewZY(this Vector4Int @this, float z, float y)
        => new(@this.x, y, z, @this.w);
        static public Vector4 NewZW(this Vector4Int @this, float z, float w)
        => new(@this.x, @this.y, z, w);
        static public Vector4 NewWX(this Vector4Int @this, float w, float x)
        => new(x, @this.y, @this.z, w);
        static public Vector4 NewWY(this Vector4Int @this, float w, float y)
        => new(@this.x, y, @this.z, w);
        static public Vector4 NewWZ(this Vector4Int @this, float w, float z)
        => new(@this.x, @this.y, z, w);

        static public Vector4 NewXYZ(this Vector4Int @this, float x, float y, float z)
        => new(x, y, z, @this.w);
        static public Vector4 NewXYW(this Vector4Int @this, float x, float y, float w)
        => new(x, y, @this.z, w);
        static public Vector4 NewXZY(this Vector4Int @this, float x, float z, float y)
        => new(x, y, z, @this.w);
        static public Vector4 NewXZW(this Vector4Int @this, float x, float z, float w)
        => new(x, @this.y, z, w);
        static public Vector4 NewXWY(this Vector4Int @this, float x, float w, float y)
        => new(x, y, @this.z, w);
        static public Vector4 NewXWZ(this Vector4Int @this, float x, float w, float z)
        => new(x, @this.y, z, w);

        static public Vector4 NewYXZ(this Vector4Int @this, float y, float x, float z)
        => new(x, y, z, @this.w);
        static public Vector4 NewYXW(this Vector4Int @this, float y, float x, float w)
        => new(x, y, @this.z, w);
        static public Vector4 NewYZX(this Vector4Int @this, float y, float z, float x)
        => new(x, y, z, @this.w);
        static public Vector4 NewYZW(this Vector4Int @this, float y, float z, float w)
        => new(@this.x, y, z, w);
        static public Vector4 NewYWX(this Vector4Int @this, float y, float w, float x)
        => new(x, y, @this.z, w);
        static public Vector4 NewYWZ(this Vector4Int @this, float y, float w, float z)
        => new(@this.x, y, z, w);

        static public Vector4 NewZXY(this Vector4Int @this, float z, float x, float y)
        => new(x, y, z, @this.w);
        static public Vector4 NewZXW(this Vector4Int @this, float z, float x, float w)
        => new(x, @this.y, z, w);
        static public Vector4 NewZYX(this Vector4Int @this, float z, float y, float x)
        => new(x, y, z, @this.w);
        static public Vector4 NewZYW(this Vector4Int @this, float z, float y, float w)
        => new(@this.x, y, z, w);
        static public Vector4 NewZWX(this Vector4Int @this, float z, float w, float x)
        => new(x, @this.y, z, w);
        static public Vector4 NewZWY(this Vector4Int @this, float z, float w, float y)
        => new(@this.x, y, z, w);

        static public Vector4 NewWXY(this Vector4Int @this, float w, float x, float y)
        => new(x, y, @this.z, w);
        static public Vector4 NewWXZ(this Vector4Int @this, float w, float x, float z)
        => new(x, @this.y, z, w);
        static public Vector4 NewWYX(this Vector4Int @this, float w, float y, float x)
        => new(x, y, @this.z, w);
        static public Vector4 NewWYZ(this Vector4Int @this, float w, float y, float z)
        => new(@this.x, y, z, w);
        static public Vector4 NewWZX(this Vector4Int @this, float w, float z, float x)
        => new(x, @this.y, z, w);
        static public Vector4 NewWZY(this Vector4Int @this, float w, float z, float y)
        => new(@this.x, y, z, w);

        static public Vector2 XX(this Vector4Int @this)
        => new(@this.x, @this.x);
        static public Vector2 XY(this Vector4Int @this)
        => new(@this.x, @this.y);
        static public Vector2 XZ(this Vector4Int @this)
        => new(@this.x, @this.z);
        static public Vector2 XW(this Vector4Int @this)
        => new(@this.x, @this.w);
        static public Vector2 YX(this Vector4Int @this)
        => new(@this.y, @this.x);
        static public Vector2 YY(this Vector4Int @this)
        => new(@this.y, @this.y);
        static public Vector2 YZ(this Vector4Int @this)
        => new(@this.y, @this.z);
        static public Vector2 YW(this Vector4Int @this)
        => new(@this.y, @this.w);
        static public Vector2 ZX(this Vector4Int @this)
        => new(@this.z, @this.x);
        static public Vector2 ZY(this Vector4Int @this)
        => new(@this.z, @this.y);
        static public Vector2 ZZ(this Vector4Int @this)
        => new(@this.z, @this.z);
        static public Vector2 ZW(this Vector4Int @this)
        => new(@this.z, @this.w);
        static public Vector2 WX(this Vector4Int @this)
        => new(@this.w, @this.x);
        static public Vector2 WY(this Vector4Int @this)
        => new(@this.w, @this.y);
        static public Vector2 WZ(this Vector4Int @this)
        => new(@this.w, @this.z);
        static public Vector2 WW(this Vector4Int @this)
        => new(@this.w, @this.w);

        static public Vector3 XXX(this Vector4Int @this)
        => new(@this.x, @this.x, @this.x);
        static public Vector3 XXY(this Vector4Int @this)
        => new(@this.x, @this.x, @this.y);
        static public Vector3 XXZ(this Vector4Int @this)
        => new(@this.x, @this.x, @this.z);
        static public Vector3 XXW(this Vector4Int @this)
        => new(@this.x, @this.x, @this.w);
        static public Vector3 XYX(this Vector4Int @this)
        => new(@this.x, @this.y, @this.x);
        static public Vector3 XYY(this Vector4Int @this)
        => new(@this.x, @this.y, @this.y);
        static public Vector3 XYZ(this Vector4Int @this)
        => new(@this.x, @this.y, @this.z);
        static public Vector3 XYW(this Vector4Int @this)
        => new(@this.x, @this.y, @this.w);
        static public Vector3 XZX(this Vector4Int @this)
        => new(@this.x, @this.z, @this.x);
        static public Vector3 XZY(this Vector4Int @this)
        => new(@this.x, @this.z, @this.y);
        static public Vector3 XZZ(this Vector4Int @this)
        => new(@this.x, @this.z, @this.z);
        static public Vector3 XZW(this Vector4Int @this)
        => new(@this.x, @this.z, @this.w);
        static public Vector3 XWX(this Vector4Int @this)
        => new(@this.x, @this.w, @this.x);
        static public Vector3 XWY(this Vector4Int @this)
        => new(@this.x, @this.w, @this.y);
        static public Vector3 XWZ(this Vector4Int @this)
        => new(@this.x, @this.w, @this.z);
        static public Vector3 XWW(this Vector4Int @this)
        => new(@this.x, @this.w, @this.w);

        static public Vector3 YXX(this Vector4Int @this)
        => new(@this.y, @this.x, @this.x);
        static public Vector3 YXY(this Vector4Int @this)
        => new(@this.y, @this.x, @this.y);
        static public Vector3 YXZ(this Vector4Int @this)
        => new(@this.y, @this.x, @this.z);
        static public Vector3 YXW(this Vector4Int @this)
        => new(@this.y, @this.x, @this.w);
        static public Vector3 YYX(this Vector4Int @this)
        => new(@this.y, @this.y, @this.x);
        static public Vector3 YYY(this Vector4Int @this)
        => new(@this.y, @this.y, @this.y);
        static public Vector3 YYZ(this Vector4Int @this)
        => new(@this.y, @this.y, @this.z);
        static public Vector3 YYW(this Vector4Int @this)
        => new(@this.y, @this.y, @this.w);
        static public Vector3 YZX(this Vector4Int @this)
        => new(@this.y, @this.z, @this.x);
        static public Vector3 YZY(this Vector4Int @this)
        => new(@this.y, @this.z, @this.y);
        static public Vector3 YZZ(this Vector4Int @this)
        => new(@this.y, @this.z, @this.z);
        static public Vector3 YZW(this Vector4Int @this)
        => new(@this.y, @this.z, @this.w);
        static public Vector3 YWX(this Vector4Int @this)
        => new(@this.y, @this.w, @this.x);
        static public Vector3 YWY(this Vector4Int @this)
        => new(@this.y, @this.w, @this.y);
        static public Vector3 YWZ(this Vector4Int @this)
        => new(@this.y, @this.w, @this.z);
        static public Vector3 YWW(this Vector4Int @this)
        => new(@this.y, @this.w, @this.w);

        static public Vector3 ZXX(this Vector4Int @this)
        => new(@this.z, @this.x, @this.x);
        static public Vector3 ZXY(this Vector4Int @this)
        => new(@this.z, @this.x, @this.y);
        static public Vector3 ZXZ(this Vector4Int @this)
        => new(@this.z, @this.x, @this.z);
        static public Vector3 ZXW(this Vector4Int @this)
        => new(@this.z, @this.x, @this.w);
        static public Vector3 ZYX(this Vector4Int @this)
        => new(@this.z, @this.y, @this.x);
        static public Vector3 ZYY(this Vector4Int @this)
        => new(@this.z, @this.y, @this.y);
        static public Vector3 ZYZ(this Vector4Int @this)
        => new(@this.z, @this.y, @this.z);
        static public Vector3 ZYW(this Vector4Int @this)
        => new(@this.z, @this.y, @this.w);
        static public Vector3 ZZX(this Vector4Int @this)
        => new(@this.z, @this.z, @this.x);
        static public Vector3 ZZY(this Vector4Int @this)
        => new(@this.z, @this.z, @this.y);
        static public Vector3 ZZZ(this Vector4Int @this)
        => new(@this.z, @this.z, @this.z);
        static public Vector3 ZZW(this Vector4Int @this)
        => new(@this.z, @this.z, @this.w);
        static public Vector3 ZWX(this Vector4Int @this)
        => new(@this.z, @this.w, @this.x);
        static public Vector3 ZWY(this Vector4Int @this)
        => new(@this.z, @this.w, @this.y);
        static public Vector3 ZWZ(this Vector4Int @this)
        => new(@this.z, @this.w, @this.z);
        static public Vector3 ZWW(this Vector4Int @this)
        => new(@this.z, @this.w, @this.w);

        static public Vector3 WXX(this Vector4Int @this)
        => new(@this.w, @this.x, @this.x);
        static public Vector3 WXY(this Vector4Int @this)
        => new(@this.w, @this.x, @this.y);
        static public Vector3 WXZ(this Vector4Int @this)
        => new(@this.w, @this.x, @this.z);
        static public Vector3 WXW(this Vector4Int @this)
        => new(@this.w, @this.x, @this.w);
        static public Vector3 WYX(this Vector4Int @this)
        => new(@this.w, @this.y, @this.x);
        static public Vector3 WYY(this Vector4Int @this)
        => new(@this.w, @this.y, @this.y);
        static public Vector3 WYZ(this Vector4Int @this)
        => new(@this.w, @this.y, @this.z);
        static public Vector3 WYW(this Vector4Int @this)
        => new(@this.w, @this.y, @this.w);
        static public Vector3 WZX(this Vector4Int @this)
        => new(@this.w, @this.z, @this.x);
        static public Vector3 WZY(this Vector4Int @this)
        => new(@this.w, @this.z, @this.y);
        static public Vector3 WZZ(this Vector4Int @this)
        => new(@this.w, @this.z, @this.z);
        static public Vector3 WZW(this Vector4Int @this)
        => new(@this.w, @this.z, @this.w);
        static public Vector3 WWX(this Vector4Int @this)
        => new(@this.w, @this.w, @this.x);
        static public Vector3 WWY(this Vector4Int @this)
        => new(@this.w, @this.w, @this.y);
        static public Vector3 WWZ(this Vector4Int @this)
        => new(@this.w, @this.w, @this.z);
        static public Vector3 WWW(this Vector4Int @this)
        => new(@this.w, @this.w, @this.w);

        static public Vector4 XXXX(this Vector4Int @this)
        => new(@this.x, @this.x, @this.x, @this.x);
        static public Vector4 XXXY(this Vector4Int @this)
        => new(@this.x, @this.x, @this.x, @this.y);
        static public Vector4 XXXZ(this Vector4Int @this)
        => new(@this.x, @this.x, @this.x, @this.z);
        static public Vector4 XXXW(this Vector4Int @this)
        => new(@this.x, @this.x, @this.x, @this.w);
        static public Vector4 XXYX(this Vector4Int @this)
        => new(@this.x, @this.x, @this.y, @this.x);
        static public Vector4 XXYY(this Vector4Int @this)
        => new(@this.x, @this.x, @this.y, @this.y);
        static public Vector4 XXYZ(this Vector4Int @this)
        => new(@this.x, @this.x, @this.y, @this.z);
        static public Vector4 XXYW(this Vector4Int @this)
        => new(@this.x, @this.x, @this.y, @this.w);
        static public Vector4 XXZX(this Vector4Int @this)
        => new(@this.x, @this.x, @this.z, @this.x);
        static public Vector4 XXZY(this Vector4Int @this)
        => new(@this.x, @this.x, @this.z, @this.y);
        static public Vector4 XXZZ(this Vector4Int @this)
        => new(@this.x, @this.x, @this.z, @this.z);
        static public Vector4 XXZW(this Vector4Int @this)
        => new(@this.x, @this.x, @this.z, @this.w);
        static public Vector4 XXWX(this Vector4Int @this)
        => new(@this.x, @this.x, @this.w, @this.x);
        static public Vector4 XXWY(this Vector4Int @this)
        => new(@this.x, @this.x, @this.w, @this.y);
        static public Vector4 XXWZ(this Vector4Int @this)
        => new(@this.x, @this.x, @this.w, @this.z);
        static public Vector4 XXWW(this Vector4Int @this)
        => new(@this.x, @this.x, @this.w, @this.w);

        static public Vector4 XYXX(this Vector4Int @this)
        => new(@this.x, @this.y, @this.x, @this.x);
        static public Vector4 XYXY(this Vector4Int @this)
        => new(@this.x, @this.y, @this.x, @this.y);
        static public Vector4 XYXZ(this Vector4Int @this)
        => new(@this.x, @this.y, @this.x, @this.z);
        static public Vector4 XYXW(this Vector4Int @this)
        => new(@this.x, @this.y, @this.x, @this.w);
        static public Vector4 XYYX(this Vector4Int @this)
        => new(@this.x, @this.y, @this.y, @this.x);
        static public Vector4 XYYY(this Vector4Int @this)
        => new(@this.x, @this.y, @this.y, @this.y);
        static public Vector4 XYYZ(this Vector4Int @this)
        => new(@this.x, @this.y, @this.y, @this.z);
        static public Vector4 XYYW(this Vector4Int @this)
        => new(@this.x, @this.y, @this.y, @this.w);
        static public Vector4 XYZX(this Vector4Int @this)
        => new(@this.x, @this.y, @this.z, @this.x);
        static public Vector4 XYZY(this Vector4Int @this)
        => new(@this.x, @this.y, @this.z, @this.y);
        static public Vector4 XYZZ(this Vector4Int @this)
        => new(@this.x, @this.y, @this.z, @this.z);
        static public Vector4 XYZW(this Vector4Int @this)
        => new(@this.x, @this.y, @this.z, @this.w);
        static public Vector4 XYWX(this Vector4Int @this)
        => new(@this.x, @this.y, @this.w, @this.x);
        static public Vector4 XYWY(this Vector4Int @this)
        => new(@this.x, @this.y, @this.w, @this.y);
        static public Vector4 XYWZ(this Vector4Int @this)
        => new(@this.x, @this.y, @this.w, @this.z);
        static public Vector4 XYWW(this Vector4Int @this)
        => new(@this.x, @this.y, @this.w, @this.w);

        static public Vector4 XZXX(this Vector4Int @this)
        => new(@this.x, @this.z, @this.x, @this.x);
        static public Vector4 XZXY(this Vector4Int @this)
        => new(@this.x, @this.z, @this.x, @this.y);
        static public Vector4 XZXZ(this Vector4Int @this)
        => new(@this.x, @this.z, @this.x, @this.z);
        static public Vector4 XZXW(this Vector4Int @this)
        => new(@this.x, @this.z, @this.x, @this.w);
        static public Vector4 XZYX(this Vector4Int @this)
        => new(@this.x, @this.z, @this.y, @this.x);
        static public Vector4 XZYY(this Vector4Int @this)
        => new(@this.x, @this.z, @this.y, @this.y);
        static public Vector4 XZYZ(this Vector4Int @this)
        => new(@this.x, @this.z, @this.y, @this.z);
        static public Vector4 XZYW(this Vector4Int @this)
        => new(@this.x, @this.z, @this.y, @this.w);
        static public Vector4 XZZX(this Vector4Int @this)
        => new(@this.x, @this.z, @this.z, @this.x);
        static public Vector4 XZZY(this Vector4Int @this)
        => new(@this.x, @this.z, @this.z, @this.y);
        static public Vector4 XZZZ(this Vector4Int @this)
        => new(@this.x, @this.z, @this.z, @this.z);
        static public Vector4 XZZW(this Vector4Int @this)
        => new(@this.x, @this.z, @this.z, @this.w);
        static public Vector4 XZWX(this Vector4Int @this)
        => new(@this.x, @this.z, @this.w, @this.x);
        static public Vector4 XZWY(this Vector4Int @this)
        => new(@this.x, @this.z, @this.w, @this.y);
        static public Vector4 XZWZ(this Vector4Int @this)
        => new(@this.x, @this.z, @this.w, @this.z);
        static public Vector4 XZWW(this Vector4Int @this)
        => new(@this.x, @this.z, @this.w, @this.w);

        static public Vector4 XWXX(this Vector4Int @this)
        => new(@this.x, @this.w, @this.x, @this.x);
        static public Vector4 XWXY(this Vector4Int @this)
        => new(@this.x, @this.w, @this.x, @this.y);
        static public Vector4 XWXZ(this Vector4Int @this)
        => new(@this.x, @this.w, @this.x, @this.z);
        static public Vector4 XWXW(this Vector4Int @this)
        => new(@this.x, @this.w, @this.x, @this.w);
        static public Vector4 XWYX(this Vector4Int @this)
        => new(@this.x, @this.w, @this.y, @this.x);
        static public Vector4 XWYY(this Vector4Int @this)
        => new(@this.x, @this.w, @this.y, @this.y);
        static public Vector4 XWYZ(this Vector4Int @this)
        => new(@this.x, @this.w, @this.y, @this.z);
        static public Vector4 XWYW(this Vector4Int @this)
        => new(@this.x, @this.w, @this.y, @this.w);
        static public Vector4 XWZX(this Vector4Int @this)
        => new(@this.x, @this.w, @this.z, @this.x);
        static public Vector4 XWZY(this Vector4Int @this)
        => new(@this.x, @this.w, @this.z, @this.y);
        static public Vector4 XWZZ(this Vector4Int @this)
        => new(@this.x, @this.w, @this.z, @this.z);
        static public Vector4 XWZW(this Vector4Int @this)
        => new(@this.x, @this.w, @this.z, @this.w);
        static public Vector4 XWWX(this Vector4Int @this)
        => new(@this.x, @this.w, @this.w, @this.x);
        static public Vector4 XWWY(this Vector4Int @this)
        => new(@this.x, @this.w, @this.w, @this.y);
        static public Vector4 XWWZ(this Vector4Int @this)
        => new(@this.x, @this.w, @this.w, @this.z);
        static public Vector4 XWWW(this Vector4Int @this)
        => new(@this.x, @this.w, @this.w, @this.w);

        static public Vector4 YXXX(this Vector4Int @this)
        => new(@this.y, @this.x, @this.x, @this.x);
        static public Vector4 YXXY(this Vector4Int @this)
        => new(@this.y, @this.x, @this.x, @this.y);
        static public Vector4 YXXZ(this Vector4Int @this)
        => new(@this.y, @this.x, @this.x, @this.z);
        static public Vector4 YXXW(this Vector4Int @this)
        => new(@this.y, @this.x, @this.x, @this.w);
        static public Vector4 YXYX(this Vector4Int @this)
        => new(@this.y, @this.x, @this.y, @this.x);
        static public Vector4 YXYY(this Vector4Int @this)
        => new(@this.y, @this.x, @this.y, @this.y);
        static public Vector4 YXYZ(this Vector4Int @this)
        => new(@this.y, @this.x, @this.y, @this.z);
        static public Vector4 YXYW(this Vector4Int @this)
        => new(@this.y, @this.x, @this.y, @this.w);
        static public Vector4 YXZX(this Vector4Int @this)
        => new(@this.y, @this.x, @this.z, @this.x);
        static public Vector4 YXZY(this Vector4Int @this)
        => new(@this.y, @this.x, @this.z, @this.y);
        static public Vector4 YXZZ(this Vector4Int @this)
        => new(@this.y, @this.x, @this.z, @this.z);
        static public Vector4 YXZW(this Vector4Int @this)
        => new(@this.y, @this.x, @this.z, @this.w);
        static public Vector4 YXWX(this Vector4Int @this)
        => new(@this.y, @this.x, @this.w, @this.x);
        static public Vector4 YXWY(this Vector4Int @this)
        => new(@this.y, @this.x, @this.w, @this.y);
        static public Vector4 YXWZ(this Vector4Int @this)
        => new(@this.y, @this.x, @this.w, @this.z);
        static public Vector4 YXWW(this Vector4Int @this)
        => new(@this.y, @this.x, @this.w, @this.w);

        static public Vector4 YYXX(this Vector4Int @this)
        => new(@this.y, @this.y, @this.x, @this.x);
        static public Vector4 YYXY(this Vector4Int @this)
        => new(@this.y, @this.y, @this.x, @this.y);
        static public Vector4 YYXZ(this Vector4Int @this)
        => new(@this.y, @this.y, @this.x, @this.z);
        static public Vector4 YYXW(this Vector4Int @this)
        => new(@this.y, @this.y, @this.x, @this.w);
        static public Vector4 YYYX(this Vector4Int @this)
        => new(@this.y, @this.y, @this.y, @this.x);
        static public Vector4 YYYY(this Vector4Int @this)
        => new(@this.y, @this.y, @this.y, @this.y);
        static public Vector4 YYYZ(this Vector4Int @this)
        => new(@this.y, @this.y, @this.y, @this.z);
        static public Vector4 YYYW(this Vector4Int @this)
        => new(@this.y, @this.y, @this.y, @this.w);
        static public Vector4 YYZX(this Vector4Int @this)
        => new(@this.y, @this.y, @this.z, @this.x);
        static public Vector4 YYZY(this Vector4Int @this)
        => new(@this.y, @this.y, @this.z, @this.y);
        static public Vector4 YYZZ(this Vector4Int @this)
        => new(@this.y, @this.y, @this.z, @this.z);
        static public Vector4 YYZW(this Vector4Int @this)
        => new(@this.y, @this.y, @this.z, @this.w);
        static public Vector4 YYWX(this Vector4Int @this)
        => new(@this.y, @this.y, @this.w, @this.x);
        static public Vector4 YYWY(this Vector4Int @this)
        => new(@this.y, @this.y, @this.w, @this.y);
        static public Vector4 YYWZ(this Vector4Int @this)
        => new(@this.y, @this.y, @this.w, @this.z);
        static public Vector4 YYWW(this Vector4Int @this)
        => new(@this.y, @this.y, @this.w, @this.w);

        static public Vector4 YZXX(this Vector4Int @this)
        => new(@this.y, @this.z, @this.x, @this.x);
        static public Vector4 YZXY(this Vector4Int @this)
        => new(@this.y, @this.z, @this.x, @this.y);
        static public Vector4 YZXZ(this Vector4Int @this)
        => new(@this.y, @this.z, @this.x, @this.z);
        static public Vector4 YZXW(this Vector4Int @this)
        => new(@this.y, @this.z, @this.x, @this.w);
        static public Vector4 YZYX(this Vector4Int @this)
        => new(@this.y, @this.z, @this.y, @this.x);
        static public Vector4 YZYY(this Vector4Int @this)
        => new(@this.y, @this.z, @this.y, @this.y);
        static public Vector4 YZYZ(this Vector4Int @this)
        => new(@this.y, @this.z, @this.y, @this.z);
        static public Vector4 YZYW(this Vector4Int @this)
        => new(@this.y, @this.z, @this.y, @this.w);
        static public Vector4 YZZX(this Vector4Int @this)
        => new(@this.y, @this.z, @this.z, @this.x);
        static public Vector4 YZZY(this Vector4Int @this)
        => new(@this.y, @this.z, @this.z, @this.y);
        static public Vector4 YZZZ(this Vector4Int @this)
        => new(@this.y, @this.z, @this.z, @this.z);
        static public Vector4 YZZW(this Vector4Int @this)
        => new(@this.y, @this.z, @this.z, @this.w);
        static public Vector4 YZWX(this Vector4Int @this)
        => new(@this.y, @this.z, @this.w, @this.x);
        static public Vector4 YZWY(this Vector4Int @this)
        => new(@this.y, @this.z, @this.w, @this.y);
        static public Vector4 YZWZ(this Vector4Int @this)
        => new(@this.y, @this.z, @this.w, @this.z);
        static public Vector4 YZWW(this Vector4Int @this)
        => new(@this.y, @this.z, @this.w, @this.w);

        static public Vector4 YWXX(this Vector4Int @this)
        => new(@this.y, @this.w, @this.x, @this.x);
        static public Vector4 YWXY(this Vector4Int @this)
        => new(@this.y, @this.w, @this.x, @this.y);
        static public Vector4 YWXZ(this Vector4Int @this)
        => new(@this.y, @this.w, @this.x, @this.z);
        static public Vector4 YWXW(this Vector4Int @this)
        => new(@this.y, @this.w, @this.x, @this.w);
        static public Vector4 YWYX(this Vector4Int @this)
        => new(@this.y, @this.w, @this.y, @this.x);
        static public Vector4 YWYY(this Vector4Int @this)
        => new(@this.y, @this.w, @this.y, @this.y);
        static public Vector4 YWYZ(this Vector4Int @this)
        => new(@this.y, @this.w, @this.y, @this.z);
        static public Vector4 YWYW(this Vector4Int @this)
        => new(@this.y, @this.w, @this.y, @this.w);
        static public Vector4 YWZX(this Vector4Int @this)
        => new(@this.y, @this.w, @this.z, @this.x);
        static public Vector4 YWZY(this Vector4Int @this)
        => new(@this.y, @this.w, @this.z, @this.y);
        static public Vector4 YWZZ(this Vector4Int @this)
        => new(@this.y, @this.w, @this.z, @this.z);
        static public Vector4 YWZW(this Vector4Int @this)
        => new(@this.y, @this.w, @this.z, @this.w);
        static public Vector4 YWWX(this Vector4Int @this)
        => new(@this.y, @this.w, @this.w, @this.x);
        static public Vector4 YWWY(this Vector4Int @this)
        => new(@this.y, @this.w, @this.w, @this.y);
        static public Vector4 YWWZ(this Vector4Int @this)
        => new(@this.y, @this.w, @this.w, @this.z);
        static public Vector4 YWWW(this Vector4Int @this)
        => new(@this.y, @this.w, @this.w, @this.w);

        static public Vector4 ZXXX(this Vector4Int @this)
        => new(@this.z, @this.x, @this.x, @this.x);
        static public Vector4 ZXXY(this Vector4Int @this)
        => new(@this.z, @this.x, @this.x, @this.y);
        static public Vector4 ZXXZ(this Vector4Int @this)
        => new(@this.z, @this.x, @this.x, @this.z);
        static public Vector4 ZXXW(this Vector4Int @this)
        => new(@this.z, @this.x, @this.x, @this.w);
        static public Vector4 ZXYX(this Vector4Int @this)
        => new(@this.z, @this.x, @this.y, @this.x);
        static public Vector4 ZXYY(this Vector4Int @this)
        => new(@this.z, @this.x, @this.y, @this.y);
        static public Vector4 ZXYZ(this Vector4Int @this)
        => new(@this.z, @this.x, @this.y, @this.z);
        static public Vector4 ZXYW(this Vector4Int @this)
        => new(@this.z, @this.x, @this.y, @this.w);
        static public Vector4 ZXZX(this Vector4Int @this)
        => new(@this.z, @this.x, @this.z, @this.x);
        static public Vector4 ZXZY(this Vector4Int @this)
        => new(@this.z, @this.x, @this.z, @this.y);
        static public Vector4 ZXZZ(this Vector4Int @this)
        => new(@this.z, @this.x, @this.z, @this.z);
        static public Vector4 ZXZW(this Vector4Int @this)
        => new(@this.z, @this.x, @this.z, @this.w);
        static public Vector4 ZXWX(this Vector4Int @this)
        => new(@this.z, @this.x, @this.w, @this.x);
        static public Vector4 ZXWY(this Vector4Int @this)
        => new(@this.z, @this.x, @this.w, @this.y);
        static public Vector4 ZXWZ(this Vector4Int @this)
        => new(@this.z, @this.x, @this.w, @this.z);
        static public Vector4 ZXWW(this Vector4Int @this)
        => new(@this.z, @this.x, @this.w, @this.w);

        static public Vector4 ZYXX(this Vector4Int @this)
        => new(@this.z, @this.y, @this.x, @this.x);
        static public Vector4 ZYXY(this Vector4Int @this)
        => new(@this.z, @this.y, @this.x, @this.y);
        static public Vector4 ZYXZ(this Vector4Int @this)
        => new(@this.z, @this.y, @this.x, @this.z);
        static public Vector4 ZYXW(this Vector4Int @this)
        => new(@this.z, @this.y, @this.x, @this.w);
        static public Vector4 ZYYX(this Vector4Int @this)
        => new(@this.z, @this.y, @this.y, @this.x);
        static public Vector4 ZYYY(this Vector4Int @this)
        => new(@this.z, @this.y, @this.y, @this.y);
        static public Vector4 ZYYZ(this Vector4Int @this)
        => new(@this.z, @this.y, @this.y, @this.z);
        static public Vector4 ZYYW(this Vector4Int @this)
        => new(@this.z, @this.y, @this.y, @this.w);
        static public Vector4 ZYZX(this Vector4Int @this)
        => new(@this.z, @this.y, @this.z, @this.x);
        static public Vector4 ZYZY(this Vector4Int @this)
        => new(@this.z, @this.y, @this.z, @this.y);
        static public Vector4 ZYZZ(this Vector4Int @this)
        => new(@this.z, @this.y, @this.z, @this.z);
        static public Vector4 ZYZW(this Vector4Int @this)
        => new(@this.z, @this.y, @this.z, @this.w);
        static public Vector4 ZYWX(this Vector4Int @this)
        => new(@this.z, @this.y, @this.w, @this.x);
        static public Vector4 ZYWY(this Vector4Int @this)
        => new(@this.z, @this.y, @this.w, @this.y);
        static public Vector4 ZYWZ(this Vector4Int @this)
        => new(@this.z, @this.y, @this.w, @this.z);
        static public Vector4 ZYWW(this Vector4Int @this)
        => new(@this.z, @this.y, @this.w, @this.w);

        static public Vector4 ZZXX(this Vector4Int @this)
        => new(@this.z, @this.z, @this.x, @this.x);
        static public Vector4 ZZXY(this Vector4Int @this)
        => new(@this.z, @this.z, @this.x, @this.y);
        static public Vector4 ZZXZ(this Vector4Int @this)
        => new(@this.z, @this.z, @this.x, @this.z);
        static public Vector4 ZZXW(this Vector4Int @this)
        => new(@this.z, @this.z, @this.x, @this.w);
        static public Vector4 ZZYX(this Vector4Int @this)
        => new(@this.z, @this.z, @this.y, @this.x);
        static public Vector4 ZZYY(this Vector4Int @this)
        => new(@this.z, @this.z, @this.y, @this.y);
        static public Vector4 ZZYZ(this Vector4Int @this)
        => new(@this.z, @this.z, @this.y, @this.z);
        static public Vector4 ZZYW(this Vector4Int @this)
        => new(@this.z, @this.z, @this.y, @this.w);
        static public Vector4 ZZZX(this Vector4Int @this)
        => new(@this.z, @this.z, @this.z, @this.x);
        static public Vector4 ZZZY(this Vector4Int @this)
        => new(@this.z, @this.z, @this.z, @this.y);
        static public Vector4 ZZZZ(this Vector4Int @this)
        => new(@this.z, @this.z, @this.z, @this.z);
        static public Vector4 ZZZW(this Vector4Int @this)
        => new(@this.z, @this.z, @this.z, @this.w);
        static public Vector4 ZZWX(this Vector4Int @this)
        => new(@this.z, @this.z, @this.w, @this.x);
        static public Vector4 ZZWY(this Vector4Int @this)
        => new(@this.z, @this.z, @this.w, @this.y);
        static public Vector4 ZZWZ(this Vector4Int @this)
        => new(@this.z, @this.z, @this.w, @this.z);
        static public Vector4 ZZWW(this Vector4Int @this)
        => new(@this.z, @this.z, @this.w, @this.w);

        static public Vector4 ZWXX(this Vector4Int @this)
        => new(@this.z, @this.w, @this.x, @this.x);
        static public Vector4 ZWXY(this Vector4Int @this)
        => new(@this.z, @this.w, @this.x, @this.y);
        static public Vector4 ZWXZ(this Vector4Int @this)
        => new(@this.z, @this.w, @this.x, @this.z);
        static public Vector4 ZWXW(this Vector4Int @this)
        => new(@this.z, @this.w, @this.x, @this.w);
        static public Vector4 ZWYX(this Vector4Int @this)
        => new(@this.z, @this.w, @this.y, @this.x);
        static public Vector4 ZWYY(this Vector4Int @this)
        => new(@this.z, @this.w, @this.y, @this.y);
        static public Vector4 ZWYZ(this Vector4Int @this)
        => new(@this.z, @this.w, @this.y, @this.z);
        static public Vector4 ZWYW(this Vector4Int @this)
        => new(@this.z, @this.w, @this.y, @this.w);
        static public Vector4 ZWZX(this Vector4Int @this)
        => new(@this.z, @this.w, @this.z, @this.x);
        static public Vector4 ZWZY(this Vector4Int @this)
        => new(@this.z, @this.w, @this.z, @this.y);
        static public Vector4 ZWZZ(this Vector4Int @this)
        => new(@this.z, @this.w, @this.z, @this.z);
        static public Vector4 ZWZW(this Vector4Int @this)
        => new(@this.z, @this.w, @this.z, @this.w);
        static public Vector4 ZWWX(this Vector4Int @this)
        => new(@this.z, @this.w, @this.w, @this.x);
        static public Vector4 ZWWY(this Vector4Int @this)
        => new(@this.z, @this.w, @this.w, @this.y);
        static public Vector4 ZWWZ(this Vector4Int @this)
        => new(@this.z, @this.w, @this.w, @this.z);
        static public Vector4 ZWWW(this Vector4Int @this)
        => new(@this.z, @this.w, @this.w, @this.w);

        static public Vector4 WXXX(this Vector4Int @this)
        => new(@this.w, @this.x, @this.x, @this.x);
        static public Vector4 WXXY(this Vector4Int @this)
        => new(@this.w, @this.x, @this.x, @this.y);
        static public Vector4 WXXZ(this Vector4Int @this)
        => new(@this.w, @this.x, @this.x, @this.z);
        static public Vector4 WXXW(this Vector4Int @this)
        => new(@this.w, @this.x, @this.x, @this.w);
        static public Vector4 WXYX(this Vector4Int @this)
        => new(@this.w, @this.x, @this.y, @this.x);
        static public Vector4 WXYY(this Vector4Int @this)
        => new(@this.w, @this.x, @this.y, @this.y);
        static public Vector4 WXYZ(this Vector4Int @this)
        => new(@this.w, @this.x, @this.y, @this.z);
        static public Vector4 WXYW(this Vector4Int @this)
        => new(@this.w, @this.x, @this.y, @this.w);
        static public Vector4 WXZX(this Vector4Int @this)
        => new(@this.w, @this.x, @this.z, @this.x);
        static public Vector4 WXZY(this Vector4Int @this)
        => new(@this.w, @this.x, @this.z, @this.y);
        static public Vector4 WXZZ(this Vector4Int @this)
        => new(@this.w, @this.x, @this.z, @this.z);
        static public Vector4 WXZW(this Vector4Int @this)
        => new(@this.w, @this.x, @this.z, @this.w);
        static public Vector4 WXWX(this Vector4Int @this)
        => new(@this.w, @this.x, @this.w, @this.x);
        static public Vector4 WXWY(this Vector4Int @this)
        => new(@this.w, @this.x, @this.w, @this.y);
        static public Vector4 WXWZ(this Vector4Int @this)
        => new(@this.w, @this.x, @this.w, @this.z);
        static public Vector4 WXWW(this Vector4Int @this)
        => new(@this.w, @this.x, @this.w, @this.w);

        static public Vector4 WYXX(this Vector4Int @this)
        => new(@this.w, @this.y, @this.x, @this.x);
        static public Vector4 WYXY(this Vector4Int @this)
        => new(@this.w, @this.y, @this.x, @this.y);
        static public Vector4 WYXZ(this Vector4Int @this)
        => new(@this.w, @this.y, @this.x, @this.z);
        static public Vector4 WYXW(this Vector4Int @this)
        => new(@this.w, @this.y, @this.x, @this.w);
        static public Vector4 WYYX(this Vector4Int @this)
        => new(@this.w, @this.y, @this.y, @this.x);
        static public Vector4 WYYY(this Vector4Int @this)
        => new(@this.w, @this.y, @this.y, @this.y);
        static public Vector4 WYYZ(this Vector4Int @this)
        => new(@this.w, @this.y, @this.y, @this.z);
        static public Vector4 WYYW(this Vector4Int @this)
        => new(@this.w, @this.y, @this.y, @this.w);
        static public Vector4 WYZX(this Vector4Int @this)
        => new(@this.w, @this.y, @this.z, @this.x);
        static public Vector4 WYZY(this Vector4Int @this)
        => new(@this.w, @this.y, @this.z, @this.y);
        static public Vector4 WYZZ(this Vector4Int @this)
        => new(@this.w, @this.y, @this.z, @this.z);
        static public Vector4 WYZW(this Vector4Int @this)
        => new(@this.w, @this.y, @this.z, @this.w);
        static public Vector4 WYWX(this Vector4Int @this)
        => new(@this.w, @this.y, @this.w, @this.x);
        static public Vector4 WYWY(this Vector4Int @this)
        => new(@this.w, @this.y, @this.w, @this.y);
        static public Vector4 WYWZ(this Vector4Int @this)
        => new(@this.w, @this.y, @this.w, @this.z);
        static public Vector4 WYWW(this Vector4Int @this)
        => new(@this.w, @this.y, @this.w, @this.w);

        static public Vector4 WZXX(this Vector4Int @this)
        => new(@this.w, @this.z, @this.x, @this.x);
        static public Vector4 WZXY(this Vector4Int @this)
        => new(@this.w, @this.z, @this.x, @this.y);
        static public Vector4 WZXZ(this Vector4Int @this)
        => new(@this.w, @this.z, @this.x, @this.z);
        static public Vector4 WZXW(this Vector4Int @this)
        => new(@this.w, @this.z, @this.x, @this.w);
        static public Vector4 WZYX(this Vector4Int @this)
        => new(@this.w, @this.z, @this.y, @this.x);
        static public Vector4 WZYY(this Vector4Int @this)
        => new(@this.w, @this.z, @this.y, @this.y);
        static public Vector4 WZYZ(this Vector4Int @this)
        => new(@this.w, @this.z, @this.y, @this.z);
        static public Vector4 WZYW(this Vector4Int @this)
        => new(@this.w, @this.z, @this.y, @this.w);
        static public Vector4 WZZX(this Vector4Int @this)
        => new(@this.w, @this.z, @this.z, @this.x);
        static public Vector4 WZZY(this Vector4Int @this)
        => new(@this.w, @this.z, @this.z, @this.y);
        static public Vector4 WZZZ(this Vector4Int @this)
        => new(@this.w, @this.z, @this.z, @this.z);
        static public Vector4 WZZW(this Vector4Int @this)
        => new(@this.w, @this.z, @this.z, @this.w);
        static public Vector4 WZWX(this Vector4Int @this)
        => new(@this.w, @this.z, @this.w, @this.x);
        static public Vector4 WZWY(this Vector4Int @this)
        => new(@this.w, @this.z, @this.w, @this.y);
        static public Vector4 WZWZ(this Vector4Int @this)
        => new(@this.w, @this.z, @this.w, @this.z);
        static public Vector4 WZWW(this Vector4Int @this)
        => new(@this.w, @this.z, @this.w, @this.w);

        static public Vector4 WWXX(this Vector4Int @this)
        => new(@this.w, @this.w, @this.x, @this.x);
        static public Vector4 WWXY(this Vector4Int @this)
        => new(@this.w, @this.w, @this.x, @this.y);
        static public Vector4 WWXZ(this Vector4Int @this)
        => new(@this.w, @this.w, @this.x, @this.z);
        static public Vector4 WWXW(this Vector4Int @this)
        => new(@this.w, @this.w, @this.x, @this.w);
        static public Vector4 WWYX(this Vector4Int @this)
        => new(@this.w, @this.w, @this.y, @this.x);
        static public Vector4 WWYY(this Vector4Int @this)
        => new(@this.w, @this.w, @this.y, @this.y);
        static public Vector4 WWYZ(this Vector4Int @this)
        => new(@this.w, @this.w, @this.y, @this.z);
        static public Vector4 WWYW(this Vector4Int @this)
        => new(@this.w, @this.w, @this.y, @this.w);
        static public Vector4 WWZX(this Vector4Int @this)
        => new(@this.w, @this.w, @this.z, @this.x);
        static public Vector4 WWZY(this Vector4Int @this)
        => new(@this.w, @this.w, @this.z, @this.y);
        static public Vector4 WWZZ(this Vector4Int @this)
        => new(@this.w, @this.w, @this.z, @this.z);
        static public Vector4 WWZW(this Vector4Int @this)
        => new(@this.w, @this.w, @this.z, @this.w);
        static public Vector4 WWWX(this Vector4Int @this)
        => new(@this.w, @this.w, @this.w, @this.x);
        static public Vector4 WWWY(this Vector4Int @this)
        => new(@this.w, @this.w, @this.w, @this.y);
        static public Vector4 WWWZ(this Vector4Int @this)
        => new(@this.w, @this.w, @this.w, @this.z);
        static public Vector4 WWWW(this Vector4Int @this)
        => new(@this.w, @this.w, @this.w, @this.w);
        #endregion
    }
}
#endif