
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2InAppPurchaseAvailabilityLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2InAppPurchaseAvailabilityLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2InAppPurchaseAvailabilityLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseV2InAppPurchaseAvailabilityLinkageResponseDataType.InAppPurchaseAvailabilities => "inAppPurchaseAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2InAppPurchaseAvailabilityLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAvailabilities" => InAppPurchaseV2InAppPurchaseAvailabilityLinkageResponseDataType.InAppPurchaseAvailabilities,
                _ => null,
            };
        }
    }
}