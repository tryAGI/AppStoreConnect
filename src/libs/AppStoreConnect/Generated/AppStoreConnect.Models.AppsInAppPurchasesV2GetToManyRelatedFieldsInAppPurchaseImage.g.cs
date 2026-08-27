
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.AssetToken => "assetToken",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.FileName => "fileName",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.FileSize => "fileSize",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.InAppPurchase => "inAppPurchase",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.SourceFileChecksum => "sourceFileChecksum",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.State => "state",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.AssetToken,
                "fileName" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.FileName,
                "fileSize" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.ImageAsset,
                "inAppPurchase" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.InAppPurchase,
                "sourceFileChecksum" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.SourceFileChecksum,
                "state" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.State,
                "uploadOperations" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}