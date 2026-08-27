
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCategoriesParentGetToOneRelatedFieldsAppCategorie
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
    public static class AppCategoriesParentGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesParentGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppCategoriesParentGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppCategoriesParentGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppCategoriesParentGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesParentGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppCategoriesParentGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppCategoriesParentGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppCategoriesParentGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}