
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesPlaceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Matched,
        /// <summary>
        /// 
        /// </summary>
        NoMatch,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceAttributesPlaceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesPlaceStatus value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesPlaceStatus.Matched => "MATCHED",
                AppClipAdvancedExperienceAttributesPlaceStatus.NoMatch => "NO_MATCH",
                AppClipAdvancedExperienceAttributesPlaceStatus.Pending => "PENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesPlaceStatus? ToEnum(string value)
        {
            return value switch
            {
                "MATCHED" => AppClipAdvancedExperienceAttributesPlaceStatus.Matched,
                "NO_MATCH" => AppClipAdvancedExperienceAttributesPlaceStatus.NoMatch,
                "PENDING" => AppClipAdvancedExperienceAttributesPlaceStatus.Pending,
                _ => null,
            };
        }
    }
}