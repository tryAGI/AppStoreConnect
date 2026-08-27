
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuscreatedDate,
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        MinuspublicLinkEnabled,
        /// <summary>
        ///
        /// </summary>
        MinuspublicLinkLimit,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        PublicLinkEnabled,
        /// <summary>
        ///
        /// </summary>
        PublicLinkLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetCollectionSortItem value)
        {
            return value switch
            {
                BetaGroupsGetCollectionSortItem.MinuscreatedDate => "-createdDate",
                BetaGroupsGetCollectionSortItem.Minusname => "-name",
                BetaGroupsGetCollectionSortItem.MinuspublicLinkEnabled => "-publicLinkEnabled",
                BetaGroupsGetCollectionSortItem.MinuspublicLinkLimit => "-publicLinkLimit",
                BetaGroupsGetCollectionSortItem.CreatedDate => "createdDate",
                BetaGroupsGetCollectionSortItem.Name => "name",
                BetaGroupsGetCollectionSortItem.PublicLinkEnabled => "publicLinkEnabled",
                BetaGroupsGetCollectionSortItem.PublicLinkLimit => "publicLinkLimit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => BetaGroupsGetCollectionSortItem.MinuscreatedDate,
                "-name" => BetaGroupsGetCollectionSortItem.Minusname,
                "-publicLinkEnabled" => BetaGroupsGetCollectionSortItem.MinuspublicLinkEnabled,
                "-publicLinkLimit" => BetaGroupsGetCollectionSortItem.MinuspublicLinkLimit,
                "createdDate" => BetaGroupsGetCollectionSortItem.CreatedDate,
                "name" => BetaGroupsGetCollectionSortItem.Name,
                "publicLinkEnabled" => BetaGroupsGetCollectionSortItem.PublicLinkEnabled,
                "publicLinkLimit" => BetaGroupsGetCollectionSortItem.PublicLinkLimit,
                _ => null,
            };
        }
    }
}