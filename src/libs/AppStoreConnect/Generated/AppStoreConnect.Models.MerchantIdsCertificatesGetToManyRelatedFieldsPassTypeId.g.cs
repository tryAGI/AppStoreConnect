
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId
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
    public static class MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId value)
        {
            return value switch
            {
                MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId.Certificates => "certificates",
                MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId.Identifier => "identifier",
                MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId.Certificates,
                "identifier" => MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId.Identifier,
                "name" => MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}