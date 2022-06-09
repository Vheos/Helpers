#if UNITY
namespace Vheos.Helpers.UnityObjects;
using Vheos.Helpers.Math;

public static class Extensions_Sprite
{
    /// <summary> Returns the texture used by this sprite. </summary>
    public static Texture2D Texture(this Sprite @this)
    => @this.texture;
    /// <summary> Returns this sprite's texture's size in pixels. </summary>
    public static Vector2 TextureSizePixels(this Sprite @this)
    => new(@this.Texture().width, @this.Texture().height);
    /// <summary> Returns this sprite's texture's size in units. </summary>
    public static Vector2 TextureSizeUnits(this Sprite @this)
    => @this.TextureSizePixels() / @this.pixelsPerUnit;
    /// <summary> Returns this sprite's size in pixels. </summary>
    public static Vector2 SizePixels(this Sprite @this)
    => new(@this.rect.width, @this.rect.height);
    /// <summary> Returns this sprite's size in units. </summary>
    public static Vector2 SizeUnits(this Sprite @this)
    => @this.SizePixels() / @this.pixelsPerUnit;
    /// <summary> Returns this sprite's relative size on the texture. </summary>
    public static Vector2 Size01(this Sprite @this)
    => @this.SizePixels().Div(@this.TextureSizePixels());   // pre-2017.2 versions don'@this implement division for Vector2 and Vector2 
    /// <summary> Returns this sprite's offset in pixels. </summary>
    public static Vector2 OffsetPixels(this Sprite @this)
    => new(@this.rect.min.x, @this.rect.min.y);
    /// <summary> Returns this sprite's offset in units. </summary>
    public static Vector2 OffsetUnits(this Sprite @this)
    => @this.OffsetPixels() / @this.pixelsPerUnit;
    /// <summary> Returns this sprite's relative offset on the texture. </summary>
    public static Vector2 Offset01(this Sprite @this)
    => @this.OffsetPixels().Div(@this.TextureSizePixels());   // pre-2017.2 versions don'@this implement division for Vector2 and Vector2 
    /// <summary> Returns this sprite's size and offset in pixels. </summary>
    public static Vector4 SizeOffsetPixels(this Sprite @this)
    => @this.SizePixels().Append(@this.OffsetPixels());
    /// <summary> Returns this sprite's size and offset in units. </summary>
    public static Vector4 SizeOffsetUnits(this Sprite @this)
    => @this.SizeUnits().Append(@this.OffsetUnits());
    /// <summary> Returns this sprite's relative size and offset on the texture. </summary>
    public static Vector4 SizeOffset01(this Sprite @this)
    => @this.Size01().Append(@this.Offset01());
    /// <summary> Returns this sprite's rect in pixels. </summary>
    public static Rect RectPixels(this Sprite @this)
    => @this.rect;

    /// <summary> Returns coords of a pixel at position a, relative to transform b. </summary>
    public static Vector2 PositionToPixelCoords(this Sprite @this, Vector3 a, Transform b = null)
    {
        if (b != null)
            a = a.Untransform(b);
        return (@this.RectPixels().center + a.XY() * @this.pixelsPerUnit).RoundDown();
    }
    /// <summary> Returns color of a pixel at position a, relative to transform b. </summary>
    public static Color PositionToPixelColor(this Sprite @this, Vector3 a, Transform b = null)
    {
        Vector2 pixelPosition = @this.PositionToPixelCoords(a, b);
        return @this.Texture().GetPixel((int)pixelPosition.x, (int)pixelPosition.y);
    }
    /// <summary> Returns alpha of a pixel at position a, relative to transform b. </summary>
    public static float PositionToPixelAlpha(this Sprite @this, Vector3 a, Transform b = null)
    => @this.PositionToPixelColor(a, b).a;
    /// <summary> Returns position of pixel a, transformed by b. </summary>
    public static Vector3 PixelCoordsToPosition(this Sprite @this, Vector2 a, Transform b = null)
    {
        Vector3 position = (a - @this.RectPixels().center) / @this.pixelsPerUnit;
        if (b != null)
            position = position.Transform(b);
        return position;
    }
}
#endif