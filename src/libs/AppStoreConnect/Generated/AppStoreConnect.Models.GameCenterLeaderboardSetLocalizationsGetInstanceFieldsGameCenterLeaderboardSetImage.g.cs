
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage
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
    public static class GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization => "gameCenterLeaderboardSetLocalization",
                GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.FileSize,
                "gameCenterLeaderboardSetLocalization" => GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization,
                "imageAsset" => GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardSetLocalizationsGetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}