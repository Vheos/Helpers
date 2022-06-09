#if UNITY
namespace Vheos.Helpers.Math;

public static class Extensions_Quaternion
{
    #region COMMON
    /// <summary> Returns the opposite of this rotation. </summary>
    public static Quaternion Neg(this Quaternion @this)
    => Quaternion.Inverse(@this);
    #endregion
    #region COMMON, QUATERNION
    /// <summary> Adds a to this rotation. </summary>
    public static Quaternion Add(this Quaternion @this, Quaternion a)
    => a * @this;
    /// <summary> Subtracts a from this rotation. </summary>
    public static Quaternion Sub(this Quaternion @this, Quaternion a)
    => a.Neg() * @this;

    /// <summary> Lerps from this rotation to a at alpha b. </summary>
    public static Quaternion Lerp(this Quaternion @this, Quaternion a, float b)
    => Quaternion.LerpUnclamped(@this, a, b);
    /// <summary> Lerps from this rotation to a at alpha b (clamped between 0 and 1). </summary>
    public static Quaternion LerpClamped(this Quaternion @this, Quaternion a, float b)
    => Quaternion.Lerp(@this, a, b);
    /// <summary> Spherically lerps from this rotation to a at alpha b. </summary>
    public static Quaternion SLerp(this Quaternion @this, Quaternion a, float b)
    => Quaternion.SlerpUnclamped(@this, a, b);
    /// <summary> Spherically lerps from this rotation to a at alpha b (clamped between 0 and 1). </summary>
    public static Quaternion SLerpClamped(this Quaternion @this, Quaternion a, float b)
    => Quaternion.Slerp(@this, a, b);
    #endregion
    #region COMMON, VECTOR
    /// <summary> Adds angles a to this rotation. </summary>
    public static Quaternion Add(this Quaternion @this, Vector3 a)
    => Quaternion.Euler(a) * @this;
    /// <summary> Subtracts angles a from this rotation. </summary>
    public static Quaternion Sub(this Quaternion @this, Vector3 a)
    => Quaternion.Euler(-a) * @this;

    /// <summary> Lerps from this rotation to angles a at alpha b. </summary>
    public static Quaternion Lerp(this Quaternion @this, Vector3 a, float b)
    => Quaternion.LerpUnclamped(@this, Quaternion.Euler(a), b);
    /// <summary> Lerps from this rotation to angles a at alpha b (clamped between 0 and 1). </summary>
    public static Quaternion LerpClamped(this Quaternion @this, Vector3 a, float b)
    => Quaternion.Lerp(@this, Quaternion.Euler(a), b);
    /// <summary> Spherically lerps from this rotation to angles a at alpha b. </summary>
    public static Quaternion SLerp(this Quaternion @this, Vector3 a, float b)
    => Quaternion.SlerpUnclamped(@this, Quaternion.Euler(a), b);
    /// <summary> Spherically lerps from this rotation to angles a at alpha b (clamped between 0 and 1). </summary>
    public static Quaternion SLerpClamped(this Quaternion @this, Vector3 a, float b)
    => Quaternion.Slerp(@this, Quaternion.Euler(a), b);
    #endregion


    #region UNIQUE
    /// <summary> Returns right direction relative to this rotation. </summary>
    public static Vector3 Right(this Quaternion @this)
    => Vector3.right.Rotate(@this);
    /// <summary> Returns left direction relative to this rotation. </summary>
    public static Vector3 Left(this Quaternion @this)
    => Vector3.left.Rotate(@this);
    /// <summary> Returns up direction relative to this rotation. </summary>
    public static Vector3 Up(this Quaternion @this)
    => Vector3.up.Rotate(@this);
    /// <summary> Returns down direction relative to this rotation. </summary>
    public static Vector3 Down(this Quaternion @this)
    => Vector3.down.Rotate(@this);
    /// <summary> Returns far direction relative to this rotation. </summary>
    public static Vector3 Far(this Quaternion @this)
    => Vector3.forward.Rotate(@this);
    /// <summary> Returns near direction relative to this rotation. </summary>
    public static Vector3 Near(this Quaternion @this)
    => Vector3.back.Rotate(@this);

    /// <summary> Returns angle from this rotation to a. </summary>
    public static float AngleTo(this Quaternion @this, Quaternion a)
    => Quaternion.Angle(@this, a);
    /// <summary> Returns angle created by this rotation. </summary>
    public static float AngleToIdentity(this Quaternion @this)
    => Quaternion.Angle(@this, Quaternion.identity);

    /// <summary> Returns this rotation's euler angles. </summary>
    public static Vector3 ToAngles(this Quaternion @this)
    => @this.eulerAngles;
    #endregion

}
#endif