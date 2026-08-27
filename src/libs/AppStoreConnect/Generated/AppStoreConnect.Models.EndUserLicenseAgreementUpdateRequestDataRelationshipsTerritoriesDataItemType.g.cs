
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritoriesDataItemType value)
        {
            return value switch
            {
                EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}