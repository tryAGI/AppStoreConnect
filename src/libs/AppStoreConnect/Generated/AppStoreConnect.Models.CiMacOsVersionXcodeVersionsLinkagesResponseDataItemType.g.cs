
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiMacOsVersionXcodeVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CiXcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionXcodeVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionXcodeVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiMacOsVersionXcodeVersionsLinkagesResponseDataItemType.CiXcodeVersions => "ciXcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionXcodeVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciXcodeVersions" => CiMacOsVersionXcodeVersionsLinkagesResponseDataItemType.CiXcodeVersions,
                _ => null,
            };
        }
    }
}