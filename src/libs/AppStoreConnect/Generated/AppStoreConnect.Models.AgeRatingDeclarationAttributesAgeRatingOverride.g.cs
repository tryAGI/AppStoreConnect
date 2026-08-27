
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationAttributesAgeRatingOverride
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
    public static class AgeRatingDeclarationAttributesAgeRatingOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesAgeRatingOverride value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesAgeRatingOverride.NinePlus => "NINE_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverride.None => "NONE",
                AgeRatingDeclarationAttributesAgeRatingOverride.SeventeenPlus => "SEVENTEEN_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverride.SixteenPlus => "SIXTEEN_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverride.ThirteenPlus => "THIRTEEN_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverride.Unrated => "UNRATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesAgeRatingOverride? ToEnum(string value)
        {
            return value switch
            {
                "NINE_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverride.NinePlus,
                "NONE" => AgeRatingDeclarationAttributesAgeRatingOverride.None,
                "SEVENTEEN_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverride.SeventeenPlus,
                "SIXTEEN_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverride.SixteenPlus,
                "THIRTEEN_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverride.ThirteenPlus,
                "UNRATED" => AgeRatingDeclarationAttributesAgeRatingOverride.Unrated,
                _ => null,
            };
        }
    }
}