
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppTagsGetToManyRelatedFieldsAppTag
    {
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Territories,
        /// <summary>
        ///
        /// </summary>
        VisibleInAppStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppTagsGetToManyRelatedFieldsAppTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppTagsGetToManyRelatedFieldsAppTag value)
        {
            return value switch
            {
                AppsAppTagsGetToManyRelatedFieldsAppTag.Name => "name",
                AppsAppTagsGetToManyRelatedFieldsAppTag.Territories => "territories",
                AppsAppTagsGetToManyRelatedFieldsAppTag.VisibleInAppStore => "visibleInAppStore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppTagsGetToManyRelatedFieldsAppTag? ToEnum(string value)
        {
            return value switch
            {
                "name" => AppsAppTagsGetToManyRelatedFieldsAppTag.Name,
                "territories" => AppsAppTagsGetToManyRelatedFieldsAppTag.Territories,
                "visibleInAppStore" => AppsAppTagsGetToManyRelatedFieldsAppTag.VisibleInAppStore,
                _ => null,
            };
        }
    }
}