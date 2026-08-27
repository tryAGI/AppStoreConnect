
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdCertificatesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdCertificatesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdCertificatesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                MerchantIdCertificatesLinkagesResponseDataItemType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdCertificatesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdCertificatesLinkagesResponseDataItemType.Certificates,
                _ => null,
            };
        }
    }
}