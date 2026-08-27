
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCategoriesGetCollectionFieldsAppCategorie
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
    public static class AppCategoriesGetCollectionFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesGetCollectionFieldsAppCategorie value)
        {
            return value switch
            {
                AppCategoriesGetCollectionFieldsAppCategorie.Parent => "parent",
                AppCategoriesGetCollectionFieldsAppCategorie.Platforms => "platforms",
                AppCategoriesGetCollectionFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesGetCollectionFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppCategoriesGetCollectionFieldsAppCategorie.Parent,
                "platforms" => AppCategoriesGetCollectionFieldsAppCategorie.Platforms,
                "subcategories" => AppCategoriesGetCollectionFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}