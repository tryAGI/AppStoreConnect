
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType value)
        {
            return value switch
            {
                AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType.AppClipDefaultExperienceLocalizations,
                _ => null,
            };
        }
    }
}