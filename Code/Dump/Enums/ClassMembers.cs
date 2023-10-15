namespace Vheos.Helpers.Dump;

[Flags]
public enum ClassMembers
{
    None = 0,
    Fields = 1 << 0,
    Properties = 1 << 1,
    Methods = 1 << 0,
    FieldsAndProperties = Fields | Properties,
    FieldsAndMethods = Fields | Methods,
    PropertiesAndMethods = Properties | Methods,
    All = Fields | Properties | Methods,
}
