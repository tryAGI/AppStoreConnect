
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementsGetInstanceFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementsGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementsGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                EndUserLicenseAgreementsGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementsGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => EndUserLicenseAgreementsGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}