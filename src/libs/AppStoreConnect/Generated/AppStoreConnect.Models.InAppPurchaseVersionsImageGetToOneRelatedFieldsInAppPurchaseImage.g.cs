
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage
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
    public static class InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.AssetDeliveryState => "assetDeliveryState",
                InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.AssetDeliveryState,
                "assetToken" => InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.ImageAsset,
                "uploadOperations" => InAppPurchaseVersionsImageGetToOneRelatedFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}