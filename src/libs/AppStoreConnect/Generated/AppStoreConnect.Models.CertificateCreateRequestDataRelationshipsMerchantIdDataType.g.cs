
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificateCreateRequestDataRelationshipsMerchantIdDataType
    {
        /// <summary>
        /// 
        /// </summary>
        MerchantIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateCreateRequestDataRelationshipsMerchantIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateCreateRequestDataRelationshipsMerchantIdDataType value)
        {
            return value switch
            {
                CertificateCreateRequestDataRelationshipsMerchantIdDataType.MerchantIds => "merchantIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateCreateRequestDataRelationshipsMerchantIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "merchantIds" => CertificateCreateRequestDataRelationshipsMerchantIdDataType.MerchantIds,
                _ => null,
            };
        }
    }
}