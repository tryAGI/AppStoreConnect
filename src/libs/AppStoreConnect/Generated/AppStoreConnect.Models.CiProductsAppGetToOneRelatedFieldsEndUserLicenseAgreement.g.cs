
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement
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
    public static class CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement.AgreementText => "agreementText",
                CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement.App => "app",
                CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement.AgreementText,
                "app" => CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement.App,
                "territories" => CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement.Territories,
                _ => null,
            };
        }
    }
}