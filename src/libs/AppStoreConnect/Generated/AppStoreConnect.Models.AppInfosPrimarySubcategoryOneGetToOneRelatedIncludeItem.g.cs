
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem
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
    public static class AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem.Parent => "parent",
                AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem.Parent,
                "subcategories" => AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}