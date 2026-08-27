
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesAlcoholTobaccoOrDrugUseOrReferences.None,
                _ => null,
            };
        }
    }
}