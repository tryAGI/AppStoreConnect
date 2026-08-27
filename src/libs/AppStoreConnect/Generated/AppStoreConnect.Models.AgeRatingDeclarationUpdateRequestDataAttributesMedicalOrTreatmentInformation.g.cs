
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesMedicalOrTreatmentInformation.None,
                _ => null,
            };
        }
    }
}