
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationAttributesKoreaAgeRatingOverride
    {
        /// <summary>
        ///
        /// </summary>
        FifteenPlus,
        /// <summary>
        ///
        /// </summary>
        NineteenPlus,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgeRatingDeclarationAttributesKoreaAgeRatingOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesKoreaAgeRatingOverride value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesKoreaAgeRatingOverride.FifteenPlus => "FIFTEEN_PLUS",
                AgeRatingDeclarationAttributesKoreaAgeRatingOverride.NineteenPlus => "NINETEEN_PLUS",
                AgeRatingDeclarationAttributesKoreaAgeRatingOverride.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesKoreaAgeRatingOverride? ToEnum(string value)
        {
            return value switch
            {
                "FIFTEEN_PLUS" => AgeRatingDeclarationAttributesKoreaAgeRatingOverride.FifteenPlus,
                "NINETEEN_PLUS" => AgeRatingDeclarationAttributesKoreaAgeRatingOverride.NineteenPlus,
                "NONE" => AgeRatingDeclarationAttributesKoreaAgeRatingOverride.None,
                _ => null,
            };
        }
    }
}