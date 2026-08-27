
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesMatureOrSuggestiveThemes.None,
                _ => null,
            };
        }
    }
}