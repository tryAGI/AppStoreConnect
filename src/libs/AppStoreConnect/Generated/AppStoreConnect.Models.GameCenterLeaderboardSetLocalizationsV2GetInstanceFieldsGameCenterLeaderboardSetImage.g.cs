
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage
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
    public static class GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.Localization => "localization",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileSize,
                "imageAsset" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "localization" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.Localization,
                "uploadOperations" => GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}