
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CertificateType2
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
    public static class CertificateType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateType2 value)
        {
            return value switch
            {
                CertificateType2.ApplePay => "APPLE_PAY",
                CertificateType2.ApplePayMerchantIdentity => "APPLE_PAY_MERCHANT_IDENTITY",
                CertificateType2.ApplePayPspIdentity => "APPLE_PAY_PSP_IDENTITY",
                CertificateType2.ApplePayRsa => "APPLE_PAY_RSA",
                CertificateType2.DeveloperIdApplication => "DEVELOPER_ID_APPLICATION",
                CertificateType2.DeveloperIdApplicationG2 => "DEVELOPER_ID_APPLICATION_G2",
                CertificateType2.DeveloperIdKext => "DEVELOPER_ID_KEXT",
                CertificateType2.DeveloperIdKextG2 => "DEVELOPER_ID_KEXT_G2",
                CertificateType2.Development => "DEVELOPMENT",
                CertificateType2.Distribution => "DISTRIBUTION",
                CertificateType2.IdentityAccess => "IDENTITY_ACCESS",
                CertificateType2.IosDevelopment => "IOS_DEVELOPMENT",
                CertificateType2.IosDistribution => "IOS_DISTRIBUTION",
                CertificateType2.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                CertificateType2.MacAppDistribution => "MAC_APP_DISTRIBUTION",
                CertificateType2.MacInstallerDistribution => "MAC_INSTALLER_DISTRIBUTION",
                CertificateType2.PassTypeId => "PASS_TYPE_ID",
                CertificateType2.PassTypeIdWithNfc => "PASS_TYPE_ID_WITH_NFC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateType2? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_PAY" => CertificateType2.ApplePay,
                "APPLE_PAY_MERCHANT_IDENTITY" => CertificateType2.ApplePayMerchantIdentity,
                "APPLE_PAY_PSP_IDENTITY" => CertificateType2.ApplePayPspIdentity,
                "APPLE_PAY_RSA" => CertificateType2.ApplePayRsa,
                "DEVELOPER_ID_APPLICATION" => CertificateType2.DeveloperIdApplication,
                "DEVELOPER_ID_APPLICATION_G2" => CertificateType2.DeveloperIdApplicationG2,
                "DEVELOPER_ID_KEXT" => CertificateType2.DeveloperIdKext,
                "DEVELOPER_ID_KEXT_G2" => CertificateType2.DeveloperIdKextG2,
                "DEVELOPMENT" => CertificateType2.Development,
                "DISTRIBUTION" => CertificateType2.Distribution,
                "IDENTITY_ACCESS" => CertificateType2.IdentityAccess,
                "IOS_DEVELOPMENT" => CertificateType2.IosDevelopment,
                "IOS_DISTRIBUTION" => CertificateType2.IosDistribution,
                "MAC_APP_DEVELOPMENT" => CertificateType2.MacAppDevelopment,
                "MAC_APP_DISTRIBUTION" => CertificateType2.MacAppDistribution,
                "MAC_INSTALLER_DISTRIBUTION" => CertificateType2.MacInstallerDistribution,
                "PASS_TYPE_ID" => CertificateType2.PassTypeId,
                "PASS_TYPE_ID_WITH_NFC" => CertificateType2.PassTypeIdWithNfc,
                _ => null,
            };
        }
    }
}