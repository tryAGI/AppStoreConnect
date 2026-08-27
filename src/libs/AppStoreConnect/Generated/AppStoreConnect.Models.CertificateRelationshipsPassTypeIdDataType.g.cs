
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificateRelationshipsPassTypeIdDataType
    {
        /// <summary>
        ///
        /// </summary>
        PassTypeIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateRelationshipsPassTypeIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateRelationshipsPassTypeIdDataType value)
        {
            return value switch
            {
                CertificateRelationshipsPassTypeIdDataType.PassTypeIds => "passTypeIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateRelationshipsPassTypeIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "passTypeIds" => CertificateRelationshipsPassTypeIdDataType.PassTypeIds,
                _ => null,
            };
        }
    }
}