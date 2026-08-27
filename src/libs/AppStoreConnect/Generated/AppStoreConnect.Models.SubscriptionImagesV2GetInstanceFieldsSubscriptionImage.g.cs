
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImagesV2GetInstanceFieldsSubscriptionImage
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
    public static class SubscriptionImagesV2GetInstanceFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImagesV2GetInstanceFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.AssetDeliveryState => "assetDeliveryState",
                SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImagesV2GetInstanceFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.AssetDeliveryState,
                "assetToken" => SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.ImageAsset,
                "uploadOperations" => SubscriptionImagesV2GetInstanceFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}