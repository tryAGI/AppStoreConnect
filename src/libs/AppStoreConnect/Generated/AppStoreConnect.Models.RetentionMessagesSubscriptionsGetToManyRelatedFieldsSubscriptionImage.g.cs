
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.AssetToken => "assetToken",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileName => "fileName",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileSize => "fileSize",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.ImageAsset => "imageAsset",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.SourceFileChecksum => "sourceFileChecksum",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.State => "state",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.AssetToken,
                "fileName" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileName,
                "fileSize" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileSize,
                "imageAsset" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.ImageAsset,
                "sourceFileChecksum" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.SourceFileChecksum,
                "state" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.State,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.Subscription,
                "uploadOperations" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}