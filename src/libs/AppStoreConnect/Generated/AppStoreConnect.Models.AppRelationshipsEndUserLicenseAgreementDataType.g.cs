
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsEndUserLicenseAgreementDataType
    {
        /// <summary>
        ///
        /// </summary>
        EndUserLicenseAgreements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsEndUserLicenseAgreementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsEndUserLicenseAgreementDataType value)
        {
            return value switch
            {
                AppRelationshipsEndUserLicenseAgreementDataType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsEndUserLicenseAgreementDataType? ToEnum(string value)
        {
            return value switch
            {
                "endUserLicenseAgreements" => AppRelationshipsEndUserLicenseAgreementDataType.EndUserLicenseAgreements,
                _ => null,
            };
        }
    }
}