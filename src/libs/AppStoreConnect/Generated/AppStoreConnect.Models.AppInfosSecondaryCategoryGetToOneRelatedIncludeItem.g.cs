
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosSecondaryCategoryGetToOneRelatedIncludeItem
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
    public static class AppInfosSecondaryCategoryGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosSecondaryCategoryGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosSecondaryCategoryGetToOneRelatedIncludeItem.Parent => "parent",
                AppInfosSecondaryCategoryGetToOneRelatedIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosSecondaryCategoryGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosSecondaryCategoryGetToOneRelatedIncludeItem.Parent,
                "subcategories" => AppInfosSecondaryCategoryGetToOneRelatedIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}