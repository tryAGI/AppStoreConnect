
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AndroidToIosAppMappingDetailCreateRequestDataRelationshipsAppDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AndroidToIosAppMappingDetailCreateRequestDataRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AndroidToIosAppMappingDetailCreateRequestDataRelationshipsAppDataType value)
        {
            return value switch
            {
                AndroidToIosAppMappingDetailCreateRequestDataRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AndroidToIosAppMappingDetailCreateRequestDataRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AndroidToIosAppMappingDetailCreateRequestDataRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}