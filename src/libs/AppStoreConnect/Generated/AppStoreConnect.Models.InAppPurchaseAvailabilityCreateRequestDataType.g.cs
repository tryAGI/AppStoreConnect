
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilityCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilityCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilityCreateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseAvailabilityCreateRequestDataType.InAppPurchaseAvailabilities => "inAppPurchaseAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilityCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAvailabilities" => InAppPurchaseAvailabilityCreateRequestDataType.InAppPurchaseAvailabilities,
                _ => null,
            };
        }
    }
}