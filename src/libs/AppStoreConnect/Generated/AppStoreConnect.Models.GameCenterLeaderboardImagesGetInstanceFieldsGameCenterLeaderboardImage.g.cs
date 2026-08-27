
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage
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
        GameCenterLeaderboardLocalization,
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
    public static class GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization => "gameCenterLeaderboardLocalization",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.FileSize,
                "gameCenterLeaderboardLocalization" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization,
                "imageAsset" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardImagesGetInstanceFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}