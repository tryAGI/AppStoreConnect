
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAndroidToIosAppMappingDetailsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AndroidToIosAppMappingDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAndroidToIosAppMappingDetailsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAndroidToIosAppMappingDetailsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAndroidToIosAppMappingDetailsLinkagesResponseDataItemType.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAndroidToIosAppMappingDetailsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AppAndroidToIosAppMappingDetailsLinkagesResponseDataItemType.AndroidToIosAppMappingDetails,
                _ => null,
            };
        }
    }
}