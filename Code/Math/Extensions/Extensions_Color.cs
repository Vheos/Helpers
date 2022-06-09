#if UNITY
namespace Vheos.Helpers.Math;

public static class Extensions_Color
{
    #region COMMON, COLOR
    /// <summary> Adds (a.r, a.g, a.b, a.a) to this color's components. </summary>
    public static Color Add(this Color @this, Color a)
    => new(@this.r.Add(a.r), @this.g.Add(a.g), @this.b.Add(a.b), @this.a.Add(a.a));
    /// <summary> Subtracts (a.r, a.g, a.b, a.a) from this color's components. </summary>
    public static Color Sub(this Color @this, Color a)
    => new(@this.r.Sub(a.r), @this.g.Sub(a.g), @this.b.Sub(a.b), @this.a.Sub(a.a));
    /// <summary> Multiplies this color's components by (a.r, a.g, a.b, a.a). </summary>
    public static Color Mul(this Color @this, Color a)
    => new(@this.r.Mul(a.r), @this.g.Mul(a.g), @this.b.Mul(a.b), @this.a.Mul(a.a));
    /// <summary> Divides this color's components by (a.r, a.g, a.b, a.a). </summary>
    public static Color Div(this Color @this, Color a)
    => new(@this.r.Div(a.r), @this.g.Div(a.g), @this.b.Div(a.b), @this.a.Div(a.a));
    /// <summary> Raises this color's components to the power of (a.r, a.g, a.b, a.a). </summary>
    public static Color Pow(this Color @this, Color a)
    => new(@this.r.Pow(a.r), @this.g.Pow(a.g), @this.b.Pow(a.b), @this.a.Pow(a.a));
    /// <summary> Returns the remainder of this color's components divided by (a.r, a.g, a.b, a.a). </summary>
    public static Color Mod(this Color @this, Color a)
    => new(@this.r.Mod(a.r), @this.g.Mod(a.g), @this.b.Mod(a.b), @this.a.Mod(a.a));
    /// <summary> Returns the positive remainder of this color's components divided by (a.r, a.g, a.b, a.a). </summary>
    public static Color PosMod(this Color @this, Color a)
    => new(@this.r.PosMod(a.r), @this.g.PosMod(a.g), @this.b.PosMod(a.b), @this.a.PosMod(a.a));

    /// <summary> Rounds this color's components to the nearest multiple of (a.r, a.g, a.b, a.a). </summary>
    public static Color RoundToMultiple(this Color @this, Color a)
    => new(@this.r.RoundToMultiple(a.r), @this.g.RoundToMultiple(a.g), @this.b.RoundToMultiple(a.b), @this.a.RoundToMultiple(a.a));
    /// <summary> Returns the smaller between this color's components and (a.r, a.g, a.b, a.a). </summary>
    public static Color Min(this Color @this, Color a)
    => new(@this.r.Min(a.r), @this.g.Min(a.g), @this.b.Min(a.b), @this.a.Min(a.a));
    /// <summary> Returns the greater between this color's components and (a.r, a.g, a.b, a.a). </summary>
    public static Color Max(this Color @this, Color a)
    => new(@this.r.Max(a.r), @this.g.Max(a.g), @this.b.Max(a.b), @this.a.Max(a.a));
    /// <summary> Returns the average of this color's components and (a.r, a.g, a.b, a.a). </summary>
    public static Color Avg(this Color @this, Color a)
    => new(@this.r.Avg(a.r), @this.g.Avg(a.g), @this.b.Avg(a.b), @this.a.Avg(a.a));
    /// <summary> Clamps this color's components to a minimum of (a.r, a.g, a.b, a.a). </summary>
    public static Color ClampMin(this Color @this, Color a)
    => new(@this.r.ClampMin(a.r), @this.g.ClampMin(a.g), @this.b.ClampMin(a.b), @this.a.ClampMin(a.a));
    /// <summary> Clamps this color's components to a maximum of (a.r, a.g, a.b, a.a). </summary>
    public static Color ClampMax(this Color @this, Color a)
    => new(@this.r.ClampMax(a.r), @this.g.ClampMax(a.g), @this.b.ClampMax(a.b), @this.a.ClampMax(a.a));

