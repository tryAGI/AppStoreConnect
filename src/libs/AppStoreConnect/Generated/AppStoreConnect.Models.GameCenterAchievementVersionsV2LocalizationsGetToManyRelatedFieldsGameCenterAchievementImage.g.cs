
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.Localization => "localization",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileSize,
                "imageAsset" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.ImageAsset,
                "localization" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.Localization,
                "uploadOperations" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}