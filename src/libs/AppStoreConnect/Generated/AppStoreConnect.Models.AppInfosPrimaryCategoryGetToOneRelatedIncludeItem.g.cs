
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosPrimaryCategoryGetToOneRelatedIncludeItem
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
    public static class AppInfosPrimaryCategoryGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosPrimaryCategoryGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosPrimaryCategoryGetToOneRelatedIncludeItem.Parent => "parent",
                AppInfosPrimaryCategoryGetToOneRelatedIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosPrimaryCategoryGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosPrimaryCategoryGetToOneRelatedIncludeItem.Parent,
                "subcategories" => AppInfosPrimaryCategoryGetToOneRelatedIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}