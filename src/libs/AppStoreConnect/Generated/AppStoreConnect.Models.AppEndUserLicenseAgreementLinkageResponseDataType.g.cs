
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEndUserLicenseAgreementLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        EndUserLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEndUserLicenseAgreementLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEndUserLicenseAgreementLinkageResponseDataType value)
        {
            return value switch
            {
                AppEndUserLicenseAgreementLinkageResponseDataType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEndUserLicenseAgreementLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "endUserLicenseAgreements" => AppEndUserLicenseAgreementLinkageResponseDataType.EndUserLicenseAgreements,
                _ => null,
            };
        }
    }
}