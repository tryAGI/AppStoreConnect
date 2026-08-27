
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificatesGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuscertificateType,
        /// <summary>
        ///
        /// </summary>
        MinusdisplayName,
        /// <summary>
        ///
        /// </summary>
        Minusid,
        /// <summary>
        ///
        /// </summary>
        MinusserialNumber,
        /// <summary>
        ///
        /// </summary>
        CertificateType,
        /// <summary>
        ///
        /// </summary>
        DisplayName,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        SerialNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetCollectionSortItem value)
        {
            return value switch
            {
                CertificatesGetCollectionSortItem.MinuscertificateType => "-certificateType",
                CertificatesGetCollectionSortItem.MinusdisplayName => "-displayName",
                CertificatesGetCollectionSortItem.Minusid => "-id",
                CertificatesGetCollectionSortItem.MinusserialNumber => "-serialNumber",
                CertificatesGetCollectionSortItem.CertificateType => "certificateType",
                CertificatesGetCollectionSortItem.DisplayName => "displayName",
                CertificatesGetCollectionSortItem.Id => "id",
                CertificatesGetCollectionSortItem.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-certificateType" => CertificatesGetCollectionSortItem.MinuscertificateType,
                "-displayName" => CertificatesGetCollectionSortItem.MinusdisplayName,
                "-id" => CertificatesGetCollectionSortItem.Minusid,
                "-serialNumber" => CertificatesGetCollectionSortItem.MinusserialNumber,
                "certificateType" => CertificatesGetCollectionSortItem.CertificateType,
                "displayName" => CertificatesGetCollectionSortItem.DisplayName,
                "id" => CertificatesGetCollectionSortItem.Id,
                "serialNumber" => CertificatesGetCollectionSortItem.SerialNumber,
                _ => null,
            };
        }
    }
}