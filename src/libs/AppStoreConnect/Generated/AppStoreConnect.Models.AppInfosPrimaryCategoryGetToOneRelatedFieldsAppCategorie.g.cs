
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie
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
    public static class AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}