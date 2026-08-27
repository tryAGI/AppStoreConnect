
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization
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
    public static class InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Description,
                "inAppPurchaseV2" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.InAppPurchaseV2,
                "locale" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Name,
                "state" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.State,
                _ => null,
            };
        }
    }
}