
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsTerritorie value)
        {
            return value switch
            {
                InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}