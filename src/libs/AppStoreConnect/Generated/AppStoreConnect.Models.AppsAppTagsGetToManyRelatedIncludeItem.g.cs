
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppTagsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppTagsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppTagsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppTagsGetToManyRelatedIncludeItem.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppTagsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territories" => AppsAppTagsGetToManyRelatedIncludeItem.Territories,
                _ => null,
            };
        }
    }
}