
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.GameCenterAchievementLocalization => "gameCenterAchievementLocalization",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.FileSize,
                "gameCenterAchievementLocalization" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.GameCenterAchievementLocalization,
                "imageAsset" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.ImageAsset,
                "uploadOperations" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}