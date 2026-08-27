
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.InAppPurchase => "inAppPurchase",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.SourceFileChecksum => "sourceFileChecksum",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.State => "state",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.ImageAsset,
                "inAppPurchase" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.InAppPurchase,
                "sourceFileChecksum" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.SourceFileChecksum,
                "state" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.State,
                "uploadOperations" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}