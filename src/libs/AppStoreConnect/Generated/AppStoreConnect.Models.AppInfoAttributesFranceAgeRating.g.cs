
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoAttributesFranceAgeRating
    {
        /// <summary>
        ///
        /// </summary>
        Eighteen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAttributesFranceAgeRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAttributesFranceAgeRating value)
        {
            return value switch
            {
                AppInfoAttributesFranceAgeRating.Eighteen => "EIGHTEEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAttributesFranceAgeRating? ToEnum(string value)
        {
            return value switch
            {
                "EIGHTEEN" => AppInfoAttributesFranceAgeRating.Eighteen,
                _ => null,
            };
        }
    }
}