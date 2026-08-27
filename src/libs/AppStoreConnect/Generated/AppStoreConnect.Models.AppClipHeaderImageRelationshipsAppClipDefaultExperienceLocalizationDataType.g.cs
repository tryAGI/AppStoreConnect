
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType value)
        {
            return value switch
            {
                AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalizations" => AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType.AppClipDefaultExperienceLocalizations,
                _ => null,
            };
        }
    }
}