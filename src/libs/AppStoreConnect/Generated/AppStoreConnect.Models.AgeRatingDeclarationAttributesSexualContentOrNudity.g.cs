
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationAttributesSexualContentOrNudity
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
    public static class AgeRatingDeclarationAttributesSexualContentOrNudityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesSexualContentOrNudity value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesSexualContentOrNudity.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesSexualContentOrNudity.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesSexualContentOrNudity.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesSexualContentOrNudity.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesSexualContentOrNudity.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesSexualContentOrNudity? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesSexualContentOrNudity.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesSexualContentOrNudity.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesSexualContentOrNudity.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesSexualContentOrNudity.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesSexualContentOrNudity.None,
                _ => null,
            };
        }
    }
}