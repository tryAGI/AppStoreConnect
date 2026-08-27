
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem
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
    public static class AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem.Parent => "parent",
                AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem.Parent,
                "subcategories" => AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem.Subcategories,
                _ => null,
            };
        }
    }
}