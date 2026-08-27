
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BrazilAgeRating
    {
        /// <summary>
        ///
        /// </summary>
        Eighteen,
        /// <summary>
        ///
        /// </summary>
        Fourteen,
        /// <summary>
        ///
        /// </summary>
        L,
        /// <summary>
        ///
        /// </summary>
        Sixteen,
        /// <summary>
        ///
        /// </summary>
        Ten,
        /// <summary>
        ///
        /// </summary>
        Twelve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BrazilAgeRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrazilAgeRating value)
        {
            return value switch
            {
                BrazilAgeRating.Eighteen => "EIGHTEEN",
                BrazilAgeRating.Fourteen => "FOURTEEN",
                BrazilAgeRating.L => "L",
                BrazilAgeRating.Sixteen => "SIXTEEN",
                BrazilAgeRating.Ten => "TEN",
                BrazilAgeRating.Twelve => "TWELVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrazilAgeRating? ToEnum(string value)
        {
            return value switch
            {
                "EIGHTEEN" => BrazilAgeRating.Eighteen,
                "FOURTEEN" => BrazilAgeRating.Fourteen,
                "L" => BrazilAgeRating.L,
                "SIXTEEN" => BrazilAgeRating.Sixteen,
                "TEN" => BrazilAgeRating.Ten,
                "TWELVE" => BrazilAgeRating.Twelve,
                _ => null,
            };
        }
    }
}