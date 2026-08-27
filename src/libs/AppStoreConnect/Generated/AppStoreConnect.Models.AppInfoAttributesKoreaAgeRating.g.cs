
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoAttributesKoreaAgeRating
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Fifteen,
        /// <summary>
        /// 
        /// </summary>
        Nineteen,
        /// <summary>
        /// 
        /// </summary>
        NotApplicable,
        /// <summary>
        /// 
        /// </summary>
        Twelve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAttributesKoreaAgeRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAttributesKoreaAgeRating value)
        {
            return value switch
            {
                AppInfoAttributesKoreaAgeRating.All => "ALL",
                AppInfoAttributesKoreaAgeRating.Fifteen => "FIFTEEN",
                AppInfoAttributesKoreaAgeRating.Nineteen => "NINETEEN",
                AppInfoAttributesKoreaAgeRating.NotApplicable => "NOT_APPLICABLE",
                AppInfoAttributesKoreaAgeRating.Twelve => "TWELVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAttributesKoreaAgeRating? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => AppInfoAttributesKoreaAgeRating.All,
                "FIFTEEN" => AppInfoAttributesKoreaAgeRating.Fifteen,
                "NINETEEN" => AppInfoAttributesKoreaAgeRating.Nineteen,
                "NOT_APPLICABLE" => AppInfoAttributesKoreaAgeRating.NotApplicable,
                "TWELVE" => AppInfoAttributesKoreaAgeRating.Twelve,
                _ => null,
            };
        }
    }
}