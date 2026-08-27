
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2 value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.EighteenPlus => "EIGHTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.NinePlus => "NINE_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.None => "NONE",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.SixteenPlus => "SIXTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.ThirteenPlus => "THIRTEEN_PLUS",
                AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.Unrated => "UNRATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2? ToEnum(string value)
        {
            return value switch
            {
                "EIGHTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.EighteenPlus,
                "NINE_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.NinePlus,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.None,
                "SIXTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.SixteenPlus,
                "THIRTEEN_PLUS" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.ThirteenPlus,
                "UNRATED" => AgeRatingDeclarationUpdateRequestDataAttributesAgeRatingOverrideV2.Unrated,
                _ => null,
            };
        }
    }
}