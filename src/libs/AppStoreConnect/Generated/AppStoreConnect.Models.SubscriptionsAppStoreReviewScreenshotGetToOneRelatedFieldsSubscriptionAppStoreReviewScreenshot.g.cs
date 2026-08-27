
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot
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
    public static class SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot value)
        {
            return value switch
            {
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetToken => "assetToken",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetType => "assetType",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileName => "fileName",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileSize => "fileSize",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.Subscription => "subscription",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetToken,
                "assetType" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetType,
                "fileName" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileName,
                "fileSize" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileSize,
                "imageAsset" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset,
                "sourceFileChecksum" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum,
                "subscription" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.Subscription,
                "uploadOperations" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}