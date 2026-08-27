
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.FifteenPlus => "FIFTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.NineteenPlus => "NINETEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.None => "NONE",
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
                "FIFTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.FifteenPlus,
                "NINETEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.NineteenPlus,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesKoreaAgeRatingOverride.None,
                _ => null,
            };
        }
    }
}