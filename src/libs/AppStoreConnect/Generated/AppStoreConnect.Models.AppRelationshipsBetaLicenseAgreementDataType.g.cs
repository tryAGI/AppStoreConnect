
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsBetaLicenseAgreementDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsBetaLicenseAgreementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsBetaLicenseAgreementDataType value)
        {
            return value switch
            {
                AppRelationshipsBetaLicenseAgreementDataType.BetaLicenseAgreements => "betaLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsBetaLicenseAgreementDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaLicenseAgreements" => AppRelationshipsBetaLicenseAgreementDataType.BetaLicenseAgreements,
                _ => null,
            };
        }
    }
}