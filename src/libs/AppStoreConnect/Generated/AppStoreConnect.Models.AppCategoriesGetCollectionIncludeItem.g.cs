
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCategoriesGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Parent,
        /// <summary>
        ///
        /// </summary>
        Subcategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategoriesGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesGetCollectionIncludeItem value)
        {
            return value switch
            {
                AppCategoriesGetCollectionIncludeItem.Parent => "parent",
                AppCategoriesGetCollectionIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppCategoriesGetCollectionIncludeItem.Parent,
                "subcategories" => AppCategoriesGetCollectionIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}