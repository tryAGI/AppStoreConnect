
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesContests
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesContestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesContests value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesContests.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesContests.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesContests.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesContests.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesContests.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesContests? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesContests.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesContests.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesContests.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesContests.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesContests.None,
                _ => null,
            };
        }
    }
}