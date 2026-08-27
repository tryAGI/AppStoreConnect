
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadisticExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceRealisticProlongedGraphicOrSadistic.None,
                _ => null,
            };
        }
    }
}