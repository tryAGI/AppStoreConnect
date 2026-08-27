
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem
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
    public static class MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem value)
        {
            return value switch
            {
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePay => "APPLE_PAY",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayMerchantIdentity => "APPLE_PAY_MERCHANT_IDENTITY",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayPspIdentity => "APPLE_PAY_PSP_IDENTITY",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayRsa => "APPLE_PAY_RSA",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplication => "DEVELOPER_ID_APPLICATION",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplicationG2 => "DEVELOPER_ID_APPLICATION_G2",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKext => "DEVELOPER_ID_KEXT",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKextG2 => "DEVELOPER_ID_KEXT_G2",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Development => "DEVELOPMENT",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Distribution => "DISTRIBUTION",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IdentityAccess => "IDENTITY_ACCESS",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDevelopment => "IOS_DEVELOPMENT",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDistribution => "IOS_DISTRIBUTION",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDistribution => "MAC_APP_DISTRIBUTION",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacInstallerDistribution => "MAC_INSTALLER_DISTRIBUTION",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeId => "PASS_TYPE_ID",
                MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeIdWithNfc => "PASS_TYPE_ID_WITH_NFC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_PAY" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePay,
                "APPLE_PAY_MERCHANT_IDENTITY" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayMerchantIdentity,
                "APPLE_PAY_PSP_IDENTITY" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayPspIdentity,
                "APPLE_PAY_RSA" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.ApplePayRsa,
                "DEVELOPER_ID_APPLICATION" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplication,
                "DEVELOPER_ID_APPLICATION_G2" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdApplicationG2,
                "DEVELOPER_ID_KEXT" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKext,
                "DEVELOPER_ID_KEXT_G2" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.DeveloperIdKextG2,
                "DEVELOPMENT" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Development,
                "DISTRIBUTION" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.Distribution,
                "IDENTITY_ACCESS" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IdentityAccess,
                "IOS_DEVELOPMENT" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDevelopment,
                "IOS_DISTRIBUTION" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.IosDistribution,
                "MAC_APP_DEVELOPMENT" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDevelopment,
                "MAC_APP_DISTRIBUTION" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacAppDistribution,
                "MAC_INSTALLER_DISTRIBUTION" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.MacInstallerDistribution,
                "PASS_TYPE_ID" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeId,
                "PASS_TYPE_ID_WITH_NFC" => MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem.PassTypeIdWithNfc,
                _ => null,
            };
        }
    }
}