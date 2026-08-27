
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoRelationshipsPrimarySubcategoryOneDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsPrimarySubcategoryOneDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsPrimarySubcategoryOneDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsPrimarySubcategoryOneDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsPrimarySubcategoryOneDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoRelationshipsPrimarySubcategoryOneDataType.AppCategories,
                _ => null,
            };
        }
    }
}