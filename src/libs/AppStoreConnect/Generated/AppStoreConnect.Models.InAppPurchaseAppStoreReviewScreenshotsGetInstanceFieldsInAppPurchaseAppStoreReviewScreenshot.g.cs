
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot
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
        InAppPurchaseV2,
        /// <summary>
        /// 
        /// </summary>
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken => "assetToken",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType => "assetType",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileName => "fileName",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize => "fileSize",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken,
                "assetType" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType,
                "fileName" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileName,
                "fileSize" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize,
                "imageAsset" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset,
                "inAppPurchaseV2" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2,
                "sourceFileChecksum" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum,
                "uploadOperations" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}