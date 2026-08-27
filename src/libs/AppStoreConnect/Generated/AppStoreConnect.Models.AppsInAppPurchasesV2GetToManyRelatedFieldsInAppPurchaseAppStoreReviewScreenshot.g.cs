
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken => "assetToken",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType => "assetType",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileName => "fileName",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize => "fileSize",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetToken,
                "assetType" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.AssetType,
                "fileName" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileName,
                "fileSize" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.FileSize,
                "imageAsset" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.ImageAsset,
                "inAppPurchaseV2" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.InAppPurchaseV2,
                "sourceFileChecksum" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.SourceFileChecksum,
                "uploadOperations" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}