
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage
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
    public static class GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.Localization => "localization",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileSize,
                "imageAsset" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.ImageAsset,
                "localization" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.Localization,
                "uploadOperations" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}