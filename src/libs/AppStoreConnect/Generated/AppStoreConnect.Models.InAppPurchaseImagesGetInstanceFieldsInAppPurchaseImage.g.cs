
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage
    {
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
        InAppPurchase,
        /// <summary>
        /// 
        /// </summary>
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.InAppPurchase => "inAppPurchase",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.SourceFileChecksum => "sourceFileChecksum",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.State => "state",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.ImageAsset,
                "inAppPurchase" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.InAppPurchase,
                "sourceFileChecksum" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.SourceFileChecksum,
                "state" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.State,
                "uploadOperations" => InAppPurchaseImagesGetInstanceFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}