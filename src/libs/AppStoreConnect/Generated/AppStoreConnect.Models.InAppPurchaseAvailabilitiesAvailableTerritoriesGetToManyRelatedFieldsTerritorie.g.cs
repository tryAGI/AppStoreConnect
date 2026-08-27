
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                InAppPurchaseAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => InAppPurchaseAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}