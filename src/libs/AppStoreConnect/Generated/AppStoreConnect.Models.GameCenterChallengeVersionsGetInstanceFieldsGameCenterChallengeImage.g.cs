
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage
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
    public static class GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}