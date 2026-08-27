
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage
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
        GameCenterLeaderboardLocalization,
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
    public static class GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization => "gameCenterLeaderboardLocalization",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.FileSize,
                "gameCenterLeaderboardLocalization" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.GameCenterLeaderboardLocalization,
                "imageAsset" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}