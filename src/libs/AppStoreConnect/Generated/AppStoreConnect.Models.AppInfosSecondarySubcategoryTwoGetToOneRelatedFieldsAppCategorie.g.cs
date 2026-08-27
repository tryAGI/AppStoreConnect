
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie
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
    public static class AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}