
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.Description,
                "inAppPurchaseV2" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.InAppPurchaseV2,
                "locale" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.Name,
                "state" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization.State,
                _ => null,
            };
        }
    }
}