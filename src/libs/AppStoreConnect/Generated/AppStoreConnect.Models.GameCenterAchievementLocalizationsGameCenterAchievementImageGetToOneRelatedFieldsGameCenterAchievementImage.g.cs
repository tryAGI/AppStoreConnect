
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage
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
    public static class GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.FileName => "fileName",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.FileSize => "fileSize",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.GameCenterAchievementLocalization => "gameCenterAchievementLocalization",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.ImageAsset => "imageAsset",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.AssetDeliveryState,
                "fileName" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.FileName,
                "fileSize" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.FileSize,
                "gameCenterAchievementLocalization" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.GameCenterAchievementLocalization,
                "imageAsset" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.ImageAsset,
                "uploadOperations" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementImage.UploadOperations,
                _ => null,
            };
        }
    }
}