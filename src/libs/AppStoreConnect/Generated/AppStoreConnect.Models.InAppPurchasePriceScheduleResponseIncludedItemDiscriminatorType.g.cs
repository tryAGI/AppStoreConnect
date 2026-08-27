
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePrices,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType.InAppPurchasePrices => "inAppPurchasePrices",
                InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType.InAppPurchasePrices,
                "territories" => InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}