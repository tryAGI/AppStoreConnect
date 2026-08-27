
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificatesPassTypeIdGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesPassTypeIdGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesPassTypeIdGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                CertificatesPassTypeIdGetToOneRelatedIncludeItem.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesPassTypeIdGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => CertificatesPassTypeIdGetToOneRelatedIncludeItem.Certificates,
                _ => null,
            };
        }
    }
}