namespace Vheos.Helpers.Reflection;
using System.Reflection;

public static class Extensions
{
    #region INSTANCE FIELD
    public static TReturn GetField<TReturn>(this object @this, string name)
    => (TReturn)@this.GetType().GetField(name, InstanceMembers).GetValue(@this);
    public static TReturn GetField<TReturn, TBase>(this object @this, string name)
    => (TReturn)typeof(TBase).GetField(name, InstanceMembers).GetValue(@this);
    public static void SetField<TValue>(this object @this, string name, TValue value)
    => @this.GetType().GetField(name, InstanceMembers).SetValue(@this, value);
    public static void SetField<TValue, TBase>(this object @this, string name, TValue value)
    => typeof(TBase).GetField(name, InstanceMembers).SetValue(@this, value);

    public static bool TryGetField<TReturn>(this object @this, string name, out TReturn value)
    {
        if (@this.GetType().GetField(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    public static bool TryGetField<TReturn, TBase>(this object @this, string name, out TReturn value)
    {
        if (typeof(TBase).GetField(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    public static bool TrySetField<TValue>(this object @this, string name, TValue value)
    {
        if (@this.GetType().GetField(name, InstanceMembers).TryNonNull(out var info))
        {
            info.SetValue(@this, value);
            return true;
        }

        return false;
    }
    public static bool TrySetField<TValue, TBase>(this object @this, string name, TValue value)
    {
        if (typeof(TBase).GetField(name, InstanceMembers).TryNonNull(out var info))
        {
            info.SetValue(@this, value);
            return true;
        }

        return false;
    }
    #endregion
    #region INSTANCE PROPERTY
    public static TReturn GetProperty<TReturn>(this object @this, string name)
    => (TReturn)@this.GetType().GetProperty(name, InstanceMembers).GetValue(@this, null);
    public static TReturn GetProperty<TReturn, TBase>(this object @this, string name)
    => (TReturn)typeof(TBase).GetType().GetProperty(name, InstanceMembers).GetValue(@this, null);
    public static void SetProperty<TValue>(this object @this, string name, TValue value)
    => @this.GetType().GetProperty(name, InstanceMembers).SetValue(@this, value, null);
    public static void SetProperty<TValue, TBase>(this object @this, string name, TValue value)
    => typeof(TBase).GetProperty(name, InstanceMembers).SetValue(@this, value, null);

    public static bool TryGetProperty<TReturn>(this object @this, string name, out TReturn value)
    {
        if (@this.GetType().GetProperty(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this, null).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    public static bool TryGetProperty<TReturn, TBase>(this object @this, string name, out TReturn value)
    {
        if (typeof(TBase).GetProperty(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this, null).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    public static bool TrySetProperty<TValue>(this object @this, string name, TValue value)
    {
        if (@this.GetType().GetProperty(name, InstanceMembers).TryNonNull(out var info))
        {
            info.SetValue(@this, value, null);
            return true;
        }

        return false;
    }
    public static bool TrySetProperty<TValue, TBase>(this object @this, string name, TValue value)
    {
        if (typeof(TBase).GetProperty(name, InstanceMembers).TryNonNull(out var info))
        {
            info.SetValue(@this, value, null);
            return true;
        }

        return false;
    }
    #endregion
    #region INSTANCE METHOD
    public static TReturn InvokeMethod<TReturn>(this object @this, string name, params object[] parameters)
    => (TReturn)@this.GetType().GetMethod(name, InstanceMembers).Invoke(@this, parameters);
    public static TReturn InvokeMethod<TReturn, TBase>(this object @this, string name, params object[] parameters)
    => (TReturn)typeof(TBase).GetMethod(name, InstanceMembers).Invoke(@this, parameters);
    public static void InvokeMethodVoid(this object @this, string name, params object[] parameters)
    => @this.GetType().GetMethod(name, InstanceMembers).Invoke(@this, parameters);
    public static void InvokeMethodVoid<TBase>(this object @this, string name, params object[] parameters)
    => typeof(TBase).GetMethod(name, InstanceMembers).Invoke(@this, parameters);

    public static bool TryInvokeMethod<TReturn>(this object @this, string name, object[] parameters, out TReturn returnValue)
    {
        if (@this.GetType().GetMethod(name, InstanceMembers).TryNonNull(out var info)
        && info.GetParameters().Length == parameters.Length)
        {
            returnValue = (TReturn)info.Invoke(@this, parameters);
            return true;
        }

        returnValue = default;
        return false;
    }
    public static bool TryInvokeMethod<TReturn, TBase>(this object @this, string name, object[] parameters, out TReturn returnValue)
    {
        if (typeof(TBase).GetMethod(name, InstanceMembers).TryNonNull(out var info)
        && info.GetParameters().Length == parameters.Length)
        {
            returnValue = (TReturn)info.Invoke(@this, parameters);
            return true;
        }

        returnValue = default;
        return false;
    }
    public static bool TryInvokeMethodVoid(this object @this, string name, params object[] parameters)
    {
        if (@this.GetType().GetMethod(name, InstanceMembers).TryNonNull(out var info)
        && info.GetParameters().Length == parameters.Length)
        {
            info.Invoke(@this, parameters);
            return true;
        }

        return false;
    }
    public static bool TryInvokeMethodVoid<TBase>(this object @this, string name, params object[] parameters)
    {
        if (typeof(TBase).GetMethod(name, InstanceMembers).TryNonNull(out var info)
        && info.GetParameters().Length == parameters.Length)
        {
            info.Invoke(@this, parameters);
            return true;
        }

        return false;
    }
    #endregion


    #region STATIC FIELD
    public static TReturn GetField<TReturn>(this Type type, string fieldName)
    => (TReturn)type.GetField(fieldName, StaticMembers).GetValue(null);
    public static void SetField<TValue>(this Type type, string fieldName, TValue value)
    => type.GetField(fieldName, StaticMembers).SetValue(null, value);
    #endregion
    #region STATIC PROPERTY
    public static TReturn GetProperty<TReturn>(this Type type, string propName)
    => (TReturn)type.GetProperty(propName, StaticMembers).GetValue(null, null);
    public static void SetProperty<TValue>(this Type type, string propName, TValue value)
    => type.GetProperty(propName, StaticMembers).SetValue(null, value, null);
    #endregion
    #region STATIC METHOD
    public static TReturn InvokeMethod<TReturn>(this Type type, string methodName, params object[] methodParams)
    => (TReturn)type.GetMethod(methodName, StaticMembers).Invoke(null, methodParams);
    public static void InvokeMethodVoid(this Type type, string methodName, params object[] methodParams)
    => type.GetMethod(methodName, StaticMembers).Invoke(null, methodParams);
    #endregion


    #region PRIVATE UTILITIES
    private static BindingFlags InstanceMembers
    => BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
    private static BindingFlags StaticMembers
    => BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    #endregion
}
