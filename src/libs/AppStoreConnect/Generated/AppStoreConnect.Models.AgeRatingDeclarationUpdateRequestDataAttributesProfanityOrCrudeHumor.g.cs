
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesProfanityOrCrudeHumor.None,
                _ => null,
            };
        }
    }
}