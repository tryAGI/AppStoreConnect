
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementCreateRequestDataRelationshipsTerritoriesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementCreateRequestDataRelationshipsTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementCreateRequestDataRelationshipsTerritoriesDataItemType value)
        {
            return value switch
            {
                EndUserLicenseAgreementCreateRequestDataRelationshipsTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementCreateRequestDataRelationshipsTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => EndUserLicenseAgreementCreateRequestDataRelationshipsTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}