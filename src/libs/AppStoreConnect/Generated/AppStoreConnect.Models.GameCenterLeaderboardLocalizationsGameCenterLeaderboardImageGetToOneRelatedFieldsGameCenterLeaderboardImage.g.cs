
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage
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
    public static class GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization => "gameCenterLeaderboardLocalization",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileSize,
                "gameCenterLeaderboardLocalization" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization,
                "imageAsset" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}