
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion
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
    public static class InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Image => "image",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Images => "images",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Localizations => "localizations",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.State => "state",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Image,
                "images" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Localizations,
                "state" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.State,
                "version" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}