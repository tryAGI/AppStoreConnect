
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCategorySubcategoriesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategorySubcategoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategorySubcategoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCategorySubcategoriesLinkagesResponseDataItemType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategorySubcategoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppCategorySubcategoriesLinkagesResponseDataItemType.AppCategories,
                _ => null,
            };
        }
    }
}