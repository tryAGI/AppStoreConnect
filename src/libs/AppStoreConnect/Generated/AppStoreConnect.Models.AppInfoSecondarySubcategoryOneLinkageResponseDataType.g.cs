
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoSecondarySubcategoryOneLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoSecondarySubcategoryOneLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoSecondarySubcategoryOneLinkageResponseDataType value)
        {
            return value switch
            {
                AppInfoSecondarySubcategoryOneLinkageResponseDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoSecondarySubcategoryOneLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoSecondarySubcategoryOneLinkageResponseDataType.AppCategories,
                _ => null,
            };
        }
    }
}