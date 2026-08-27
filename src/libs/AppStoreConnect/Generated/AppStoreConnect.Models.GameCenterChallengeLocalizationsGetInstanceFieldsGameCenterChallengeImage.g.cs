
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage
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
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}