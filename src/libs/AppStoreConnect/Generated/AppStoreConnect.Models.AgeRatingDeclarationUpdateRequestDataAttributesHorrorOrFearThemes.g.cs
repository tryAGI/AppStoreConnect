
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesHorrorOrFearThemes.None,
                _ => null,
            };
        }
    }
}