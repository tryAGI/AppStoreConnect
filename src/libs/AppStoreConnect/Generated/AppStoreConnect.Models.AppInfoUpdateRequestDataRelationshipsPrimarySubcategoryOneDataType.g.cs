
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType value)
        {
            return value switch
            {
                AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType.AppCategories,
                _ => null,
            };
        }
    }
}