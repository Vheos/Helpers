#if UNITY
namespace Vheos.Helpers.UnityObjects;
using Vheos.Helpers.Math;

public static class Extensions
{

    #region ANIMATION_CURVE
    /// <summary> Returns value of the first key in this curve. </summary>
    public static float StartValue(this AnimationCurve @this)
    => @this.keys[0].value;
    /// <summary> Returns value of the last key in this curve. </summary>
    public static float EndValue(this AnimationCurve @this)
    => @this.keys[@this.keys.Length - 1].value;
    /// <summary> Returns time of the first key in this curve. </summary>
    public static float StartTime(this AnimationCurve @this)
    => @this.keys[0].time;
    /// <summary> Returns time of the last key in this curve. </summary>
    public static float EndTime(this AnimationCurve @this)
    => @this.keys[@this.keys.Length - 1].time;
    /// <summary> Returns the duration of this curve. </summary>
    public static float Duration(this AnimationCurve @this)
    => @this.EndTime() - @this.StartTime();
    /// <summary> Tests whether this curve has at least 2 keys. </summary>
    public static bool IsValid(this AnimationCurve @this)
    => @this.length >= 2;
#if !NET35
    /// <summary> Adds keys a to this curve with all tangents and weights set to 0. </summary>
    public static void AddLinearKeys(this AnimationCurve @this, params (float Time, float Value)[] a)
    {
        for (int i = 0; i < a.Length; i++)
            @this.AddKey(new Keyframe(a[i].Time, a[i].Value, 0f, 0f));
    }
#endif
    #endregion

    #region INPUT
    /// <summary> Checks if this key has just been pressed. </summary>
    public static bool Pressed(this KeyCode @this)
    => Input.GetKeyDown(@this);
    /// <summary> Checks if this key has just been released. </summary>
    public static bool Released(this KeyCode @this)
    => Input.GetKeyUp(@this);
    /// <summary> Checks if this key is held down. </summary>
    public static bool Down(this KeyCode @this)
    => Input.GetKey(@this);
    /// <summary> Checks if this key is resting. </summary>
    public static bool Up(this KeyCode @this)
    => !Input.GetKey(@this);
    #endregion

    #region RAYCAST_HIT
    /// <summary> Returns this array of hits sorted by distance from point a. </summary>
    public static RaycastHit[] SortedByDistanceFrom(this RaycastHit[] @this, Vector3 a)
    {
        RaycastHit[] r = @this.MakeCopy();
        for (int i = 0; i < r.Length; i++)
        {
            int jMin = i;
            for (int j = i + 1; j < r.Length; j++)
                if (a.DistanceTo(r[j].point) < a.DistanceTo(r[jMin].point))
                    jMin = j;

            if (jMin != i)
                r[i].SwapWith(ref r[jMin]);
        }

        return r;
    }
    /// <summary> Returns this array of hits sorted by distance from object a. </summary>
    public static RaycastHit[] SortedByDistanceFrom(this RaycastHit[] @this, UnityEngine.GameObject a)
    => @this.SortedByDistanceFrom(a.transform.position);
    /// <summary> Returns this array of hits sorted by distance from object a. </summary>
    public static RaycastHit[] SortedByDistanceFrom(this RaycastHit[] @this, Component a)
    => @this.SortedByDistanceFrom(a.gameObject);
    #endregion

    #region MIDPOINT
    public static Vector3 Midpoint<T>(this IEnumerable<T> @this, Func<T, Vector3> positionFunc)
    {
        Vector3 r = Vector3.zero;
        int count = 0;
        foreach (var element in @this)
        {
            r += positionFunc(element);
            count++;
        }
        return r / count;
    }
    public static Vector3 Midpoint(this IEnumerable<UnityEngine.GameObject> @this)
    => Midpoint(@this, GameObject => GameObject.transform.position);
    public static Vector3 Midpoint(this IEnumerable<Component> @this)
    => Midpoint(@this, component => component.transform.position);
    #endregion

    #region TRANSFORM
    public static void SetPositionX(this Transform @this, float x)
    {
        Vector3 temp = @this.position;
        temp.x = x;
        @this.position = temp;
    }
    public static void SetPositionY(this Transform @this, float y)
    {
        Vector3 temp = @this.position;
        temp.y = y;
        @this.position = temp;
    }
    public static void SetPositionZ(this Transform @this, float z)
    {
        Vector3 temp = @this.position;
        temp.z = z;
        @this.position = temp;
    }
    public static void SetLocalPositionX(this Transform @this, float x)
    {
        Vector3 temp = @this.localPosition;
        temp.x = x;
        @this.localPosition = temp;
    }
    public static void SetLocalPositionY(this Transform @this, float y)
    {
        Vector3 temp = @this.localPosition;
        temp.y = y;
        @this.localPosition = temp;
    }
    public static void SetLocalPositionZ(this Transform @this, float z)
    {
        Vector3 temp = @this.localPosition;
        temp.z = z;
        @this.localPosition = temp;
    }
    public static void SetAngleX(this Transform @this, float x)
    {
        Vector3 angles = @this.rotation.eulerAngles;
        angles.x = x;
        @this.rotation = Quaternion.Euler(angles);
    }
    public static void SetAngleY(this Transform @this, float y)
    {
        Vector3 angles = @this.rotation.eulerAngles;
        angles.y = y;
        @this.rotation = Quaternion.Euler(angles);
    }
    public static void SetAngleZ(this Transform @this, float z)
    {
        Vector3 angles = @this.rotation.eulerAngles;
        angles.z = z;
        @this.rotation = Quaternion.Euler(angles);
    }
    public static void SetLocalAngleX(this Transform @this, float x)
    {
        Vector3 angles = @this.localRotation.eulerAngles;
        angles.x = x;
        @this.localRotation = Quaternion.Euler(angles);
    }
    public static void SetLocalAngleY(this Transform @this, float y)
    {
        Vector3 angles = @this.localRotation.eulerAngles;
        angles.y = y;
        @this.localRotation = Quaternion.Euler(angles);
    }
    public static void SetLocalAngleZ(this Transform @this, float z)
    {
        Vector3 angles = @this.localRotation.eulerAngles;
        angles.z = z;
        @this.localRotation = Quaternion.Euler(angles);
    }
    public static void SetLocalScaleX(this Transform @this, float x)
    {
        Vector3 temp = @this.localScale;
        temp.x = x;
        @this.localScale = temp;
    }
    public static void SetLocalScaleY(this Transform @this, float y)
    {
        Vector3 temp = @this.localScale;
        temp.y = y;
        @this.localScale = temp;
    }
    public static void SetLocalScaleZ(this Transform @this, float z)
    {
        Vector3 temp = @this.localScale;
        temp.z = z;
        @this.localScale = temp;
    }
    #endregion
}
#endif