
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesHorrorOrFearThemes
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
    public static class AgeRatingDeclarationAttributesHorrorOrFearThemesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesHorrorOrFearThemes value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesHorrorOrFearThemes.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesHorrorOrFearThemes.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesHorrorOrFearThemes.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesHorrorOrFearThemes.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesHorrorOrFearThemes.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesHorrorOrFearThemes? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesHorrorOrFearThemes.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesHorrorOrFearThemes.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesHorrorOrFearThemes.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesHorrorOrFearThemes.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesHorrorOrFearThemes.None,
                _ => null,
            };
        }
    }
}