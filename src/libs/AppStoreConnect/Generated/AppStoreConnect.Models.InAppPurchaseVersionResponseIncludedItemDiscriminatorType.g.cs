
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionResponseIncludedItemDiscriminatorType
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
    public static class InAppPurchaseVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                InAppPurchaseVersionResponseIncludedItemDiscriminatorType.InAppPurchaseImages => "inAppPurchaseImages",
                InAppPurchaseVersionResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseVersionResponseIncludedItemDiscriminatorType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseVersionResponseIncludedItemDiscriminatorType.InAppPurchaseImages,
                "inAppPurchaseLocalizations" => InAppPurchaseVersionResponseIncludedItemDiscriminatorType.InAppPurchaseLocalizations,
                "inAppPurchases" => InAppPurchaseVersionResponseIncludedItemDiscriminatorType.InAppPurchases,
                _ => null,
            };
        }
    }
}