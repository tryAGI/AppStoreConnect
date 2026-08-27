
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage
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
    public static class InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.InAppPurchase => "inAppPurchase",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.SourceFileChecksum => "sourceFileChecksum",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.State => "state",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.ImageAsset,
                "inAppPurchase" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.InAppPurchase,
                "sourceFileChecksum" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.SourceFileChecksum,
                "state" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.State,
                "uploadOperations" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}