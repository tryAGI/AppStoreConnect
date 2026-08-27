
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage
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
    public static class InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.AssetDeliveryState => "assetDeliveryState",
                InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.AssetDeliveryState,
                "assetToken" => InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.ImageAsset,
                "uploadOperations" => InAppPurchaseImagesV2GetInstanceFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}