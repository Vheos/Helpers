namespace Vheos.Helpers.Dump;

[Flags]
public enum MemberData
{
    None = 0,
    Names = 1 << 0,
    Types = 1 << 1,
    Values = 1 << 2,
    NamesAndTypes = Names | Types,
    NamesAndValues = Names | Values,
    TypesAndValues = Types | Values,
    All = Names | Types | Values,
}
