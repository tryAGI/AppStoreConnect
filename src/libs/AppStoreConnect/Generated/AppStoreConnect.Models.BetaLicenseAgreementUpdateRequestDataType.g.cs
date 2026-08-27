
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaLicenseAgreementUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLicenseAgreementUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementUpdateRequestDataType value)
        {
            return value switch
            {
                BetaLicenseAgreementUpdateRequestDataType.BetaLicenseAgreements => "betaLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaLicenseAgreements" => BetaLicenseAgreementUpdateRequestDataType.BetaLicenseAgreements,
                _ => null,
            };
        }
    }
}