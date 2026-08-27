
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiXcodeVersionsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        MacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiXcodeVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CiXcodeVersionsGetInstanceIncludeItem.MacOsVersions => "macOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiXcodeVersionsGetInstanceIncludeItem.MacOsVersions,
                _ => null,
            };
        }
    }
}