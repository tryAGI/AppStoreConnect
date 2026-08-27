
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion
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
    public static class InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Image => "image",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Images => "images",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Localizations => "localizations",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.State => "state",
                InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Image,
                "images" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Localizations,
                "state" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.State,
                "version" => InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}