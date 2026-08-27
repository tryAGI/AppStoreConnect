
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificateCreateRequestDataRelationshipsPassTypeIdDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PassTypeIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateCreateRequestDataRelationshipsPassTypeIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateCreateRequestDataRelationshipsPassTypeIdDataType value)
        {
            return value switch
            {
                CertificateCreateRequestDataRelationshipsPassTypeIdDataType.PassTypeIds => "passTypeIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateCreateRequestDataRelationshipsPassTypeIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "passTypeIds" => CertificateCreateRequestDataRelationshipsPassTypeIdDataType.PassTypeIds,
                _ => null,
            };
        }
    }
}