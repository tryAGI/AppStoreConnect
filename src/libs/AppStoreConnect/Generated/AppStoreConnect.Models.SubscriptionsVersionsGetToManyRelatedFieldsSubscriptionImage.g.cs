
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage
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
    public static class SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.AssetDeliveryState => "assetDeliveryState",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.AssetDeliveryState,
                "assetToken" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.ImageAsset,
                "uploadOperations" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}