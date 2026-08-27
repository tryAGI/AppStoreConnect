
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesSexualContentGraphicAndNudity
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
    public static class AgeRatingDeclarationAttributesSexualContentGraphicAndNudityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesSexualContentGraphicAndNudity value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesSexualContentGraphicAndNudity? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesSexualContentGraphicAndNudity.None,
                _ => null,
            };
        }
    }
}