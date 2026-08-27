
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}