
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        EndUserLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementCreateRequestDataType value)
        {
            return value switch
            {
                EndUserLicenseAgreementCreateRequestDataType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "endUserLicenseAgreements" => EndUserLicenseAgreementCreateRequestDataType.EndUserLicenseAgreements,
                _ => null,
            };
        }
    }
}