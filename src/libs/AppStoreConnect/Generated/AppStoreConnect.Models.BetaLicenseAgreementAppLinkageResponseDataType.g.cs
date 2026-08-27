
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaLicenseAgreementAppLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLicenseAgreementAppLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementAppLinkageResponseDataType value)
        {
            return value switch
            {
                BetaLicenseAgreementAppLinkageResponseDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementAppLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaLicenseAgreementAppLinkageResponseDataType.Apps,
                _ => null,
            };
        }
    }
}