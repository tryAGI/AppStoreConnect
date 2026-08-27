
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoPrimarySubcategoryTwoLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoPrimarySubcategoryTwoLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoPrimarySubcategoryTwoLinkageResponseDataType value)
        {
            return value switch
            {
                AppInfoPrimarySubcategoryTwoLinkageResponseDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoPrimarySubcategoryTwoLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoPrimarySubcategoryTwoLinkageResponseDataType.AppCategories,
                _ => null,
            };
        }
    }
}