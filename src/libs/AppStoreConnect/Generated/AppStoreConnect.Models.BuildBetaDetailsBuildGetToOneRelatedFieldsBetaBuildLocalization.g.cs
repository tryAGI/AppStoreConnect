
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization.Build => "build",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization.Locale => "locale",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization? ToEnum(string value)
        {
            return value switch
            {
                "build" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization.Build,
                "locale" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization.Locale,
                "whatsNew" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}