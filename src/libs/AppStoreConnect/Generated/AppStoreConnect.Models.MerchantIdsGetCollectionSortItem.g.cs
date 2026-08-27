
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdsGetCollectionSortItem
    {
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
        Identifier,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetCollectionSortItem value)
        {
            return value switch
            {
                MerchantIdsGetCollectionSortItem.Minusidentifier => "-identifier",
                MerchantIdsGetCollectionSortItem.Minusname => "-name",
                MerchantIdsGetCollectionSortItem.Identifier => "identifier",
                MerchantIdsGetCollectionSortItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-identifier" => MerchantIdsGetCollectionSortItem.Minusidentifier,
                "-name" => MerchantIdsGetCollectionSortItem.Minusname,
                "identifier" => MerchantIdsGetCollectionSortItem.Identifier,
                "name" => MerchantIdsGetCollectionSortItem.Name,
                _ => null,
            };
        }
    }
}