
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage
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
    public static class InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.AssetDeliveryState => "assetDeliveryState",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.AssetDeliveryState,
                "assetToken" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.ImageAsset,
                "uploadOperations" => InAppPurchaseVersionsGetInstanceFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}