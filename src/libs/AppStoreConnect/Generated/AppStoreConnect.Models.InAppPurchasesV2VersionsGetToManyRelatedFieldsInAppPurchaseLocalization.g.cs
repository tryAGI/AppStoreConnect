
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization
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
    public static class InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Description,
                "locale" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Name,
                "version" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseLocalization.Version,
                _ => null,
            };
        }
    }
}