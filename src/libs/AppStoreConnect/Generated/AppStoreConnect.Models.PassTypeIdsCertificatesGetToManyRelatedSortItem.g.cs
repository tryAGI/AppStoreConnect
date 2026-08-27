
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdsCertificatesGetToManyRelatedSortItem
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
    public static class PassTypeIdsCertificatesGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsCertificatesGetToManyRelatedSortItem value)
        {
            return value switch
            {
                PassTypeIdsCertificatesGetToManyRelatedSortItem.MinuscertificateType => "-certificateType",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.MinusdisplayName => "-displayName",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.Minusid => "-id",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.MinusserialNumber => "-serialNumber",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.CertificateType => "certificateType",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.DisplayName => "displayName",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.Id => "id",
                PassTypeIdsCertificatesGetToManyRelatedSortItem.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsCertificatesGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-certificateType" => PassTypeIdsCertificatesGetToManyRelatedSortItem.MinuscertificateType,
                "-displayName" => PassTypeIdsCertificatesGetToManyRelatedSortItem.MinusdisplayName,
                "-id" => PassTypeIdsCertificatesGetToManyRelatedSortItem.Minusid,
                "-serialNumber" => PassTypeIdsCertificatesGetToManyRelatedSortItem.MinusserialNumber,
                "certificateType" => PassTypeIdsCertificatesGetToManyRelatedSortItem.CertificateType,
                "displayName" => PassTypeIdsCertificatesGetToManyRelatedSortItem.DisplayName,
                "id" => PassTypeIdsCertificatesGetToManyRelatedSortItem.Id,
                "serialNumber" => PassTypeIdsCertificatesGetToManyRelatedSortItem.SerialNumber,
                _ => null,
            };
        }
    }
}