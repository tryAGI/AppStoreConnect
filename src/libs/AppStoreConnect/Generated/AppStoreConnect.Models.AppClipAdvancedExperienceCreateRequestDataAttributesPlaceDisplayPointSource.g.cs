
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource
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
    public static class AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource.Calculated => "CALCULATED",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource.ManuallyPlaced => "MANUALLY_PLACED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource? ToEnum(string value)
        {
            return value switch
            {
                "CALCULATED" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource.Calculated,
                "MANUALLY_PLACED" => AppClipAdvancedExperienceCreateRequestDataAttributesPlaceDisplayPointSource.ManuallyPlaced,
                _ => null,
            };
        }
    }
}