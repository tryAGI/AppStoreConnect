
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdRelationshipsCertificatesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdRelationshipsCertificatesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdRelationshipsCertificatesDataItemType value)
        {
            return value switch
            {
                MerchantIdRelationshipsCertificatesDataItemType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdRelationshipsCertificatesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdRelationshipsCertificatesDataItemType.Certificates,
                _ => null,
            };
        }
    }
}