
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePricesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePricesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePricesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchasePricesResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                InAppPurchasePricesResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePricesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchasePricesResponseIncludedItemDiscriminatorType.InAppPurchasePricePoints,
                "territories" => InAppPurchasePricesResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}