#if UNITY
namespace Vheos.Helpers.Math
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using UnityEngine;
    using Math = System.Math;

    public struct Vector4Int : IEquatable<Vector4Int>, IFormattable
    {
        // Constants
        public const float kEpsilon = 0.00001F;

        // Publics
        public int x
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _x;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _x = value;
        }
        public int y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _y;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _y = value;
        }
        public int z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _z;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _z = value;
        }
        public int w
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _w;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _w = value;
        }

        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return index switch
                {
                    0 => _x,
                    1 => _y,
                    2 => _z,
                    3 => _w,
                    _ => throw new IndexOutOfRangeException($"Invalid Vector4Int index addressed: {index}!"),
                };
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                switch (index)
                {
                    case 0: _x = value; break;
                    case 1: _y = value; break;
                    case 2: _z = value; break;
                    default: throw new IndexOutOfRangeException($"Invalid Vector4Int index addressed: {index}!");
                }
            }
        }
        public float magnitude
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Mathf.Sqrt(_x * _x + _y * _y + _z * _z + _w * _w);
        }
        public int sqrMagnitude
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _x * _x + _y * _y + _z * _z + _w * _w;
        }
        public Vector4 normalized
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                float mag = magnitude;
                return mag > kEpsilon
                    ? new(_x / mag, _y / mag, _z / mag, _w / mag)
                    : Vector4.zero;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Scale(Vector4Int scale)
        {
            _x *= scale._x;
            _y *= scale._y;
            _z *= scale._z;
            _w *= scale._w;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clamp(Vector4Int min, Vector4Int max)
        {
            _x = Math.Max(min._x, _x);
            _x = Math.Min(max._x, _x);
            _y = Math.Max(min._y, _y);
            _y = Math.Min(max._y, _y);
            _z = Math.Max(min._z, _z);
            _z = Math.Min(max._z, _z);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(Vector4Int a, Vector4Int b)
        => (a - b).magnitude;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int Min(Vector4Int a, Vector4Int b)
        => new(Mathf.Min(a._x, b._x), Mathf.Min(a._y, b._y), Mathf.Min(a._z, b._z), Mathf.Min(a._w, b._w));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int Max(Vector4Int a, Vector4Int b)
        => new(Mathf.Max(a._x, b._x), Mathf.Max(a._y, b._y), Mathf.Max(a._z, b._z), Mathf.Min(a._w, b._w));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int Scale(Vector4Int a, Vector4Int b)
        => new(a._x * b._x, a._y * b._y, a._z * b._z, a._w * b._w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int FloorToInt(Vector4 v)
        => new(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z), Mathf.FloorToInt(v.w));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int CeilToInt(Vector4 v)
        => new(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z), Mathf.CeilToInt(v.w));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int RoundToInt(Vector4 v)
        => new(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z), Mathf.RoundToInt(v.w));

        // Privates
        private int _x;
        private int _y;
        private int _z;
        private int _w;
        private static readonly Vector4Int s_Zero = new(0, 0, 0, 0);
        private static readonly Vector4Int s_One = new(1, 1, 1, 1);
        private static readonly Vector4Int s_maxValueVector = new(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
        private static readonly Vector4Int s_minValueVector = new(int.MinValue, int.MinValue, int.MinValue, int.MinValue);

        // Initializers
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int(int x, int y, int z, int w)
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
            _w = 0;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int(int x, int y)
        {
            _x = x;
            _y = y;
            _z = 0;
            _w = 0;
        }
        public static Vector4Int zero
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => s_Zero;
        }
        public static Vector4Int one
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => s_One;
        }
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
        => new(v._x, v._y, v._z, v._w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3(Vector4Int v)
        => new(v._x, v._y, v._z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2(Vector4Int v)
        => new(v._x, v._y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int(Vector4Int v)
        => new(v._x, v._y, v._z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int(Vector4Int v)
        => new(v._x, v._y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator +(Vector4Int a, Vector4Int b)
        => new(a._x + b._x, a._y + b._y, a._z + b._z, a._w + b._w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator -(Vector4Int a)
        => new(-a._x, -a._y, -a._z, -a._w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator -(Vector4Int a, Vector4Int b)
        => new(a._x - b._x, a._y - b._y, a._z - b._z, a._w - b._w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator *(Vector4Int a, Vector4Int b)
        => new(a._x * b._x, a._y * b._y, a._z * b._z, a._w * b._w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator *(Vector4Int a, int b)
        => new(a._x * b, a._y * b, a._z * b, a._w * b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator *(int a, Vector4Int b)
        => new(a * b._x, a * b._y, a * b._z, a * b._z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int operator /(Vector4Int a, int b)
        => new(a._x / b, a._y / b, a._z / b, a._w / b);

        // IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object other)
        {
            if (other is not Vector4Int)
                return false;

            return Equals((Vector4Int)other);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int other)
        => this == other;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            var yHash = _y.GetHashCode();
            var zHash = _z.GetHashCode();
            return _x.GetHashCode() ^ (yHash << 4) ^ (yHash >> 28) ^ (zHash >> 4) ^ (zHash << 28);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4Int lhs, Vector4Int rhs)
        => lhs._x == rhs._x && lhs._y == rhs._y && lhs._z == rhs._z;
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
            return $"({_x.ToString(format, formatProvider)}, {_y.ToString(format, formatProvider)}, {_z.ToString(format, formatProvider)}, {_w.ToString(format, formatProvider)})";
        }
    }
}
#endif