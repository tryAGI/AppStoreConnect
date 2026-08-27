
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesMedicalOrTreatmentInformation
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
    public static class AgeRatingDeclarationAttributesMedicalOrTreatmentInformationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesMedicalOrTreatmentInformation value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesMedicalOrTreatmentInformation? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesMedicalOrTreatmentInformation.None,
                _ => null,
            };
        }
    }
}