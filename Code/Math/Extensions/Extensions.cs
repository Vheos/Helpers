namespace Vheos.Helpers.Math;

public static class Extensions
{
#if UNITY
    // Edge points
    /// <summary> Returns a point on this rectangle's edge given direction a. </summary>
    public static Vector2 EdgePoint(this Rect @this, Vector2 a)
    => @this.center + @this.size.Div(2f).Mul(a / a.Abs().CompMax());
    /// <summary> Returns a point on this cuboid's surface given direction a. </summary>
    public static Vector3 SurfacePoint(this Bounds @this, Vector3 a)
    => @this.center + @this.extents.Mul(a / a.Abs().CompMax());

    /// <summary> Returns this collider's local axis-aligned bounds. </summary>
    public static Bounds LocalBounds(this Collider @this)
    => @this switch
    {
        BoxCollider r => new(r.center, r.size),
        SphereCollider r => new(r.center, (2 * r.radius).ToVector3()),
        CapsuleCollider r => new(r.center, new Vector3(r.height, 2 * r.radius, 2 * r.radius).Rotate(r.transform.rotation)),
        MeshCollider r => r.sharedMesh.bounds,
        _ => default,
    };

    /// <summary> Returns this cuboid as a rectangle (with z depth removed). </summary>
    public static Rect ToRect(this Bounds @this)
    => new()
    {
        size = @this.size,
        center = @this.center,
    };
#endif
}
