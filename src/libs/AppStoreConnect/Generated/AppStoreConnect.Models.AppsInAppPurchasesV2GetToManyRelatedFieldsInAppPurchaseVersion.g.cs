
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchase,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Image => "image",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Images => "images",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Localizations => "localizations",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.State => "state",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Image,
                "images" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Localizations,
                "state" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.State,
                "version" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}