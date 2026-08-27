
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementsTerritoriesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementsTerritoriesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementsTerritoriesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                EndUserLicenseAgreementsTerritoriesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementsTerritoriesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => EndUserLicenseAgreementsTerritoriesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}