
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificatesGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        PassTypeId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetCollectionIncludeItem value)
        {
            return value switch
            {
                CertificatesGetCollectionIncludeItem.PassTypeId => "passTypeId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "passTypeId" => CertificatesGetCollectionIncludeItem.PassTypeId,
                _ => null,
            };
        }
    }
}