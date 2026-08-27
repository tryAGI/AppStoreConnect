
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot
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
    public static class SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetToken => "assetToken",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetType => "assetType",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileName => "fileName",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileSize => "fileSize",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.Subscription => "subscription",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetToken,
                "assetType" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.AssetType,
                "fileName" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileName,
                "fileSize" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.FileSize,
                "imageAsset" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset,
                "sourceFileChecksum" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum,
                "subscription" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.Subscription,
                "uploadOperations" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}