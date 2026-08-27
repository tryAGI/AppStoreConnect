
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserLicenseAgreementRelationshipsTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementRelationshipsTerritoriesDataItemType value)
        {
            return value switch
            {
                EndUserLicenseAgreementRelationshipsTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementRelationshipsTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => EndUserLicenseAgreementRelationshipsTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}