
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiMacOsVersionsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        XcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CiMacOsVersionsGetInstanceIncludeItem.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "xcodeVersions" => CiMacOsVersionsGetInstanceIncludeItem.XcodeVersions,
                _ => null,
            };
        }
    }
}