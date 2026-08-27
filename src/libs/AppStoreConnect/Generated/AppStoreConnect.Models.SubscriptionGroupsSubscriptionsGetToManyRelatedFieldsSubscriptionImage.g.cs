
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.State => "state",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.ImageAsset,
                "sourceFileChecksum" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.SourceFileChecksum,
                "state" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.State,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.Subscription,
                "uploadOperations" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}