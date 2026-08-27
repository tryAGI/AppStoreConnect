
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage
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
        GameCenterLeaderboardSetLocalization,
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
    public static class GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization => "gameCenterLeaderboardSetLocalization",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.FileSize,
                "gameCenterLeaderboardSetLocalization" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization,
                "imageAsset" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}