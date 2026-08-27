
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage
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
    public static class GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization => "gameCenterLeaderboardSetLocalization",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.FileSize,
                "gameCenterLeaderboardSetLocalization" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.GameCenterLeaderboardSetLocalization,
                "imageAsset" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "uploadOperations" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}