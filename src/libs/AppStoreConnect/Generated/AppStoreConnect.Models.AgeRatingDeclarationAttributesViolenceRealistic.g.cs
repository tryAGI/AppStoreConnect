
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesViolenceRealistic
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
    public static class AgeRatingDeclarationAttributesViolenceRealisticExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesViolenceRealistic value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesViolenceRealistic.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesViolenceRealistic.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesViolenceRealistic.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesViolenceRealistic.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesViolenceRealistic.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesViolenceRealistic? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesViolenceRealistic.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesViolenceRealistic.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesViolenceRealistic.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesViolenceRealistic.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesViolenceRealistic.None,
                _ => null,
            };
        }
    }
}