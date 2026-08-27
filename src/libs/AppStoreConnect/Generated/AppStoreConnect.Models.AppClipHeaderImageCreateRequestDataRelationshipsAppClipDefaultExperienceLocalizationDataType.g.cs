
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType value)
        {
            return value switch
            {
                AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalizations" => AppClipHeaderImageCreateRequestDataRelationshipsAppClipDefaultExperienceLocalizationDataType.AppClipDefaultExperienceLocalizations,
                _ => null,
            };
        }
    }
}