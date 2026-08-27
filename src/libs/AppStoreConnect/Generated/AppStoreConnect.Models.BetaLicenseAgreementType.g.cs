
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaLicenseAgreementType
    {
        /// <summary>
        ///
        /// </summary>
        BetaLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLicenseAgreementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementType value)
        {
            return value switch
            {
                BetaLicenseAgreementType.BetaLicenseAgreements => "betaLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementType? ToEnum(string value)
        {
            return value switch
            {
                "betaLicenseAgreements" => BetaLicenseAgreementType.BetaLicenseAgreements,
                _ => null,
            };
        }
    }
}