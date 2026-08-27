
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinusbundleId,
        /// <summary>
        /// 
        /// </summary>
        Minusname,
        /// <summary>
        /// 
        /// </summary>
        Minussku,
        /// <summary>
        /// 
        /// </summary>
        BundleId,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Sku,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionSortItem value)
        {
            return value switch
            {
                AppsGetCollectionSortItem.MinusbundleId => "-bundleId",
                AppsGetCollectionSortItem.Minusname => "-name",
                AppsGetCollectionSortItem.Minussku => "-sku",
                AppsGetCollectionSortItem.BundleId => "bundleId",
                AppsGetCollectionSortItem.Name => "name",
                AppsGetCollectionSortItem.Sku => "sku",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-bundleId" => AppsGetCollectionSortItem.MinusbundleId,
                "-name" => AppsGetCollectionSortItem.Minusname,
                "-sku" => AppsGetCollectionSortItem.Minussku,
                "bundleId" => AppsGetCollectionSortItem.BundleId,
                "name" => AppsGetCollectionSortItem.Name,
                "sku" => AppsGetCollectionSortItem.Sku,
                _ => null,
            };
        }
    }
}