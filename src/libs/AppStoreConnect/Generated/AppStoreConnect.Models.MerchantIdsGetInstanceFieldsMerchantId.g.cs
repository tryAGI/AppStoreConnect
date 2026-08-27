
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdsGetInstanceFieldsMerchantId
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
    public static class MerchantIdsGetInstanceFieldsMerchantIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetInstanceFieldsMerchantId value)
        {
            return value switch
            {
                MerchantIdsGetInstanceFieldsMerchantId.Certificates => "certificates",
                MerchantIdsGetInstanceFieldsMerchantId.Identifier => "identifier",
                MerchantIdsGetInstanceFieldsMerchantId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetInstanceFieldsMerchantId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdsGetInstanceFieldsMerchantId.Certificates,
                "identifier" => MerchantIdsGetInstanceFieldsMerchantId.Identifier,
                "name" => MerchantIdsGetInstanceFieldsMerchantId.Name,
                _ => null,
            };
        }
    }
}