
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsAndroidToIosAppMappingDetailsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AndroidToIosAppMappingDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAndroidToIosAppMappingDetailsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsAndroidToIosAppMappingDetailsDataItemType.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAndroidToIosAppMappingDetailsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AppRelationshipsAndroidToIosAppMappingDetailsDataItemType.AndroidToIosAppMappingDetails,
                _ => null,
            };
        }
    }
}