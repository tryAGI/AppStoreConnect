
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.Description => "description",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.Locale => "locale",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.Name => "name",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.Description,
                "inAppPurchaseV2" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.InAppPurchaseV2,
                "locale" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.Locale,
                "name" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.Name,
                "state" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization.State,
                _ => null,
            };
        }
    }
}