
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Image => "image",
                ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Images => "images",
                ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase => "inAppPurchase",
                ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Image,
                "images" => ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Images,
                "inAppPurchase" => ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.InAppPurchase,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Localizations,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion.Version,
                _ => null,
            };
        }
    }
}