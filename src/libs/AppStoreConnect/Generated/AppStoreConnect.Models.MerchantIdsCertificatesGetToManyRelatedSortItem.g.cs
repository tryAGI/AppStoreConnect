
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdsCertificatesGetToManyRelatedSortItem
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
    public static class MerchantIdsCertificatesGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsCertificatesGetToManyRelatedSortItem value)
        {
            return value switch
            {
                MerchantIdsCertificatesGetToManyRelatedSortItem.MinuscertificateType => "-certificateType",
                MerchantIdsCertificatesGetToManyRelatedSortItem.MinusdisplayName => "-displayName",
                MerchantIdsCertificatesGetToManyRelatedSortItem.Minusid => "-id",
                MerchantIdsCertificatesGetToManyRelatedSortItem.MinusserialNumber => "-serialNumber",
                MerchantIdsCertificatesGetToManyRelatedSortItem.CertificateType => "certificateType",
                MerchantIdsCertificatesGetToManyRelatedSortItem.DisplayName => "displayName",
                MerchantIdsCertificatesGetToManyRelatedSortItem.Id => "id",
                MerchantIdsCertificatesGetToManyRelatedSortItem.SerialNumber => "serialNumber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsCertificatesGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-certificateType" => MerchantIdsCertificatesGetToManyRelatedSortItem.MinuscertificateType,
                "-displayName" => MerchantIdsCertificatesGetToManyRelatedSortItem.MinusdisplayName,
                "-id" => MerchantIdsCertificatesGetToManyRelatedSortItem.Minusid,
                "-serialNumber" => MerchantIdsCertificatesGetToManyRelatedSortItem.MinusserialNumber,
                "certificateType" => MerchantIdsCertificatesGetToManyRelatedSortItem.CertificateType,
                "displayName" => MerchantIdsCertificatesGetToManyRelatedSortItem.DisplayName,
                "id" => MerchantIdsCertificatesGetToManyRelatedSortItem.Id,
                "serialNumber" => MerchantIdsCertificatesGetToManyRelatedSortItem.SerialNumber,
                _ => null,
            };
        }
    }
}