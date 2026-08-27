
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage
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
        GameCenterLeaderboardSetLocalization,
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
    public static class GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization => "gameCenterLeaderboardSetLocalization",
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.FileSize,
                "gameCenterLeaderboardSetLocalization" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization,
                "imageAsset" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}