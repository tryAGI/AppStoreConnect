
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificatePassTypeIdLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PassTypeIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatePassTypeIdLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatePassTypeIdLinkageResponseDataType value)
        {
            return value switch
            {
                CertificatePassTypeIdLinkageResponseDataType.PassTypeIds => "passTypeIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatePassTypeIdLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "passTypeIds" => CertificatePassTypeIdLinkageResponseDataType.PassTypeIds,
                _ => null,
            };
        }
    }
}