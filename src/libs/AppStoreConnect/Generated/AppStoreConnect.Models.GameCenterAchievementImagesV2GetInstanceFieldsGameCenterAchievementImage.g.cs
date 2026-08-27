
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.Localization => "localization",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.FileSize,
                "imageAsset" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.ImageAsset,
                "localization" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.Localization,
                "uploadOperations" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}