
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage
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
    public static class SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.AssetDeliveryState => "assetDeliveryState",
                SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.AssetDeliveryState,
                "assetToken" => SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.ImageAsset,
                "uploadOperations" => SubscriptionVersionsImageGetToOneRelatedFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}