
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsEndUserLicenseAgreement
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
    public static class AppsGetCollectionFieldsEndUserLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsEndUserLicenseAgreement value)
        {
            return value switch
            {
                AppsGetCollectionFieldsEndUserLicenseAgreement.AgreementText => "agreementText",
                AppsGetCollectionFieldsEndUserLicenseAgreement.App => "app",
                AppsGetCollectionFieldsEndUserLicenseAgreement.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsEndUserLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => AppsGetCollectionFieldsEndUserLicenseAgreement.AgreementText,
                "app" => AppsGetCollectionFieldsEndUserLicenseAgreement.App,
                "territories" => AppsGetCollectionFieldsEndUserLicenseAgreement.Territories,
                _ => null,
            };
        }
    }
}