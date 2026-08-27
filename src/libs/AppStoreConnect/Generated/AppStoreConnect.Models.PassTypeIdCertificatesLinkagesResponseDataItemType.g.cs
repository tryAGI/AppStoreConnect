
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdCertificatesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdCertificatesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdCertificatesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                PassTypeIdCertificatesLinkagesResponseDataItemType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdCertificatesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdCertificatesLinkagesResponseDataItemType.Certificates,
                _ => null,
            };
        }
    }
}