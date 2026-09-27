
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride
    {
        /// <summary>
        ///
        /// </summary>
        All,
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
        /// <summary>
        ///
        /// </summary>
        TwelvePlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.All => "ALL",
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.FifteenPlus => "FIFTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.NineteenPlus => "NINETEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.None => "NONE",
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.TwelvePlus => "TWELVE_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.All,
                "FIFTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.FifteenPlus,
                "NINETEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.NineteenPlus,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.None,
                "TWELVE_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.TwelvePlus,
                _ => null,
            };
        }
    }
}