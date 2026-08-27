
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion
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
    public static class InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Image => "image",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Images => "images",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Localizations => "localizations",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.State => "state",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Image,
                "images" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Localizations,
                "state" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.State,
                "version" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}