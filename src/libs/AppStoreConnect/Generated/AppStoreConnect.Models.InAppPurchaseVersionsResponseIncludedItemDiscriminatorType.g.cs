
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseImages,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseLocalizations,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchaseVersionsResponseIncludedItemDiscriminatorType.InAppPurchaseImages => "inAppPurchaseImages",
                InAppPurchaseVersionsResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseVersionsResponseIncludedItemDiscriminatorType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseVersionsResponseIncludedItemDiscriminatorType.InAppPurchaseImages,
                "inAppPurchaseLocalizations" => InAppPurchaseVersionsResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations,
                "inAppPurchases" => InAppPurchaseVersionsResponseIncludedItemDiscriminatorType.InAppPurchases,
                _ => null,
            };
        }
    }
}