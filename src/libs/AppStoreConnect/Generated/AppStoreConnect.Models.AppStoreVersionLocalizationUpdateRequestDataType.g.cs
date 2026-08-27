
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationUpdateRequestDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppStoreVersionLocalizationUpdateRequestDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}