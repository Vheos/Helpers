#if UNITY

#pragma warning disable IDE1006 // Naming Styles

namespace Vheos.Helpers.Math;
using System.Globalization;
using System.Runtime.CompilerServices;

public struct Vector4Int : IEquatable<Vector4Int>, IFormattable
{
    // Constants
    public const float kEpsilon = 0.00001F;

    // Publics
    public int x
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set;
    }
    public int y
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set;
    }
    public int z
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set;
    }
    public int w
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set;
    }

    public int this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return index switch
            {
                0 => x,
                1 => y,
                2 => z,
                3 => w,
                _ => throw new IndexOutOfRangeException($"Invalid Vector4Int index addressed: {index}!"),
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            switch (index)
            {
                case 0: x = value; break;
                case 1: y = value; break;
                case 2: z = value; break;
                default: throw new IndexOutOfRangeException($"Invalid Vector4Int index addressed: {index}!");
            }
        }
    }
    public float magnitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Mathf.Sqrt(x * x + y * y + z * z + w * w);
    }
    public int sqrMagnitude
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => x * x + y * y + z * z + w * w;
    }
    public Vector4 normalized
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            float mag = magnitude;
            return mag > kEpsilon
                ? new(x / mag, y / mag, z / mag, w / mag)
                : Vector4.zero;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Set(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Scale(Vector4Int scale)
    {
        x *= scale.x;
        y *= scale.y;
        z *= scale.z;
        w *= scale.w;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Clamp(Vector4Int min, Vector4Int max)
    {
        x = System.Math.Max(min.x, x);
        x = System.Math.Min(max.x, x);
        y = System.Math.Max(min.y, y);
        y = System.Math.Min(max.y, y);
        z = System.Math.Max(min.z, z);
        z = System.Math.Min(max.z, z);

    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Distance(Vector4Int a, Vector4Int b)
    => (a - b).magnitude;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int Min(Vector4Int a, Vector4Int b)
    => new(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y), Mathf.Min(a.z, b.z), Mathf.Min(a.w, b.w));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int Max(Vector4Int a, Vector4Int b)
    => new(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y), Mathf.Max(a.z, b.z), Mathf.Min(a.w, b.w));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int Scale(Vector4Int a, Vector4Int b)
    => new(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int FloorToInt(Vector4 v)
    => new(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z), Mathf.FloorToInt(v.w));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int CeilToInt(Vector4 v)
    => new(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z), Mathf.CeilToInt(v.w));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int RoundToInt(Vector4 v)
    => new(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z), Mathf.RoundToInt(v.w));

    private static readonly Vector4Int s_maxValueVector = new(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
    private static readonly Vector4Int s_minValueVector = new(int.MinValue, int.MinValue, int.MinValue, int.MinValue);

    // Initializers
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector4Int(int x, int y, int z, int w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector4Int(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        w = 0;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector4Int(int x, int y)
    {
        this.x = x;
        this.y = y;
        z = 0;
        w = 0;
    }
    public static Vector4Int zero
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get;
    } = new(0, 0, 0, 0);
    public static Vector4Int one
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get;
    } = new(1, 1, 1, 1);
    public static Vector4 maxValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => s_maxValueVector;
    }
    public static Vector4 minValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => s_minValueVector;
    }

    // Operators
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Vector4(Vector4Int v)
    => new(v.x, v.y, v.z, v.w);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Vector3(Vector4Int v)
    => new(v.x, v.y, v.z);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Vector2(Vector4Int v)
    => new(v.x, v.y);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Vector3Int(Vector4Int v)
    => new(v.x, v.y, v.z);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Vector2Int(Vector4Int v)
    => new(v.x, v.y);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator +(Vector4Int a, Vector4Int b)
    => new(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator -(Vector4Int a)
    => new(-a.x, -a.y, -a.z, -a.w);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator -(Vector4Int a, Vector4Int b)
    => new(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator *(Vector4Int a, Vector4Int b)
    => new(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator *(Vector4Int a, int b)
    => new(a.x * b, a.y * b, a.z * b, a.w * b);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator *(int a, Vector4Int b)
    => new(a * b.x, a * b.y, a * b.z, a * b.z);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4Int operator /(Vector4Int a, int b)
    => new(a.x / b, a.y / b, a.z / b, a.w / b);

    // IEquatable
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object other) => other is Vector4Int asVector && Equals(asVector);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Vector4Int other)
    => this == other;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode()
    {
        var yHash = y.GetHashCode();
        var zHash = z.GetHashCode();
        return x.GetHashCode() ^ (yHash << 4) ^ (yHash >> 28) ^ (zHash >> 4) ^ (zHash << 28);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vector4Int lhs, Vector4Int rhs)
    => lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vector4Int lhs, Vector4Int rhs)
    => !(lhs == rhs);

    // IFormattable
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    => ToString(null, null);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(string format)
    => ToString(format, null);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(string format, IFormatProvider formatProvider)
    {
        if (formatProvider == null)
            formatProvider = CultureInfo.InvariantCulture.NumberFormat;
        return $"({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)}, {z.ToString(format, formatProvider)}, {w.ToString(format, formatProvider)})";
    }
}
#endif