
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperienceUpdateRequestDataRelationshipsLocalizationsDataItemType.AppClipAdvancedExperienceLocalizations,
                _ => null,
            };
        }
    }
}