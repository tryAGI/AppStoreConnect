
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetCollectionIncludeItem value)
        {
            return value switch
            {
                MerchantIdsGetCollectionIncludeItem.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdsGetCollectionIncludeItem.Certificates,
                _ => null,
            };
        }
    }
}