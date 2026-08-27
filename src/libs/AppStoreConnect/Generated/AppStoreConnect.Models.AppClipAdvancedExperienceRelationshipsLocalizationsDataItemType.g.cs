
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperienceRelationshipsLocalizationsDataItemType.AppClipAdvancedExperienceLocalizations,
                _ => null,
            };
        }
    }
}