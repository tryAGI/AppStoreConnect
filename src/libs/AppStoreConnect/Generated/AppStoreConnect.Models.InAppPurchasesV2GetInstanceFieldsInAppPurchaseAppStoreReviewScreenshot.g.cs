
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken => "assetToken",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType => "assetType",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileName => "fileName",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize => "fileSize",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken,
                "assetType" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType,
                "fileName" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileName,
                "fileSize" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize,
                "imageAsset" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset,
                "inAppPurchaseV2" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2,
                "sourceFileChecksum" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum,
                "uploadOperations" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}