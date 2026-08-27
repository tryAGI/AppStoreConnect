
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie
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
    public static class AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie.Parent => "parent",
                AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie.Platforms => "platforms",
                AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie.Parent,
                "platforms" => AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}