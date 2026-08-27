
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationAttributesGunsOrOtherWeapons
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
    public static class AgeRatingDeclarationAttributesGunsOrOtherWeaponsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationAttributesGunsOrOtherWeapons value)
        {
            return value switch
            {
                AgeRatingDeclarationAttributesGunsOrOtherWeapons.Frequent => "FREQUENT",
                AgeRatingDeclarationAttributesGunsOrOtherWeapons.FrequentOrIntense => "FREQUENT_OR_INTENSE",
                AgeRatingDeclarationAttributesGunsOrOtherWeapons.Infrequent => "INFREQUENT",
                AgeRatingDeclarationAttributesGunsOrOtherWeapons.InfrequentOrMild => "INFREQUENT_OR_MILD",
                AgeRatingDeclarationAttributesGunsOrOtherWeapons.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationAttributesGunsOrOtherWeapons? ToEnum(string value)
        {
            return value switch
            {
                "FREQUENT" => AgeRatingDeclarationAttributesGunsOrOtherWeapons.Frequent,
                "FREQUENT_OR_INTENSE" => AgeRatingDeclarationAttributesGunsOrOtherWeapons.FrequentOrIntense,
                "INFREQUENT" => AgeRatingDeclarationAttributesGunsOrOtherWeapons.Infrequent,
                "INFREQUENT_OR_MILD" => AgeRatingDeclarationAttributesGunsOrOtherWeapons.InfrequentOrMild,
                "NONE" => AgeRatingDeclarationAttributesGunsOrOtherWeapons.None,
                _ => null,
            };
        }
    }
}