    /// <summary> Clamps this color's components between (a.r, a.g, a.b, a.a) and (b.r, b.g, b.b, b.a).</summary>
    public static Color Clamp(this Color @this, Color a, Color b)
    => new(@this.r.Clamp(a.r, b.r), @this.g.Clamp(a.g, b.g), @this.b.Clamp(a.b, b.b), @this.a.Clamp(a.a, b.a));
    /// <summary> Lerps from this color to a at alpha b. </summary>
    public static Color Lerp(this Color @this, Color a, float b)
    => new(@this.r.Lerp(a.r, b), @this.g.Lerp(a.g, b), @this.b.Lerp(a.b, b), @this.a.Lerp(a.a, b));
    /// <summary> Lerps from this color to a at alpha b (clamped between 0 and 1). </summary>
    public static Color LerpClamped(this Color @this, Color a, float b)
    => new(@this.r.LerpClamped(a.r, b), @this.g.LerpClamped(a.g, b), @this.b.LerpClamped(a.b, b), @this.a.LerpClamped(a.a, b));

    /// <summary> Maps this color from the range [a, b] to [c, d]. </summary>
    public static Color Map(this Color @this, Color a, Color b, Color c, Color d)
    => new(@this.r.Map(a.r, b.r, c.r, d.r), @this.g.Map(a.g, b.g, c.g, d.g), @this.b.Map(a.b, b.b, c.b, d.b), @this.a.Map(a.a, b.a, c.a, d.a));
    /// <summary> Maps this color from the range [a, b] to [c, d] (with clamped output). </summary>
    public static Color MapClamped(this Color @this, Color a, Color b, Color c, Color d)
    => new(@this.r.MapClamped(a.r, b.r, c.r, d.r), @this.g.MapClamped(a.g, b.g, c.g, d.g), @this.b.MapClamped(a.b, b.b, c.b, d.b), @this.a.MapClamped(a.a, b.a, c.a, d.a));
    /// <summary> Maps this color from the range [a, b] to [0, 1]. </summary>
    public static Color MapTo01(this Color @this, Color a, Color b)
    => new(@this.r.MapTo01(a.r, b.r), @this.g.MapTo01(a.g, b.g), @this.b.MapTo01(a.b, b.b), @this.a.MapTo01(a.a, b.a));
    /// <summary> Maps this color from the range [0, 1] to [a, b]. </summary>
    public static Color MapFrom01(this Color @this, Color a, Color b)
    => new(@this.r.MapFrom01(a.r, b.r), @this.g.MapFrom01(a.g, b.g), @this.b.MapFrom01(a.b, b.b), @this.a.MapFrom01(a.a, b.a));
    #endregion
    #region COMMON, COMPONENTS
    /// <summary> Adds (r, g, b, a) to this color's components. </summary>
    public static Color Add(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Add(r), @this.g.Add(g), @this.b.Add(b), @this.a.Add(a));
    /// <summary> Subtracts (r, g, b, a) from this color's components. </summary>
    public static Color Sub(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Sub(r), @this.g.Sub(g), @this.b.Sub(b), @this.a.Sub(a));
    /// <summary> Multiplies this color's components by (r, g, b, a). </summary>
    public static Color Mul(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Mul(r), @this.g.Mul(g), @this.b.Mul(b), @this.a.Mul(a));
    /// <summary> Divides this color's components by (r, g, b, a). </summary>
    public static Color Div(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Div(r), @this.g.Div(g), @this.b.Div(b), @this.a.Div(a));
    /// <summary> Raises this color's components to the power of (r, g, b, a). </summary>
    public static Color Pow(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Pow(r), @this.g.Pow(g), @this.b.Pow(b), @this.a.Pow(a));
    /// <summary> Returns the remainder of this color's components divided by (r, g, b, a). </summary>
    public static Color Mod(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Mod(r), @this.g.Mod(g), @this.b.Mod(b), @this.a.Mod(a));
    /// <summary> Returns the positive remainder of this color's components divided by (r, g, b, a). </summary>
    public static Color PosMod(this Color @this, float r, float g, float b, float a)
    => new(@this.r.PosMod(r), @this.g.PosMod(g), @this.b.PosMod(b), @this.a.PosMod(a));

