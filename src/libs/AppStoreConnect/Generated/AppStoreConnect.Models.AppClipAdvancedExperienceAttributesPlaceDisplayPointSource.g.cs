
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesPlaceDisplayPointSource
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
    public static class AppClipAdvancedExperienceAttributesPlaceDisplayPointSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesPlaceDisplayPointSource value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesPlaceDisplayPointSource.Calculated => "CALCULATED",
                AppClipAdvancedExperienceAttributesPlaceDisplayPointSource.ManuallyPlaced => "MANUALLY_PLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesPlaceDisplayPointSource? ToEnum(string value)
        {
            return value switch
            {
                "CALCULATED" => AppClipAdvancedExperienceAttributesPlaceDisplayPointSource.Calculated,
                "MANUALLY_PLACED" => AppClipAdvancedExperienceAttributesPlaceDisplayPointSource.ManuallyPlaced,
                _ => null,
            };
        }
    }
}