
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImagesGetInstanceFieldsSubscriptionImage
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
    public static class SubscriptionImagesGetInstanceFieldsSubscriptionImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImagesGetInstanceFieldsSubscriptionImage value)
        {
            return value switch
            {
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.AssetToken => "assetToken",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.FileName => "fileName",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.FileSize => "fileSize",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.ImageAsset => "imageAsset",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.SourceFileChecksum => "sourceFileChecksum",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.State => "state",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.Subscription => "subscription",
                SubscriptionImagesGetInstanceFieldsSubscriptionImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImagesGetInstanceFieldsSubscriptionImage? ToEnum(string value)
        {
            return value switch
            {
                "assetToken" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.AssetToken,
                "fileName" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.FileName,
                "fileSize" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.FileSize,
                "imageAsset" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.ImageAsset,
                "sourceFileChecksum" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.SourceFileChecksum,
                "state" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.State,
                "subscription" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.Subscription,
                "uploadOperations" => SubscriptionImagesGetInstanceFieldsSubscriptionImage.UploadOperations,
                _ => null,
            };
        }
    }
}