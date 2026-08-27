
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCategoriesGetInstanceFieldsAppCategorie
    {
        /// <summary>
        ///
        /// </summary>
        Parent,
        /// <summary>
        ///
        /// </summary>
        Platforms,
        /// <summary>
        ///
        /// </summary>
        Subcategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategoriesGetInstanceFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesGetInstanceFieldsAppCategorie value)
        {
            return value switch
            {
                AppCategoriesGetInstanceFieldsAppCategorie.Parent => "parent",
                AppCategoriesGetInstanceFieldsAppCategorie.Platforms => "platforms",
                AppCategoriesGetInstanceFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesGetInstanceFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppCategoriesGetInstanceFieldsAppCategorie.Parent,
                "platforms" => AppCategoriesGetInstanceFieldsAppCategorie.Platforms,
                "subcategories" => AppCategoriesGetInstanceFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}