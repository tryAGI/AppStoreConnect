
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesProfanityOrCrudeHumor
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
    public static class AgeRatingDeclarationAttributesProfanityOrCrudeHumorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesProfanityOrCrudeHumor value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesProfanityOrCrudeHumor.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesProfanityOrCrudeHumor.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesProfanityOrCrudeHumor.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesProfanityOrCrudeHumor.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesProfanityOrCrudeHumor.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesProfanityOrCrudeHumor? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesProfanityOrCrudeHumor.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesProfanityOrCrudeHumor.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesProfanityOrCrudeHumor.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesProfanityOrCrudeHumor.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesProfanityOrCrudeHumor.None,
                _ => null,
            };
        }
    }
}