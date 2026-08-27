
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.Localization => "localization",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.FileSize,
                "imageAsset" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.ImageAsset,
                "localization" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.Localization,
                "uploadOperations" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}