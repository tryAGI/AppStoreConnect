
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AndroidToIosAppMappingDetailType
    {
        /// <summary>
        ///
        /// </summary>
        AndroidToIosAppMappingDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AndroidToIosAppMappingDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AndroidToIosAppMappingDetailType value)
        {
            return value switch
            {
                AndroidToIosAppMappingDetailType.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AndroidToIosAppMappingDetailType? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AndroidToIosAppMappingDetailType.AndroidToIosAppMappingDetails,
                _ => null,
            };
        }
    }
}