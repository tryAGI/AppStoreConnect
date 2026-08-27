
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsBetaLicenseAgreement
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
    public static class AppsGetCollectionFieldsBetaLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsBetaLicenseAgreement value)
        {
            return value switch
            {
                AppsGetCollectionFieldsBetaLicenseAgreement.AgreementText => "agreementText",
                AppsGetCollectionFieldsBetaLicenseAgreement.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsBetaLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => AppsGetCollectionFieldsBetaLicenseAgreement.AgreementText,
                "app" => AppsGetCollectionFieldsBetaLicenseAgreement.App,
                _ => null,
            };
        }
    }
}