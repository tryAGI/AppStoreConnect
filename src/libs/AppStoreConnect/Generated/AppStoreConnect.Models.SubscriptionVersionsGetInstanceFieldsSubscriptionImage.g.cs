
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionsGetInstanceFieldsSubscriptionImage
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
    public static class SubscriptionVersionsGetInstanceFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsGetInstanceFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionVersionsGetInstanceFieldsSubscriptionImage.AssetDeliveryState => "assetDeliveryState",
                SubscriptionVersionsGetInstanceFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionVersionsGetInstanceFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionVersionsGetInstanceFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionVersionsGetInstanceFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionVersionsGetInstanceFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsGetInstanceFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionVersionsGetInstanceFieldsSubscriptionImage.AssetDeliveryState,
                "assetToken" => SubscriptionVersionsGetInstanceFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionVersionsGetInstanceFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionVersionsGetInstanceFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionVersionsGetInstanceFieldsSubscriptionImage.ImageAsset,
                "uploadOperations" => SubscriptionVersionsGetInstanceFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}