
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationCreateRequestDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppStoreVersionLocalizationCreateRequestDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}