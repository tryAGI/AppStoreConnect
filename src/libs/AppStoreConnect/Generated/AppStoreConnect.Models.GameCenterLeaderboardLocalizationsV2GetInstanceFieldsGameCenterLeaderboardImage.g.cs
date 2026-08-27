
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage
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
        Localization,
        /// <summary>
        /// 
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.Localization => "localization",
                GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.FileSize,
                "imageAsset" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.ImageAsset,
                "localization" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.Localization,
                "uploadOperations" => GameCenterLeaderboardLocalizationsV2GetInstanceFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}