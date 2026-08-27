
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage
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
    public static class SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.AssetDeliveryState => "assetDeliveryState",
                SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.AssetDeliveryState,
                "assetToken" => SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.ImageAsset,
                "uploadOperations" => SubscriptionVersionsImagesGetToManyRelatedFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}