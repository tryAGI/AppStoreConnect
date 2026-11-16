
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CertificateType
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
    public static class CertificateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateType value)
        {
            return value switch
            {
                CertificateType.ApplePay => "APPLE_PAY",
                CertificateType.ApplePayMerchantIdentity => "APPLE_PAY_MERCHANT_IDENTITY",
                CertificateType.ApplePayPspIdentity => "APPLE_PAY_PSP_IDENTITY",
                CertificateType.ApplePayRsa => "APPLE_PAY_RSA",
                CertificateType.DeveloperIdApplication => "DEVELOPER_ID_APPLICATION",
                CertificateType.DeveloperIdApplicationG2 => "DEVELOPER_ID_APPLICATION_G2",
                CertificateType.DeveloperIdKext => "DEVELOPER_ID_KEXT",
                CertificateType.DeveloperIdKextG2 => "DEVELOPER_ID_KEXT_G2",
                CertificateType.Development => "DEVELOPMENT",
                CertificateType.Distribution => "DISTRIBUTION",
                CertificateType.IdentityAccess => "IDENTITY_ACCESS",
                CertificateType.IosDevelopment => "IOS_DEVELOPMENT",
                CertificateType.IosDistribution => "IOS_DISTRIBUTION",
                CertificateType.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                CertificateType.MacAppDistribution => "MAC_APP_DISTRIBUTION",
                CertificateType.MacInstallerDistribution => "MAC_INSTALLER_DISTRIBUTION",
                CertificateType.PassTypeId => "PASS_TYPE_ID",
                CertificateType.PassTypeIdWithNfc => "PASS_TYPE_ID_WITH_NFC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateType? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_PAY" => CertificateType.ApplePay,
                "APPLE_PAY_MERCHANT_IDENTITY" => CertificateType.ApplePayMerchantIdentity,
                "APPLE_PAY_PSP_IDENTITY" => CertificateType.ApplePayPspIdentity,
                "APPLE_PAY_RSA" => CertificateType.ApplePayRsa,
                "DEVELOPER_ID_APPLICATION" => CertificateType.DeveloperIdApplication,
                "DEVELOPER_ID_APPLICATION_G2" => CertificateType.DeveloperIdApplicationG2,
                "DEVELOPER_ID_KEXT" => CertificateType.DeveloperIdKext,
                "DEVELOPER_ID_KEXT_G2" => CertificateType.DeveloperIdKextG2,
                "DEVELOPMENT" => CertificateType.Development,
                "DISTRIBUTION" => CertificateType.Distribution,
                "IDENTITY_ACCESS" => CertificateType.IdentityAccess,
                "IOS_DEVELOPMENT" => CertificateType.IosDevelopment,
                "IOS_DISTRIBUTION" => CertificateType.IosDistribution,
                "MAC_APP_DEVELOPMENT" => CertificateType.MacAppDevelopment,
                "MAC_APP_DISTRIBUTION" => CertificateType.MacAppDistribution,
                "MAC_INSTALLER_DISTRIBUTION" => CertificateType.MacInstallerDistribution,
                "PASS_TYPE_ID" => CertificateType.PassTypeId,
                "PASS_TYPE_ID_WITH_NFC" => CertificateType.PassTypeIdWithNfc,
                _ => null,
            };
        }
    }
}