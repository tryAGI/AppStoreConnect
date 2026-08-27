
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences
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
    public static class AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences.None,
                _ => null,
            };
        }
    }
}