#if UNITY
namespace Vheos.Helpers.UnityObjects
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using Vheos.Helpers.Math;
    using Vheos.Helpers.Common;

    static public class Extensions
    {

        #region ANIMATION_CURVE
        /// <summary> Returns value of the first key in this curve. </summary>
        static public float StartValue(this AnimationCurve @this)
        => @this.keys[0].value;
        /// <summary> Returns value of the last key in this curve. </summary>
        static public float EndValue(this AnimationCurve @this)
        => @this.keys[@this.keys.Length - 1].value;
        /// <summary> Returns time of the first key in this curve. </summary>
        static public float StartTime(this AnimationCurve @this)
        => @this.keys[0].time;
        /// <summary> Returns time of the last key in this curve. </summary>
        static public float EndTime(this AnimationCurve @this)
        => @this.keys[@this.keys.Length - 1].time;
        /// <summary> Returns the duration of this curve. </summary>
        static public float Duration(this AnimationCurve @this)
        => @this.EndTime() - @this.StartTime();
        /// <summary> Tests whether this curve has at least 2 keys. </summary>
        static public bool IsValid(this AnimationCurve @this)
        => @this.length >= 2;
#if !NET35
        /// <summary> Adds keys a to this curve with all tangents and weights set to 0. </summary>
        static public void AddLinearKeys(this AnimationCurve @this, params (float Time, float Value)[] a)
        {
            for (int i = 0; i < a.Length; i++)
                @this.AddKey(new Keyframe(a[i].Time, a[i].Value, 0f, 0f));
        }
#endif
        #endregion

        #region INPUT
        /// <summary> Checks if this key has just been pressed. </summary>
        static public bool Pressed(this KeyCode @this)
        => Input.GetKeyDown(@this);
        /// <summary> Checks if this key has just been released. </summary>
        static public bool Released(this KeyCode @this)
        => Input.GetKeyUp(@this);
        /// <summary> Checks if this key is held down. </summary>
        static public bool Down(this KeyCode @this)
        => Input.GetKey(@this);
        /// <summary> Checks if this key is resting. </summary>
        static public bool Up(this KeyCode @this)
        => !Input.GetKey(@this);
        #endregion

        #region RAYCAST_HIT
        /// <summary> Returns this array of hits sorted by distance from point a. </summary>
        static public RaycastHit[] SortedByDistanceFrom(this RaycastHit[] @this, Vector3 a)
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
        static public RaycastHit[] SortedByDistanceFrom(this RaycastHit[] @this, UnityEngine.GameObject a)
        => @this.SortedByDistanceFrom(a.transform.position);
        /// <summary> Returns this array of hits sorted by distance from object a. </summary>
        static public RaycastHit[] SortedByDistanceFrom(this RaycastHit[] @this, Component a)
        => @this.SortedByDistanceFrom(a.gameObject);
        #endregion

        #region MIDPOINT
        static public Vector3 Midpoint<T>(this IEnumerable<T> @this, Func<T, Vector3> positionFunc)
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
        static public Vector3 Midpoint(this IEnumerable<UnityEngine.GameObject> @this)
        => Midpoint(@this, GameObject => GameObject.transform.position);
        static public Vector3 Midpoint(this IEnumerable<Component> @this)
        => Midpoint(@this, component => component.transform.position);
        #endregion

        #region TRANSFORM
        static public void SetPositionX(this Transform @this, float x)
        {
            Vector3 temp = @this.position;
            temp.x = x;
            @this.position = temp;
        }
        static public void SetPositionY(this Transform @this, float y)
        {
            Vector3 temp = @this.position;
            temp.y = y;
            @this.position = temp;
        }
        static public void SetPositionZ(this Transform @this, float z)
        {
            Vector3 temp = @this.position;
            temp.z = z;
            @this.position = temp;
        }
        static public void SetLocalPositionX(this Transform @this, float x)
        {
            Vector3 temp = @this.localPosition;
            temp.x = x;
            @this.localPosition = temp;
        }
        static public void SetLocalPositionY(this Transform @this, float y)
        {
            Vector3 temp = @this.localPosition;
            temp.y = y;
            @this.localPosition = temp;
        }
        static public void SetLocalPositionZ(this Transform @this, float z)
        {
            Vector3 temp = @this.localPosition;
            temp.z = z;
            @this.localPosition = temp;
        }
        static public void SetAngleX(this Transform @this, float x)
        {
            Vector3 angles = @this.rotation.eulerAngles;
            angles.x = x;
            @this.rotation = Quaternion.Euler(angles);
        }
        static public void SetAngleY(this Transform @this, float y)
        {
            Vector3 angles = @this.rotation.eulerAngles;
            angles.y = y;
            @this.rotation = Quaternion.Euler(angles);
        }
        static public void SetAngleZ(this Transform @this, float z)
        {
            Vector3 angles = @this.rotation.eulerAngles;
            angles.z = z;
            @this.rotation = Quaternion.Euler(angles);
        }
        static public void SetLocalAngleX(this Transform @this, float x)
        {
            Vector3 angles = @this.localRotation.eulerAngles;
            angles.x = x;
            @this.localRotation = Quaternion.Euler(angles);
        }
        static public void SetLocalAngleY(this Transform @this, float y)
        {
            Vector3 angles = @this.localRotation.eulerAngles;
            angles.y = y;
            @this.localRotation = Quaternion.Euler(angles);
        }
        static public void SetLocalAngleZ(this Transform @this, float z)
        {
            Vector3 angles = @this.localRotation.eulerAngles;
            angles.z = z;
            @this.localRotation = Quaternion.Euler(angles);
        }
        static public void SetLocalScaleX(this Transform @this, float x)
        {
            Vector3 temp = @this.localScale;
            temp.x = x;
            @this.localScale = temp;
        }
        static public void SetLocalScaleY(this Transform @this, float y)
        {
            Vector3 temp = @this.localScale;
            temp.y = y;
            @this.localScale = temp;
        }
        static public void SetLocalScaleZ(this Transform @this, float z)
        {
            Vector3 temp = @this.localScale;
            temp.z = z;
            @this.localScale = temp;
        }
        #endregion
    }
}
#endif