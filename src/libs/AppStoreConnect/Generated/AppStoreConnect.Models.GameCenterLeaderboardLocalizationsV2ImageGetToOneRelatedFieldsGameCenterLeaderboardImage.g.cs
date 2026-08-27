
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage
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
    public static class GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.Localization => "localization",
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.FileSize,
                "imageAsset" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.ImageAsset,
                "localization" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.Localization,
                "uploadOperations" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}