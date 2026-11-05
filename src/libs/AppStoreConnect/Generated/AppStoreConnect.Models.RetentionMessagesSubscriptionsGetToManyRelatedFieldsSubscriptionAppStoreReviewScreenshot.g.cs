
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot
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
        AssetType,
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
        Subscription,
        /// <summary>
        ///
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshotExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState => "assetDeliveryState",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetToken => "assetToken",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetType => "assetType",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileName => "fileName",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileSize => "fileSize",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset => "imageAsset",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum => "sourceFileChecksum",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetDeliveryState,
                "assetToken" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetToken,
                "assetType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.AssetType,
                "fileName" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileName,
                "fileSize" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.FileSize,
                "imageAsset" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.ImageAsset,
                "sourceFileChecksum" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.SourceFileChecksum,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.Subscription,
                "uploadOperations" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot.UploadOperations,
                _ => null,
            };
        }
    }
}