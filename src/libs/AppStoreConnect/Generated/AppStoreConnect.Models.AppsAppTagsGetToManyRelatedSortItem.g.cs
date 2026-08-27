
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppTagsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppTagsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppTagsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsAppTagsGetToManyRelatedSortItem.Minusname => "-name",
                AppsAppTagsGetToManyRelatedSortItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppTagsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-name" => AppsAppTagsGetToManyRelatedSortItem.Minusname,
                "name" => AppsAppTagsGetToManyRelatedSortItem.Name,
                _ => null,
            };
        }
    }
}