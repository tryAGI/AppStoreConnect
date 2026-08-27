
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AgeRatingDeclarationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AgeRatingDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgeRatingDeclarationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgeRatingDeclarationUpdateRequestDataType value)
        {
            return value switch
            {
                AgeRatingDeclarationUpdateRequestDataType.AgeRatingDeclarations => "ageRatingDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgeRatingDeclarationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclarations" => AgeRatingDeclarationUpdateRequestDataType.AgeRatingDeclarations,
                _ => null,
            };
        }
    }
}