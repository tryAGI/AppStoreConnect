
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie
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
    public static class AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie.Parent => "parent",
                AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie.Platforms => "platforms",
                AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie.Parent,
                "platforms" => AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}