
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement
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
    public static class EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement value)
        {
            return value switch
            {
                EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement.AgreementText => "agreementText",
                EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement.App => "app",
                EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement.AgreementText,
                "app" => EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement.App,
                "territories" => EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement.Territories,
                _ => null,
            };
        }
    }
}