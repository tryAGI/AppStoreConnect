
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.GameCenterAchievementLocalization => "gameCenterAchievementLocalization",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.FileSize,
                "gameCenterAchievementLocalization" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.GameCenterAchievementLocalization,
                "imageAsset" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.ImageAsset,
                "uploadOperations" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}