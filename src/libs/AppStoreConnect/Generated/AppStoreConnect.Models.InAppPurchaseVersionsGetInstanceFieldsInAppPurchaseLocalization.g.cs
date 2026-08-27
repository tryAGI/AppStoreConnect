
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization
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
    public static class InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Description,
                "locale" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Name,
                "version" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseLocalization.Version,
                _ => null,
            };
        }
    }
}