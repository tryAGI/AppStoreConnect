
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons
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
    public static class AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeaponsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.Frequent => "FREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.Infrequent => "INFREQUENT",
                AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationUpdateRequestDataAttributesGunsOrOtherWeapons.None,
                _ => null,
            };
        }
    }
}