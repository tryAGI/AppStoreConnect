
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem
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
    public static class AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem.Parent => "parent",
                AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem.Parent,
                "subcategories" => AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}