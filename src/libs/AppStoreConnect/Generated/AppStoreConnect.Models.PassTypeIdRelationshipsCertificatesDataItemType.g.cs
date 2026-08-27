
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdRelationshipsCertificatesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdRelationshipsCertificatesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdRelationshipsCertificatesDataItemType value)
        {
            return value switch
            {
                PassTypeIdRelationshipsCertificatesDataItemType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdRelationshipsCertificatesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdRelationshipsCertificatesDataItemType.Certificates,
                _ => null,
            };
        }
    }
}