
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperienceCreateRequestDataRelationshipsLocalizationsDataItemType.AppClipAdvancedExperienceLocalizations,
                _ => null,
            };
        }
    }
}