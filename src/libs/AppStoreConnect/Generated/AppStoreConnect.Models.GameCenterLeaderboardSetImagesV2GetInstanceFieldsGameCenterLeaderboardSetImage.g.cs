
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage
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
    public static class GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileName => "fileName",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileSize => "fileSize",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.Localization => "localization",
                GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileName,
                "fileSize" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.FileSize,
                "imageAsset" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.ImageAsset,
                "localization" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.Localization,
                "uploadOperations" => GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage.UploadOperations,
                _ => null,
            };
        }
    }
}