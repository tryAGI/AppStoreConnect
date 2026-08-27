
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesViolenceCartoonOrFantasy.None,
                _ => null,
            };
        }
    }
}