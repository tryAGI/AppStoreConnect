
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement
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
    public static class CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement.AgreementText => "agreementText",
                CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement.AgreementText,
                "app" => CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement.App,
                _ => null,
            };
        }
    }
}