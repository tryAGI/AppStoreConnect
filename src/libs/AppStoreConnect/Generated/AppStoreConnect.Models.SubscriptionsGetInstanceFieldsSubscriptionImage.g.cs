
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionImage
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionsGetInstanceFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionsGetInstanceFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionsGetInstanceFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionsGetInstanceFieldsSubscriptionImage.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionsGetInstanceFieldsSubscriptionImage.State => "state",
                SubscriptionsGetInstanceFieldsSubscriptionImage.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => SubscriptionsGetInstanceFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionsGetInstanceFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionsGetInstanceFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionsGetInstanceFieldsSubscriptionImage.ImageAsset,
                "sourceFileChecksum" => SubscriptionsGetInstanceFieldsSubscriptionImage.SourceFileChecksum,
                "state" => SubscriptionsGetInstanceFieldsSubscriptionImage.State,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionImage.Subscription,
                "uploadOperations" => SubscriptionsGetInstanceFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}