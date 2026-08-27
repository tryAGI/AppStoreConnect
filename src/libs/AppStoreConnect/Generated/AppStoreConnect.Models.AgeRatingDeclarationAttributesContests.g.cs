
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationAttributesContests
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
    public static class AgeRatingDeclarationAttributesContestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesContests value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesContests.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesContests.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesContests.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesContests.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesContests.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesContests? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesContests.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesContests.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesContests.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesContests.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesContests.None,
                _ => null,
            };
        }
    }
}