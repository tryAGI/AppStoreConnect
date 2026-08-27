
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie
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
    public static class AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}