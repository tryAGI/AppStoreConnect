
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosGetInstanceFieldsAppCategorie
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
    public static class AppInfosGetInstanceFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosGetInstanceFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosGetInstanceFieldsAppCategorie.Parent => "parent",
                AppInfosGetInstanceFieldsAppCategorie.Platforms => "platforms",
                AppInfosGetInstanceFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosGetInstanceFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosGetInstanceFieldsAppCategorie.Parent,
                "platforms" => AppInfosGetInstanceFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosGetInstanceFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}