
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot
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
    public static class InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot value)
        {
            return value switch
            {
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken => "assetToken",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType => "assetType",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileName => "fileName",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize => "fileSize",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2 => "inAppPurchaseV2",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken,
                "assetType" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType,
                "fileName" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileName,
                "fileSize" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize,
                "imageAsset" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset,
                "inAppPurchaseV2" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2,
                "sourceFileChecksum" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum,
                "uploadOperations" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}