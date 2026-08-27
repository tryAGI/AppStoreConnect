
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserLicenseAgreementUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        EndUserLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementUpdateRequestDataType value)
        {
            return value switch
            {
                EndUserLicenseAgreementUpdateRequestDataType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "endUserLicenseAgreements" => EndUserLicenseAgreementUpdateRequestDataType.EndUserLicenseAgreements,
                _ => null,
            };
        }
    }
}