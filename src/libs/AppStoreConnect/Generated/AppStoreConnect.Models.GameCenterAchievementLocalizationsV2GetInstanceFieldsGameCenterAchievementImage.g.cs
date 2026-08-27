
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.Localization => "localization",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.FileSize,
                "imageAsset" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.ImageAsset,
                "localization" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.Localization,
                "uploadOperations" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}