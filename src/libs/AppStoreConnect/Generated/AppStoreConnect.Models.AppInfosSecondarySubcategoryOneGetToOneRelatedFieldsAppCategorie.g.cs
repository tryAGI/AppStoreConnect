
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie
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
    public static class AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}