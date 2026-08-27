
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization.Build => "build",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization.Locale => "locale",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization? ToEnum(string value)
        {
            return value switch
            {
                "build" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization.Build,
                "locale" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization.Locale,
                "whatsNew" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}