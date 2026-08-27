
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage
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
    public static class GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage value)
        {
            return value switch
            {
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.FileName => "fileName",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.FileSize => "fileSize",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.ImageAsset => "imageAsset",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.Localization => "localization",
                GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.AssetDeliveryState,
                "fileName" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.FileName,
                "fileSize" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.FileSize,
                "imageAsset" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.ImageAsset,
                "localization" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.Localization,
                "uploadOperations" => GameCenterLeaderboardImagesV2GetInstanceFieldsGameCenterLeaderboardImage.UploadOperations,
                _ => null,
            };
        }
    }
}