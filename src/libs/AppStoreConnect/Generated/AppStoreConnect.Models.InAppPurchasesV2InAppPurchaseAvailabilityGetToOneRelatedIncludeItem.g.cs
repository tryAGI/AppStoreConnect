
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedIncludeItem.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "availableTerritories" => InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedIncludeItem.AvailableTerritories,
                _ => null,
            };
        }
    }
}