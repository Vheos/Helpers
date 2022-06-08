#if UNITY
namespace Vheos.Helpers.UnityObjects;
using Vheos.Helpers.Math;

static public class Extensions_Camera
{
    /// <summary> Returns a ray going from this camera through the mouse cursor. </summary>
    static public Ray CursorRay(this Camera @this)
    => @this.ScreenPointToRay(Input.mousePosition);
    /// <summary> Returns a plane facing this camera and containing world point a. </summary>
    static public Plane ScreenPlane(this Camera @this, Vector3 a)
    => new(@this.transform.forward.Neg(), a);
    /// <summary> Returns a plane facing this camera and containing world point a. </summary>
    static public Plane ScreenPlane(this Camera @this, float a)
    => new(@this.transform.forward.Neg(), a);
    /// <summary> Returns a world point under the mouse cursor and at distnace a from this camera. </summary>
    static public Vector3 CursorToWorldPoint(this Camera @this, float a)
    => @this.ScreenToWorldPoint(Input.mousePosition.XY().Append(a));
    /// <summary> Returns a world point under the mouse cursor and on plane a. </summary>
    static public Vector3 CursorToPlanePoint(this Camera @this, Plane a)
    {
        Ray ray = @this.CursorRay();
        return a.Raycast(ray, out float distance)
            ? ray.GetPoint(distance)
            : float.NaN.ToVector3();
    }
}
#endif