
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesGamblingSimulated
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
    public static class AgeRatingDeclarationAttributesGamblingSimulatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesGamblingSimulated value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesGamblingSimulated.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesGamblingSimulated.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesGamblingSimulated.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesGamblingSimulated.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesGamblingSimulated.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesGamblingSimulated? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesGamblingSimulated.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesGamblingSimulated.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesGamblingSimulated.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesGamblingSimulated.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesGamblingSimulated.None,
                _ => null,
            };
        }
    }
}