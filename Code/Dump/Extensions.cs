namespace Vheos.Helpers.Dump;
using System.Reflection;
using System.Text;

public static class Extensions
{
    /// <summary> Returns a string of tab-separated data of all members of this object. </summary>
    public static string Dump
    (
        this object @this,
        Type type = null,
        string[] blacklist = null,
        MemberData data = MemberData.Values,
        ClassMembers members = ClassMembers.FieldsAndProperties,
        ScopeModifiers scopeModifiers = ScopeModifiers.Instance,
        AccessModifiers accessModifiers = AccessModifiers.All
    )
    {
        // Cache
        if (type == null)
            type = @this.GetType();
        BindingFlags bindingFlags = accessModifiers.ToBindingFlags() | scopeModifiers.ToBindingFlags();
        StringBuilder builder = new();

        // Fields
        if (members.HasFlag(ClassMembers.Fields))
            foreach (var fieldInfo in type.GetFields(bindingFlags))
            {
                if (blacklist != null && blacklist.Contains(fieldInfo.Name))
                    continue;

                if (data.HasFlag(MemberData.Names))
                    builder.Append(fieldInfo.Name).Append("\t");
                if (data.HasFlag(MemberData.Types))
                    builder.Append(fieldInfo.FieldType.Name).Append("\t");
                if (data.HasFlag(MemberData.Values))
                {
                    object value = fieldInfo.GetValue(@this);
                    builder.Append(value != null ? value.ToString() : "null").Append("\t");
                }
            }

        // Properties
        if (members.HasFlag(ClassMembers.Properties))
            foreach (var propInfo in type.GetProperties(bindingFlags))
            {
                if (blacklist != null && blacklist.Contains(propInfo.Name))
                    continue;

                if (data.HasFlag(MemberData.Names))
                    builder.Append(propInfo.Name).Append("\t");
                if (data.HasFlag(MemberData.Types))
                    builder.Append(propInfo.PropertyType.Name).Append("\t");
                if (data.HasFlag(MemberData.Values))
                {
                    object value;
                    try
                    {
                        value = propInfo.GetValue(@this, null);
                    }
                    catch
                    {
                        value = "[EXCEPTION]";
                    }
                    builder.Append(value != null ? value.ToString() : "null").Append("\t");
                }
            }

        // Return
        return builder.ToString();
    }

    /// <summary> Returns a string of tab-separated data of all members of this type. </summary>
    public static string Dump
    (
        this Type @this,
        string[] blacklist = null,
        MemberData data = MemberData.Names,
        ClassMembers members = ClassMembers.FieldsAndProperties,
        ScopeModifiers scopeModifiers = ScopeModifiers.Instance,
        AccessModifiers accessModifiers = AccessModifiers.All
    )
    => Dump(null, @this, blacklist, data, members, scopeModifiers, accessModifiers);

    public static BindingFlags ToBindingFlags(this AccessModifiers @this)
    {
        BindingFlags flags = 0;
        if (@this.HasFlag(AccessModifiers.Private))
            flags |= BindingFlags.NonPublic;
        if (@this.HasFlag(AccessModifiers.Public))
            flags |= BindingFlags.Public;
        return flags;
    }

    public static BindingFlags ToBindingFlags(this ScopeModifiers @this)
    {
        BindingFlags flags = 0;
        if (@this.HasFlag(ScopeModifiers.Instance))
            flags |= BindingFlags.Instance;
        if (@this.HasFlag(ScopeModifiers.Static))
            flags |= BindingFlags.Static;
        return flags;
    }
}
