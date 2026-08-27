
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage
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
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.AssetDeliveryState => "assetDeliveryState",
                InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.AssetDeliveryState,
                "assetToken" => InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.ImageAsset,
                "uploadOperations" => InAppPurchaseVersionsImagesGetToManyRelatedFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}