
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppBetaLicenseAgreementLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBetaLicenseAgreementLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBetaLicenseAgreementLinkageResponseDataType value)
        {
            return value switch
            {
                AppBetaLicenseAgreementLinkageResponseDataType.BetaLicenseAgreements => "betaLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBetaLicenseAgreementLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaLicenseAgreements" => AppBetaLicenseAgreementLinkageResponseDataType.BetaLicenseAgreements,
                _ => null,
            };
        }
    }
}