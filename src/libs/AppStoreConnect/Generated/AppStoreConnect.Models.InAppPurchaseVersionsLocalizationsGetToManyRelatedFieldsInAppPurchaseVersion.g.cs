
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion
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
    public static class InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Image => "image",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Images => "images",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Localizations => "localizations",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.State => "state",
                InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Image,
                "images" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Localizations,
                "state" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.State,
                "version" => InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}