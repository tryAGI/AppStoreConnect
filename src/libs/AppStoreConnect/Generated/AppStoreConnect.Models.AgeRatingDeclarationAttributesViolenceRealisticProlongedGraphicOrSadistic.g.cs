
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic
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
    public static class AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadisticExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic.None,
                _ => null,
            };
        }
    }
}