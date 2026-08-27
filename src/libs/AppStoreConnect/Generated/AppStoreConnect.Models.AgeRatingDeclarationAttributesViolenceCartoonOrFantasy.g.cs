
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgeRatingDeclarationAttributesViolenceCartoonOrFantasy
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
    public static class AgeRatingDeclarationAttributesViolenceCartoonOrFantasyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesViolenceCartoonOrFantasy value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesViolenceCartoonOrFantasy? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesViolenceCartoonOrFantasy.None,
                _ => null,
            };
        }
    }
}