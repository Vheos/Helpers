namespace Vheos.Helpers.Dump;

[Flags]
public enum ClassMembers
{
    None = 0,
    Fields = 1 << 1,
    Properties = 1 << 2,
    Methods = 1 << 3,
    FieldsAndProperties = Fields | Properties,
    FieldsAndMethods = Fields | Methods,
    PropertiesAndMethods = Properties | Methods,
    All = Fields | Properties | Methods,
}
