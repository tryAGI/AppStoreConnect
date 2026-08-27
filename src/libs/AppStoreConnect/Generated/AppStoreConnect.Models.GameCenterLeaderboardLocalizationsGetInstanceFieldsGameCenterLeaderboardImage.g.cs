
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage
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
    public static class GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization => "gameCenterLeaderboardLocalization",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.FileSize,
                "gameCenterLeaderboardLocalization" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization,
                "imageAsset" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}