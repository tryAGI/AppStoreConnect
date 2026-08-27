
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoRelationshipsPrimarySubcategoryTwoDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsPrimarySubcategoryTwoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsPrimarySubcategoryTwoDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsPrimarySubcategoryTwoDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsPrimarySubcategoryTwoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoRelationshipsPrimarySubcategoryTwoDataType.AppCategories,
                _ => null,
            };
        }
    }
}