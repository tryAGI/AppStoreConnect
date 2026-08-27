
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride
    {
        /// <summary>
        /// 
        /// </summary>
        NinePlus,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        SeventeenPlus,
        /// <summary>
        /// 
        /// </summary>
        SixteenPlus,
        /// <summary>
        /// 
        /// </summary>
        ThirteenPlus,
        /// <summary>
        /// 
        /// </summary>
        Unrated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.NinePlus => "NINE_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.None => "NONE",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.SeventeenPlus => "SEVENTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.SixteenPlus => "SIXTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.ThirteenPlus => "THIRTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.Unrated => "UNRATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride? ToEnum(string value)
        {
            return value switch
            {
                "NINE_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.NinePlus,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.None,
                "SEVENTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.SeventeenPlus,
                "SIXTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.SixteenPlus,
                "THIRTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.ThirteenPlus,
                "UNRATED" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverride.Unrated,
                _ => null,
            };
        }
    }
}