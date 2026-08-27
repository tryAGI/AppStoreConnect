
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        WhatsNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization value)
        {
            return value switch
            {
                BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization.Build => "build",
                BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization.Locale => "locale",
                BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization? ToEnum(string value)
        {
            return value switch
            {
                "build" => BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization.Build,
                "locale" => BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization.Locale,
                "whatsNew" => BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}