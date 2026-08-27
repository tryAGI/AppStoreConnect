
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiXcodeVersionMacOsVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CiMacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiXcodeVersionMacOsVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionMacOsVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiXcodeVersionMacOsVersionsLinkagesResponseDataItemType.CiMacOsVersions => "ciMacOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionMacOsVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiXcodeVersionMacOsVersionsLinkagesResponseDataItemType.CiMacOsVersions,
                _ => null,
            };
        }
    }
}