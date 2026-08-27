
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoRelationshipsAgeRatingDeclarationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AgeRatingDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsAgeRatingDeclarationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsAgeRatingDeclarationDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsAgeRatingDeclarationDataType.AgeRatingDeclarations => "ageRatingDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsAgeRatingDeclarationDataType? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclarations" => AppInfoRelationshipsAgeRatingDeclarationDataType.AgeRatingDeclarations,
                _ => null,
            };
        }
    }
}