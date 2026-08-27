
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType value)
        {
            return value switch
            {
                AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType.AppCategories,
                _ => null,
            };
        }
    }
}