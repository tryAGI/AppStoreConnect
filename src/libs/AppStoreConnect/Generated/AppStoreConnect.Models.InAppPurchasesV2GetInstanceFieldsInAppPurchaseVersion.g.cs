
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Image => "image",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Images => "images",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Localizations => "localizations",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.State => "state",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Image,
                "images" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Localizations,
                "state" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.State,
                "version" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}