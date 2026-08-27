
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage
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
        GameCenterAchievementLocalization,
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
    public static class GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.GameCenterAchievementLocalization => "gameCenterAchievementLocalization",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.FileSize,
                "gameCenterAchievementLocalization" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.GameCenterAchievementLocalization,
                "imageAsset" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.ImageAsset,
                "uploadOperations" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}