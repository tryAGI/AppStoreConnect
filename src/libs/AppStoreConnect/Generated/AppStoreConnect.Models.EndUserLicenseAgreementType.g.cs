
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementType
    {
        /// <summary>
        /// 
        /// </summary>
        EndUserLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementType value)
        {
            return value switch
            {
                EndUserLicenseAgreementType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementType? ToEnum(string value)
        {
            return value switch
            {
                "endUserLicenseAgreements" => EndUserLicenseAgreementType.EndUserLicenseAgreements,
                _ => null,
            };
        }
    }
}