    /// <summary> Rounds this color's components to the nearest multiple of (r, g, b, a). </summary>
    public static Color RoundToMultiple(this Color @this, float r, float g, float b, float a)
    => new(@this.r.RoundToMultiple(r), @this.g.RoundToMultiple(g), @this.b.RoundToMultiple(b), @this.a.RoundToMultiple(a));
    /// <summary> Returns the smaller between this color's components and (r, g, b, a). </summary>
    public static Color Min(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Min(r), @this.g.Min(g), @this.b.Min(b), @this.a.Min(a));
    /// <summary> Returns the greater between this color's components and (r, g, b, a). </summary>
    public static Color Max(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Max(r), @this.g.Max(g), @this.b.Max(b), @this.a.Max(a));
    /// <summary> Returns the average of this color's components and (r, g, b, a). </summary>
    public static Color Avg(this Color @this, float r, float g, float b, float a)
    => new(@this.r.Avg(r), @this.g.Avg(g), @this.b.Avg(b), @this.a.Avg(a));
    /// <summary> Clamps this color's components to a minimum of (r, g, b, a). </summary>
    public static Color ClampMin(this Color @this, float r, float g, float b, float a)
    => new(@this.r.ClampMin(r), @this.g.ClampMin(g), @this.b.ClampMin(b), @this.a.ClampMin(a));
    /// <summary> Clamps this color's components to a maximum of (r, g, b, a). </summary>
    public static Color ClampMax(this Color @this, float r, float g, float b, float a)
    => new(@this.r.ClampMax(r), @this.g.ClampMax(g), @this.b.ClampMax(b), @this.a.ClampMax(a));

    /// <summary> Lerps from this color to (r, g, b, a) at alpha lerpAlpha. </summary>
    public static Color Lerp(this Color @this, float r, float g, float b, float a, float lerpAlpha)
    => new(@this.r.Lerp(r, lerpAlpha), @this.g.Lerp(g, lerpAlpha), @this.b.Lerp(b, lerpAlpha), @this.a.Lerp(a, lerpAlpha));
    /// <summary> Lerps from this color to (r, g, b, a) at alpha lerpAlpha (clamped between 0 and 1). </summary>
    public static Color LerpClamped(this Color @this, float r, float g, float b, float a, float lerpAlpha)
    => new(@this.r.LerpClamped(r, lerpAlpha), @this.g.LerpClamped(g, lerpAlpha), @this.b.LerpClamped(b, lerpAlpha), @this.a.LerpClamped(a, lerpAlpha));
    #endregion
    #region COMMON, VALUE
    /// <summary> Adds (a, a, a, a) to this color's components. </summary>
    public static Color Add(this Color @this, float a)
    => new(@this.r.Add(a), @this.g.Add(a), @this.b.Add(a), @this.a.Add(a));
    /// <summary> Subtracts (a, a, a, a) from this color's components. </summary>
    public static Color Sub(this Color @this, float a)
    => new(@this.r.Sub(a), @this.g.Sub(a), @this.b.Sub(a), @this.a.Sub(a));
    /// <summary> Multiplies this color's components by (a, a, a, a). </summary>
    public static Color Mul(this Color @this, float a)
    => new(@this.r.Mul(a), @this.g.Mul(a), @this.b.Mul(a), @this.a.Mul(a));
    /// <summary> Divides this color's components by (a, a, a, a). </summary>
    public static Color Div(this Color @this, float a)
    => new(@this.r.Div(a), @this.g.Div(a), @this.b.Div(a), @this.a.Div(a));
    /// <summary> Raises this color's components to the power of (a, a, a, a). </summary>
    public static Color Pow(this Color @this, float a)
    => new(@this.r.Pow(a), @this.g.Pow(a), @this.b.Pow(a), @this.a.Pow(a));
    /// <summary> Returns the remainder of this color's components divided by (a, yy). </summary>
    public static Color Mod(this Color @this, float a)
    => new(@this.r.Mod(a), @this.g.Mod(a), @this.b.Mod(a), @this.a.Mod(a));
    /// <summary> Returns the positive remainder of this color's components divided by (a, yy). </summary>
    public static Color PosMod(this Color @this, float a)
    => new(@this.r.PosMod(a), @this.g.PosMod(a), @this.b.PosMod(a), @this.a.PosMod(a));

