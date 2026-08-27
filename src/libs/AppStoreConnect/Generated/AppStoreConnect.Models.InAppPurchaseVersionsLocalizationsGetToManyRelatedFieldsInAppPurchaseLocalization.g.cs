
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization
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
    public static class InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization value)
        {
            return value switch
            {
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Description => "description",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Locale => "locale",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Name => "name",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Description,
                "locale" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Locale,
                "name" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Name,
                "version" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization.Version,
                _ => null,
            };
        }
    }
}