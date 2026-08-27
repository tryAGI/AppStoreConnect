
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource
    {
        /// <summary>
        /// 
        /// </summary>
        Calculated,
        /// <summary>
        /// 
        /// </summary>
        ManuallyPlaced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource.Calculated => "CALCULATED",
                AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource.ManuallyPlaced => "MANUALLY_PLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource? ToEnum(string value)
        {
            return value switch
            {
                "CALCULATED" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource.Calculated,
                "MANUALLY_PLACED" => AppClipAdvancedExperienceUpdateRequestDataAttributesPlaceDisplayPointSource.ManuallyPlaced,
                _ => null,
            };
        }
    }
}