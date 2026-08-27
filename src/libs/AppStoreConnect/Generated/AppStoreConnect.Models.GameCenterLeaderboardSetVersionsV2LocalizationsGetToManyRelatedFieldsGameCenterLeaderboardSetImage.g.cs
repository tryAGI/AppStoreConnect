
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage
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
    public static class GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.Localization => "localization",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileSize,
                "imageAsset" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "localization" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.Localization,
                "uploadOperations" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}