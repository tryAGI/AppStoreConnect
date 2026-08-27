
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoAgeRatingDeclarationLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AgeRatingDeclarations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAgeRatingDeclarationLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAgeRatingDeclarationLinkageResponseDataType value)
        {
            return value switch
            {
                AppInfoAgeRatingDeclarationLinkageResponseDataType.AgeRatingDeclarations => "ageRatingDeclarations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAgeRatingDeclarationLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "ageRatingDeclarations" => AppInfoAgeRatingDeclarationLinkageResponseDataType.AgeRatingDeclarations,
                _ => null,
            };
        }
    }
}