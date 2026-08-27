
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusid,
        /// <summary>
        ///
        /// </summary>
        Minusidentifier,
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        Minusplatform,
        /// <summary>
        ///
        /// </summary>
        MinusseedId,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        Identifier,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        SeedId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionSortItem value)
        {
            return value switch
            {
                BundleIdsGetCollectionSortItem.Minusid => "-id",
                BundleIdsGetCollectionSortItem.Minusidentifier => "-identifier",
                BundleIdsGetCollectionSortItem.Minusname => "-name",
                BundleIdsGetCollectionSortItem.Minusplatform => "-platform",
                BundleIdsGetCollectionSortItem.MinusseedId => "-seedId",
                BundleIdsGetCollectionSortItem.Id => "id",
                BundleIdsGetCollectionSortItem.Identifier => "identifier",
                BundleIdsGetCollectionSortItem.Name => "name",
                BundleIdsGetCollectionSortItem.Platform => "platform",
                BundleIdsGetCollectionSortItem.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-id" => BundleIdsGetCollectionSortItem.Minusid,
                "-identifier" => BundleIdsGetCollectionSortItem.Minusidentifier,
                "-name" => BundleIdsGetCollectionSortItem.Minusname,
                "-platform" => BundleIdsGetCollectionSortItem.Minusplatform,
                "-seedId" => BundleIdsGetCollectionSortItem.MinusseedId,
                "id" => BundleIdsGetCollectionSortItem.Id,
                "identifier" => BundleIdsGetCollectionSortItem.Identifier,
                "name" => BundleIdsGetCollectionSortItem.Name,
                "platform" => BundleIdsGetCollectionSortItem.Platform,
                "seedId" => BundleIdsGetCollectionSortItem.SeedId,
                _ => null,
            };
        }
    }
}