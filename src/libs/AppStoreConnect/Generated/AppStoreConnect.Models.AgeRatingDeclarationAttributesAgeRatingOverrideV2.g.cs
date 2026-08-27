
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesAgeRatingOverrideV2
    {
        /// <summary>
        /// 
        /// </summary>
        EighteenPlus,
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
    public static class AgeRatingDeclarationAttributesAgeRatingOverrideV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesAgeRatingOverrideV2 value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesAgeRatingOverrideV2.EighteenPlus => "EIGHTEEN_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverrideV2.NinePlus => "NINE_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverrideV2.None => "NONE",
                AgeRatingDeclarationAttributesAgeRatingOverrideV2.SixteenPlus => "SIXTEEN_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverrideV2.ThirteenPlus => "THIRTEEN_PLUS",
                AgeRatingDeclarationAttributesAgeRatingOverrideV2.Unrated => "UNRATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesAgeRatingOverrideV2? ToEnum(string value)
        {
            return value switch
            {
                "EIGHTEEN_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverrideV2.EighteenPlus,
                "NINE_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverrideV2.NinePlus,
                "NONE" => AgeRatingDeclarationAttributesAgeRatingOverrideV2.None,
                "SIXTEEN_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverrideV2.SixteenPlus,
                "THIRTEEN_PLUS" => AgeRatingDeclarationAttributesAgeRatingOverrideV2.ThirteenPlus,
                "UNRATED" => AgeRatingDeclarationAttributesAgeRatingOverrideV2.Unrated,
                _ => null,
            };
        }
    }
}