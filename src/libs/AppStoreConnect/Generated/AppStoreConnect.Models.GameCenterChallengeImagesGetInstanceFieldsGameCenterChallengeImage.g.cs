
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage
    {
        /// <summary>
        ///
        /// </summary>
        AssetDeliveryState,
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
    public static class GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengeImagesGetInstanceFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}