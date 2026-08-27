
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCategoryRelationshipsSubcategoriesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategoryRelationshipsSubcategoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoryRelationshipsSubcategoriesDataItemType value)
        {
            return value switch
            {
                AppCategoryRelationshipsSubcategoriesDataItemType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoryRelationshipsSubcategoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppCategoryRelationshipsSubcategoriesDataItemType.AppCategories,
                _ => null,
            };
        }
    }
}