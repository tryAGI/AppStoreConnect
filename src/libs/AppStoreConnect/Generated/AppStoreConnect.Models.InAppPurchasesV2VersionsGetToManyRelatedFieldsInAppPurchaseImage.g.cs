
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage
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
    public static class InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage value)
        {
            return value switch
            {
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.AssetDeliveryState => "assetDeliveryState",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.AssetToken => "assetToken",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.FileName => "fileName",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.FileSize => "fileSize",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.ImageAsset => "imageAsset",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.AssetDeliveryState,
                "assetToken" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.AssetToken,
                "fileName" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.FileName,
                "fileSize" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.FileSize,
                "imageAsset" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.ImageAsset,
                "uploadOperations" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseImage.UploadOperations,
                _ => null,
            };
        }
    }
}