namespace Vheos.Helpers.Reflection;
using System.Reflection;

static public class Extensions
{
    #region INSTANCE FIELD
    static public TReturn GetField<TReturn>(this object @this, string name)
    => (TReturn)@this.GetType().GetField(name, InstanceMembers).GetValue(@this);
    static public TReturn GetField<TReturn, TBase>(this object @this, string name)
    => (TReturn)typeof(TBase).GetField(name, InstanceMembers).GetValue(@this);
    static public void SetField<TValue>(this object @this, string name, TValue value)
    => @this.GetType().GetField(name, InstanceMembers).SetValue(@this, value);
    static public void SetField<TValue, TBase>(this object @this, string name, TValue value)
    => typeof(TBase).GetField(name, InstanceMembers).SetValue(@this, value);

    static public bool TryGetField<TReturn>(this object @this, string name, out TReturn value)
    {
        if (@this.GetType().GetField(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    static public bool TryGetField<TReturn, TBase>(this object @this, string name, out TReturn value)
    {
        if (typeof(TBase).GetField(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    static public bool TrySetField<TValue>(this object @this, string name, TValue value)
    {
        if (@this.GetType().GetField(name, InstanceMembers).TryNonNull(out var info))
        {
            info.SetValue(@this, value);
            return true;
        }

        return false;
    }
    static public bool TrySetField<TValue, TBase>(this object @this, string name, TValue value)
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
    static public TReturn GetProperty<TReturn>(this object @this, string name)
    => (TReturn)@this.GetType().GetProperty(name, InstanceMembers).GetValue(@this, null);
    static public TReturn GetProperty<TReturn, TBase>(this object @this, string name)
    => (TReturn)typeof(TBase).GetType().GetProperty(name, InstanceMembers).GetValue(@this, null);
    static public void SetProperty<TValue>(this object @this, string name, TValue value)
    => @this.GetType().GetProperty(name, InstanceMembers).SetValue(@this, value, null);
    static public void SetProperty<TValue, TBase>(this object @this, string name, TValue value)
    => typeof(TBase).GetProperty(name, InstanceMembers).SetValue(@this, value, null);

    static public bool TryGetProperty<TReturn>(this object @this, string name, out TReturn value)
    {
        if (@this.GetType().GetProperty(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this, null).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    static public bool TryGetProperty<TReturn, TBase>(this object @this, string name, out TReturn value)
    {
        if (typeof(TBase).GetProperty(name, InstanceMembers).TryNonNull(out var info)
        && info.GetValue(@this, null).TryCast(out value))
            return true;

        value = default;
        return false;
    }
    static public bool TrySetProperty<TValue>(this object @this, string name, TValue value)
    {
        if (@this.GetType().GetProperty(name, InstanceMembers).TryNonNull(out var info))
        {
            info.SetValue(@this, value, null);
            return true;
        }

        return false;
    }
    static public bool TrySetProperty<TValue, TBase>(this object @this, string name, TValue value)
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
    static public TReturn InvokeMethod<TReturn>(this object @this, string name, params object[] parameters)
    => (TReturn)@this.GetType().GetMethod(name, InstanceMembers).Invoke(@this, parameters);
    static public TReturn InvokeMethod<TReturn, TBase>(this object @this, string name, params object[] parameters)
    => (TReturn)typeof(TBase).GetMethod(name, InstanceMembers).Invoke(@this, parameters);
    static public void InvokeMethodVoid(this object @this, string name, params object[] parameters)
    => @this.GetType().GetMethod(name, InstanceMembers).Invoke(@this, parameters);
    static public void InvokeMethodVoid<TBase>(this object @this, string name, params object[] parameters)
    => typeof(TBase).GetMethod(name, InstanceMembers).Invoke(@this, parameters);

    static public bool TryInvokeMethod<TReturn>(this object @this, string name, object[] parameters, out TReturn returnValue)
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
    static public bool TryInvokeMethod<TReturn, TBase>(this object @this, string name, object[] parameters, out TReturn returnValue)
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
    static public bool TryInvokeMethodVoid(this object @this, string name, params object[] parameters)
    {
        if (@this.GetType().GetMethod(name, InstanceMembers).TryNonNull(out var info)
        && info.GetParameters().Length == parameters.Length)
        {
            info.Invoke(@this, parameters);
            return true;
        }

        return false;
    }
    static public bool TryInvokeMethodVoid<TBase>(this object @this, string name, params object[] parameters)
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
    static public TReturn GetField<TReturn>(this Type type, string fieldName)
    => (TReturn)type.GetField(fieldName, StaticMembers).GetValue(null);
    static public void SetField<TValue>(this Type type, string fieldName, TValue value)
    => type.GetField(fieldName, StaticMembers).SetValue(null, value);
    #endregion
    #region STATIC PROPERTY
    static public TReturn GetProperty<TReturn>(this Type type, string propName)
    => (TReturn)type.GetProperty(propName, StaticMembers).GetValue(null, null);
    static public void SetProperty<TValue>(this Type type, string propName, TValue value)
    => type.GetProperty(propName, StaticMembers).SetValue(null, value, null);
    #endregion
    #region STATIC METHOD
    static public TReturn InvokeMethod<TReturn>(this Type type, string methodName, params object[] methodParams)
    => (TReturn)type.GetMethod(methodName, StaticMembers).Invoke(null, methodParams);
    static public void InvokeMethodVoid(this Type type, string methodName, params object[] methodParams)
    => type.GetMethod(methodName, StaticMembers).Invoke(null, methodParams);
    #endregion


    #region PRIVATE UTILITIES
    static private BindingFlags InstanceMembers
    => BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
    static private BindingFlags StaticMembers
    => BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    #endregion
}