    /// <summary> Rounds this color's components to the nearest multiple of (a, a, a, a). </summary>
    public static Color RoundToMultiple(this Color @this, float a)
    => new(@this.r.RoundToMultiple(a), @this.g.RoundToMultiple(a), @this.b.RoundToMultiple(a), @this.a.RoundToMultiple(a));
    /// <summary> Returns the smaller between this color's components and (a, a, a, a). </summary>
    public static Color Min(this Color @this, float a)
    => new(@this.r.Min(a), @this.g.Min(a), @this.b.Min(a), @this.a.Min(a));
    /// <summary> Returns the greater between this color's components and (a, a, a, a). </summary>
    public static Color Max(this Color @this, float a)
    => new(@this.r.Max(a), @this.g.Max(a), @this.b.Max(a), @this.a.Max(a));
    /// <summary> Returns the average of this color's components and (a, a, a, a). </summary>
    public static Color Avg(this Color @this, float a)
    => new(@this.r.Avg(a), @this.g.Avg(a), @this.b.Avg(a), @this.a.Avg(a));
    /// <summary> Clamps this color's components to a minimum of (a, a, a, a). </summary>
    public static Color ClampMin(this Color @this, float a)
    => new(@this.r.ClampMin(a), @this.g.ClampMin(a), @this.b.ClampMin(a), @this.a.ClampMin(a));
    /// <summary> Clamps this color's components to a maximum of (a, a, a, a). </summary>
    public static Color ClampMax(this Color @this, float a)
    => new(@this.r.ClampMax(a), @this.g.ClampMax(a), @this.b.ClampMax(a), @this.a.ClampMax(a));

    /// <summary> Clamps this color's components between (a, a, a, a) and (b, b, b, b).</summary>
    public static Color Clamp(this Color @this, float a, float b)
    => new(@this.r.Clamp(a, b), @this.g.Clamp(a, b), @this.b.Clamp(a, b), @this.a.Clamp(a, b));
    /// <summary> Lerps from this color to (a, a, a, a) at alpha b. </summary>
    public static Color Lerp(this Color @this, float a, float b)
    => new(@this.r.Lerp(a, b), @this.g.Lerp(a, b), @this.b.Lerp(a, b), @this.a.Lerp(a, b));
    /// <summary> Lerps from this color to (a, a, a, a) at alpha b (clamped between 0 and 1). </summary>
    public static Color LerpClamped(this Color @this, float a, float b)
    => new(@this.r.LerpClamped(a, b), @this.g.LerpClamped(a, b), @this.b.LerpClamped(a, b), @this.a.LerpClamped(a, b));
    #endregion

    #region COMPONENTS
    /// <summary> Returns this color with replaced component r. </summary>
    public static Color NewR(this Color @this, float r)
    => new(r, @this.g, @this.b, @this.a);
    /// <summary> Returns this color with replaced component g. </summary>
    public static Color NewG(this Color @this, float g)
    => new(@this.r, g, @this.b, @this.a);
    /// <summary> Returns this color with replaced component b. </summary>
    public static Color NewB(this Color @this, float b)
    => new(@this.r, @this.g, b, @this.a);
    /// <summary> Returns this color with replaced component a. </summary>
    public static Color NewA(this Color @this, float a)
    => new(@this.r, @this.g, @this.b, a);

    /// <summary> Returns this color's RGB components. </summary>
    public static Color RGB(this Color @this)
    => new(@this.r, @this.g, @this.b, 0f);
    /// <summary> Returns this color's RBG components. </summary>
    public static Color RBG(this Color @this)
    => new(@this.r, @this.b, @this.g, 0f);
    /// <summary> Returns this color's GRB components. </summary>
    public static Color GRB(this Color @this)
    => new(@this.g, @this.r, @this.b, 0f);
    /// <summary> Returns this color's GBR components. </summary>
    public static Color GBR(this Color @this)
    => new(@this.g, @this.b, @this.r, 0f);
    /// <summary> Returns this color's BRG components. </summary>
    public static Color BRG(this Color @this)
    => new(@this.b, @this.r, @this.g, 0f);
    /// <summary> Returns this color's BGR components. </summary>
    public static Color BGR(this Color @this)
    => new(@this.b, @this.g, @this.r, 0f);
    #endregion
}
#endif