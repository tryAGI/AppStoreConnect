
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot
    {
        /// <summary>
        ///
        /// </summary>
        AssetDeliveryState,
        /// <summary>
        ///
        /// </summary>
        AssetToken,
        /// <summary>
        ///
        /// </summary>
        AssetType,
        /// <summary>
        ///
        /// </summary>
        FileName,
        /// <summary>
        ///
        /// </summary>
        FileSize,
        /// <summary>
        ///
        /// </summary>
        ImageAsset,
        /// <summary>
        ///
        /// </summary>
        SourceFileChecksum,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetToken => "assetToken",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetType => "assetType",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileName => "fileName",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileSize => "fileSize",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetToken,
                "assetType" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetType,
                "fileName" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileName,
                "fileSize" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileSize,
                "imageAsset" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset,
                "sourceFileChecksum" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.Subscription,
                "uploadOperations" => SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}