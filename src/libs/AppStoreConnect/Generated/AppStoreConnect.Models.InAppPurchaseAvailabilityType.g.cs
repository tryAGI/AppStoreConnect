
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilityType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilityType value)
        {
            return value switch
            {
                InAppPurchaseAvailabilityType.InAppPurchaseAvailabilities => "inAppPurchaseAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilityType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAvailabilities" => InAppPurchaseAvailabilityType.InAppPurchaseAvailabilities,
                _ => null,
            };
        }
    }
}