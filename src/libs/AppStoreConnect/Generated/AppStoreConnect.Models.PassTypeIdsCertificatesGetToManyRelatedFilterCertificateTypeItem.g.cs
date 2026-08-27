
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem
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
    public static class PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem value)
        {
            return value switch
            {
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePay => "APPLE_PAY",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayMerchantIdentity => "APPLE_PAY_MERCHANT_IDENTITY",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayPspIdentity => "APPLE_PAY_PSP_IDENTITY",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayRsa => "APPLE_PAY_RSA",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplication => "DEVELOPER_ID_APPLICATION",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplicationG2 => "DEVELOPER_ID_APPLICATION_G2",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKext => "DEVELOPER_ID_KEXT",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKextG2 => "DEVELOPER_ID_KEXT_G2",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Development => "DEVELOPMENT",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Distribution => "DISTRIBUTION",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IdentityAccess => "IDENTITY_ACCESS",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDevelopment => "IOS_DEVELOPMENT",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDistribution => "IOS_DISTRIBUTION",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDistribution => "MAC_APP_DISTRIBUTION",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacInstallerDistribution => "MAC_INSTALLER_DISTRIBUTION",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeId => "PASS_TYPE_ID",
                PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeIdWithNfc => "PASS_TYPE_ID_WITH_NFC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_PAY" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePay,
                "APPLE_PAY_MERCHANT_IDENTITY" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayMerchantIdentity,
                "APPLE_PAY_PSP_IDENTITY" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayPspIdentity,
                "APPLE_PAY_RSA" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayRsa,
                "DEVELOPER_ID_APPLICATION" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplication,
                "DEVELOPER_ID_APPLICATION_G2" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplicationG2,
                "DEVELOPER_ID_KEXT" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKext,
                "DEVELOPER_ID_KEXT_G2" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKextG2,
                "DEVELOPMENT" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Development,
                "DISTRIBUTION" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Distribution,
                "IDENTITY_ACCESS" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IdentityAccess,
                "IOS_DEVELOPMENT" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDevelopment,
                "IOS_DISTRIBUTION" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDistribution,
                "MAC_APP_DEVELOPMENT" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDevelopment,
                "MAC_APP_DISTRIBUTION" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDistribution,
                "MAC_INSTALLER_DISTRIBUTION" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacInstallerDistribution,
                "PASS_TYPE_ID" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeId,
                "PASS_TYPE_ID_WITH_NFC" => PassTypeIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeIdWithNfc,
                _ => null,
            };
        }
    }
}