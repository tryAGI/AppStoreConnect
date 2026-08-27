
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem
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
    public static class AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem.Parent => "parent",
                AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem.Parent,
                "subcategories" => AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}