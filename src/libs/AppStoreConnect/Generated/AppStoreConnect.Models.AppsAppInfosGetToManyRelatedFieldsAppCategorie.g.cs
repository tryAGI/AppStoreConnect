
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppInfosGetToManyRelatedFieldsAppCategorie
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
    public static class AppsAppInfosGetToManyRelatedFieldsAppCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppInfosGetToManyRelatedFieldsAppCategorie value)
        {
            return value switch
            {
                AppsAppInfosGetToManyRelatedFieldsAppCategorie.Parent => "parent",
                AppsAppInfosGetToManyRelatedFieldsAppCategorie.Platforms => "platforms",
                AppsAppInfosGetToManyRelatedFieldsAppCategorie.Subcategories => "subcategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppInfosGetToManyRelatedFieldsAppCategorie? ToEnum(string value)
        {
            return value switch
            {
                "parent" => AppsAppInfosGetToManyRelatedFieldsAppCategorie.Parent,
                "platforms" => AppsAppInfosGetToManyRelatedFieldsAppCategorie.Platforms,
                "subcategories" => AppsAppInfosGetToManyRelatedFieldsAppCategorie.Subcategories,
                _ => null,
            };
        }
    }
}