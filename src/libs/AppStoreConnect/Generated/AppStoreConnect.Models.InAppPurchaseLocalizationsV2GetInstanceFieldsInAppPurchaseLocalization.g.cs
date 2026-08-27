
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Description,
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
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Description,
                "locale" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Name,
                "version" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization.Version,
                _ => null,
            };
        }
    }
}