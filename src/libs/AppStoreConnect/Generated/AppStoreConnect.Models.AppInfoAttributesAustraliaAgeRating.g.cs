
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoAttributesAustraliaAgeRating
    {
        /// <summary>
        ///
        /// </summary>
        Eighteen,
        /// <summary>
        ///
        /// </summary>
        Fifteen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAttributesAustraliaAgeRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAttributesAustraliaAgeRating value)
        {
            return value switch
            {
                AppInfoAttributesAustraliaAgeRating.Eighteen => "EIGHTEEN",
                AppInfoAttributesAustraliaAgeRating.Fifteen => "FIFTEEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAttributesAustraliaAgeRating? ToEnum(string value)
        {
            return value switch
            {
                "EIGHTEEN" => AppInfoAttributesAustraliaAgeRating.Eighteen,
                "FIFTEEN" => AppInfoAttributesAustraliaAgeRating.Fifteen,
                _ => null,
            };
        }
    }
}