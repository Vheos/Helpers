namespace Vheos.Helpers.Dump;

[Flags]
public enum MemberData
{
    None = 0,
    Names = 1 << 1,
    Types = 1 << 2,
    Values = 1 << 3,
    NamesAndTypes = Names | Types,
    NamesAndValues = Names | Values,
    TypesAndValues = Types | Values,
    All = Names | Types | Values,
}
