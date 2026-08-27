
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinusreferenceName,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsSubscriptionGroupsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedSortItem.MinusreferenceName => "-referenceName",
                AppsSubscriptionGroupsGetToManyRelatedSortItem.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-referenceName" => AppsSubscriptionGroupsGetToManyRelatedSortItem.MinusreferenceName,
                "referenceName" => AppsSubscriptionGroupsGetToManyRelatedSortItem.ReferenceName,
                _ => null,
            };
        }
    }
}