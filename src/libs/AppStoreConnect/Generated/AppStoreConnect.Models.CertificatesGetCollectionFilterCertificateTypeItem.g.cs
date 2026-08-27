
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificatesGetCollectionFilterCertificateTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ApplePay,
        /// <summary>
        /// 
        /// </summary>
        ApplePayMerchantIdentity,
        /// <summary>
        /// 
        /// </summary>
        ApplePayPspIdentity,
        /// <summary>
        /// 
        /// </summary>
        ApplePayRsa,
        /// <summary>
        /// 
        /// </summary>
        DeveloperIdApplication,
        /// <summary>
        /// 
        /// </summary>
        DeveloperIdApplicationG2,
        /// <summary>
        /// 
        /// </summary>
        DeveloperIdKext,
        /// <summary>
        /// 
        /// </summary>
        DeveloperIdKextG2,
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Distribution,
        /// <summary>
        /// 
        /// </summary>
        IdentityAccess,
        /// <summary>
        /// 
        /// </summary>
        IosDevelopment,
        /// <summary>
        /// 
        /// </summary>
        IosDistribution,
        /// <summary>
        /// 
        /// </summary>
        MacAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        MacAppDistribution,
        /// <summary>
        /// 
        /// </summary>
        MacInstallerDistribution,
        /// <summary>
        /// 
        /// </summary>
        PassTypeId,
        /// <summary>
        /// 
        /// </summary>
        PassTypeIdWithNfc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificatesGetCollectionFilterCertificateTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificatesGetCollectionFilterCertificateTypeItem value)
        {
            return value switch
            {
                CertificatesGetCollectionFilterCertificateTypeItem.ApplePay => "APPLE_PAY",
                CertificatesGetCollectionFilterCertificateTypeItem.ApplePayMerchantIdentity => "APPLE_PAY_MERCHANT_IDENTITY",
                CertificatesGetCollectionFilterCertificateTypeItem.ApplePayPspIdentity => "APPLE_PAY_PSP_IDENTITY",
                CertificatesGetCollectionFilterCertificateTypeItem.ApplePayRsa => "APPLE_PAY_RSA",
                CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdApplication => "DEVELOPER_ID_APPLICATION",
                CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdApplicationG2 => "DEVELOPER_ID_APPLICATION_G2",
                CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdKext => "DEVELOPER_ID_KEXT",
                CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdKextG2 => "DEVELOPER_ID_KEXT_G2",
                CertificatesGetCollectionFilterCertificateTypeItem.Development => "DEVELOPMENT",
                CertificatesGetCollectionFilterCertificateTypeItem.Distribution => "DISTRIBUTION",
                CertificatesGetCollectionFilterCertificateTypeItem.IdentityAccess => "IDENTITY_ACCESS",
                CertificatesGetCollectionFilterCertificateTypeItem.IosDevelopment => "IOS_DEVELOPMENT",
                CertificatesGetCollectionFilterCertificateTypeItem.IosDistribution => "IOS_DISTRIBUTION",
                CertificatesGetCollectionFilterCertificateTypeItem.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                CertificatesGetCollectionFilterCertificateTypeItem.MacAppDistribution => "MAC_APP_DISTRIBUTION",
                CertificatesGetCollectionFilterCertificateTypeItem.MacInstallerDistribution => "MAC_INSTALLER_DISTRIBUTION",
                CertificatesGetCollectionFilterCertificateTypeItem.PassTypeId => "PASS_TYPE_ID",
                CertificatesGetCollectionFilterCertificateTypeItem.PassTypeIdWithNfc => "PASS_TYPE_ID_WITH_NFC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificatesGetCollectionFilterCertificateTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_PAY" => CertificatesGetCollectionFilterCertificateTypeItem.ApplePay,
                "APPLE_PAY_MERCHANT_IDENTITY" => CertificatesGetCollectionFilterCertificateTypeItem.ApplePayMerchantIdentity,
                "APPLE_PAY_PSP_IDENTITY" => CertificatesGetCollectionFilterCertificateTypeItem.ApplePayPspIdentity,
                "APPLE_PAY_RSA" => CertificatesGetCollectionFilterCertificateTypeItem.ApplePayRsa,
                "DEVELOPER_ID_APPLICATION" => CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdApplication,
                "DEVELOPER_ID_APPLICATION_G2" => CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdApplicationG2,
                "DEVELOPER_ID_KEXT" => CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdKext,
                "DEVELOPER_ID_KEXT_G2" => CertificatesGetCollectionFilterCertificateTypeItem.DeveloperIdKextG2,
                "DEVELOPMENT" => CertificatesGetCollectionFilterCertificateTypeItem.Development,
                "DISTRIBUTION" => CertificatesGetCollectionFilterCertificateTypeItem.Distribution,
                "IDENTITY_ACCESS" => CertificatesGetCollectionFilterCertificateTypeItem.IdentityAccess,
                "IOS_DEVELOPMENT" => CertificatesGetCollectionFilterCertificateTypeItem.IosDevelopment,
                "IOS_DISTRIBUTION" => CertificatesGetCollectionFilterCertificateTypeItem.IosDistribution,
                "MAC_APP_DEVELOPMENT" => CertificatesGetCollectionFilterCertificateTypeItem.MacAppDevelopment,
                "MAC_APP_DISTRIBUTION" => CertificatesGetCollectionFilterCertificateTypeItem.MacAppDistribution,
                "MAC_INSTALLER_DISTRIBUTION" => CertificatesGetCollectionFilterCertificateTypeItem.MacInstallerDistribution,
                "PASS_TYPE_ID" => CertificatesGetCollectionFilterCertificateTypeItem.PassTypeId,
                "PASS_TYPE_ID_WITH_NFC" => CertificatesGetCollectionFilterCertificateTypeItem.PassTypeIdWithNfc,
                _ => null,
            };
        }
    }
}