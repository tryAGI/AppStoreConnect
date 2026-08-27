
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement
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
    public static class BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement value)
        {
            return value switch
            {
                BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement.AgreementText => "agreementText",
                BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement? ToEnum(string value)
        {
            return value switch
            {
                "agreementText" => BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement.AgreementText,
                "app" => BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement.App,
                _ => null,
            };
        }
    }
}