
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType value)
        {
            return value switch
            {
                AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}