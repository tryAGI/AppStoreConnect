
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie
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
    public static class AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}