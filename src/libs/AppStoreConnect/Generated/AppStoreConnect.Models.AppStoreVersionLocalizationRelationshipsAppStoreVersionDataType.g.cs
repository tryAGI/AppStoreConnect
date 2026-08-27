
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationRelationshipsAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}