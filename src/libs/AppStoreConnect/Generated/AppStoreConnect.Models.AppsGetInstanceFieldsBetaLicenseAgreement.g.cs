
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsBetaLicenseAgreement
    {
        /// <summary>
        /// 
        /// </summary>
        AgreementText,
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetInstanceFieldsBetaLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsBetaLicenseAgreement value)
        {
            return value switch
            {
                AppsGetInstanceFieldsBetaLicenseAgreement.AgreementText => "agreementText",
                AppsGetInstanceFieldsBetaLicenseAgreement.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsBetaLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => AppsGetInstanceFieldsBetaLicenseAgreement.AgreementText,
                "app" => AppsGetInstanceFieldsBetaLicenseAgreement.App,
                _ => null,
            };
        }
    }
}