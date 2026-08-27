
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsEndUserLicenseAgreement
    {
        /// <summary>
        ///
        /// </summary>
        AgreementText,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetInstanceFieldsEndUserLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsEndUserLicenseAgreement value)
        {
            return value switch
            {
                AppsGetInstanceFieldsEndUserLicenseAgreement.AgreementText => "agreementText",
                AppsGetInstanceFieldsEndUserLicenseAgreement.App => "app",
                AppsGetInstanceFieldsEndUserLicenseAgreement.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsEndUserLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => AppsGetInstanceFieldsEndUserLicenseAgreement.AgreementText,
                "app" => AppsGetInstanceFieldsEndUserLicenseAgreement.App,
                "territories" => AppsGetInstanceFieldsEndUserLicenseAgreement.Territories,
                _ => null,
            };
        }
    }
}