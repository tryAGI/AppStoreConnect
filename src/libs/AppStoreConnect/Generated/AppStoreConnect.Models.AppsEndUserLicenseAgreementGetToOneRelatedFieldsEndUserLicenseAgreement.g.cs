
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement
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
    public static class AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement value)
        {
            return value switch
            {
                AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement.AgreementText => "agreementText",
                AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement.App => "app",
                AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement.AgreementText,
                "app" => AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement.App,
                "territories" => AppsEndUserLicenseAgreementGetToOneRelatedFieldsEndUserLicenseAgreement.Territories,
                _ => null,
            };
        }
    }
}