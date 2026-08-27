
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationType
    {
        /// <summary>
        ///
        /// </summary>
        AgeRatingDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgeRatingDeclarationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationType value)
        {
            return value switch
            {
                AgeRatingDeclarationType.AgeRatingDeclarations => "ageRatingDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationType? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclarations" => AgeRatingDeclarationType.AgeRatingDeclarations,
                _ => null,
            };
        }
    }
}