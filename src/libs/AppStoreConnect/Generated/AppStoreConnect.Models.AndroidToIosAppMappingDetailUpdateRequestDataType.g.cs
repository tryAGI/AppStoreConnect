
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AndroidToIosAppMappingDetailUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AndroidToIosAppMappingDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AndroidToIosAppMappingDetailUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AndroidToIosAppMappingDetailUpdateRequestDataType value)
        {
            return value switch
            {
                AndroidToIosAppMappingDetailUpdateRequestDataType.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AndroidToIosAppMappingDetailUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AndroidToIosAppMappingDetailUpdateRequestDataType.AndroidToIosAppMappingDetails,
                _ => null,
            };
        }
    }
}