
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement
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
    public static class AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement value)
        {
            return value switch
            {
                AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement.AgreementText => "agreementText",
                AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement.AgreementText,
                "app" => AppsBetaLicenseAgreementGetToOneRelatedFieldsBetaLicenseAgreement.App,
                _ => null,
            };
        }
    }
}