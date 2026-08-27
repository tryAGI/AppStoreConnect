
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity
    {
        /// <summary>
        ///
        /// </summary>
        Frequent,
        /// <summary>
        ///
        /// </summary>
        FrequentOrIntense,
        /// <summary>
        ///
        /// </summary>
        Infrequent,
        /// <summary>
        ///
        /// </summary>
        InfrequentOrMild,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesSexualContentGraphicAndNudity.None,
                _ => null,
            };
        }
    }
}