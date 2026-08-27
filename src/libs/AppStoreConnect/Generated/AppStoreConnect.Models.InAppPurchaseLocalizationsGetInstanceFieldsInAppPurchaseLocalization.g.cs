
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.Description,
                "inAppPurchaseV2" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.InAppPurchaseV2,
                "locale" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.Name,
                "state" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseLocalization.State,
                _ => null,
            };
        }
    }
}