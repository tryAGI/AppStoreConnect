
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage
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
    public static class GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.Localization => "localization",
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileSize,
                "imageAsset" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "localization" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.Localization,
                "uploadOperations" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}