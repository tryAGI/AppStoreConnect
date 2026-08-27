
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsGetCollectionFieldsMerchantId
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
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
    public static class MerchantIdsGetCollectionFieldsMerchantIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetCollectionFieldsMerchantId value)
        {
            return value switch
            {
                MerchantIdsGetCollectionFieldsMerchantId.Certificates => "certificates",
                MerchantIdsGetCollectionFieldsMerchantId.Identifier => "identifier",
                MerchantIdsGetCollectionFieldsMerchantId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetCollectionFieldsMerchantId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdsGetCollectionFieldsMerchantId.Certificates,
                "identifier" => MerchantIdsGetCollectionFieldsMerchantId.Identifier,
                "name" => MerchantIdsGetCollectionFieldsMerchantId.Name,
                _ => null,
            };
        }
    }
}