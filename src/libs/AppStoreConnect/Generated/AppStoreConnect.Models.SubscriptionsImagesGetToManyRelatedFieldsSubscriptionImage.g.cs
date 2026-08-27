
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage
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
        SourceFileChecksum,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.State => "state",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.Subscription => "subscription",
                SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.ImageAsset,
                "sourceFileChecksum" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.SourceFileChecksum,
                "state" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.State,
                "subscription" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.Subscription,
                "uploadOperations" => SubscriptionsImagesGetToManyRelatedFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}