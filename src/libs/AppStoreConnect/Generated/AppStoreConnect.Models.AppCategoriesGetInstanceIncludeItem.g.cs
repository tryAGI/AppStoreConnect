
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCategoriesGetInstanceIncludeItem
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
    public static class AppCategoriesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppCategoriesGetInstanceIncludeItem.Parent => "parent",
                AppCategoriesGetInstanceIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppCategoriesGetInstanceIncludeItem.Parent,
                "subcategories" => AppCategoriesGetInstanceIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}