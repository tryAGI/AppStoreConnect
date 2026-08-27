
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserLicenseAgreementCreateRequestDataRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementCreateRequestDataRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementCreateRequestDataRelationshipsAppDataType value)
        {
            return value switch
            {
                EndUserLicenseAgreementCreateRequestDataRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementCreateRequestDataRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => EndUserLicenseAgreementCreateRequestDataRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}