
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType value)
        {
            return value switch
            {
                AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalizationDataType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}