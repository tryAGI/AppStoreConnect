
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesMatureOrSuggestiveThemes
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
    public static class AgeRatingDeclarationAttributesMatureOrSuggestiveThemesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesMatureOrSuggestiveThemes value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesMatureOrSuggestiveThemes? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesMatureOrSuggestiveThemes.None,
                _ => null,
            };
        }
    }
}