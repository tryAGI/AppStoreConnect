
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaLicenseAgreementRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLicenseAgreementRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementRelationshipsAppDataType value)
        {
            return value switch
            {
                BetaLicenseAgreementRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaLicenseAgreementRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}