
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiXcodeVersionRelationshipsMacOsVersionsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CiMacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionRelationshipsMacOsVersionsDataItemType value)
        {
            return value switch
            {
                CiXcodeVersionRelationshipsMacOsVersionsDataItemType.CiMacOsVersions => "ciMacOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionRelationshipsMacOsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiXcodeVersionRelationshipsMacOsVersionsDataItemType.CiMacOsVersions,
                _ => null,
            };
        }
    }
}