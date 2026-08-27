
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoSecondarySubcategoryTwoLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoSecondarySubcategoryTwoLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoSecondarySubcategoryTwoLinkageResponseDataType value)
        {
            return value switch
            {
                AppInfoSecondarySubcategoryTwoLinkageResponseDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoSecondarySubcategoryTwoLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoSecondarySubcategoryTwoLinkageResponseDataType.AppCategories,
                _ => null,
            };
        }
    }
}