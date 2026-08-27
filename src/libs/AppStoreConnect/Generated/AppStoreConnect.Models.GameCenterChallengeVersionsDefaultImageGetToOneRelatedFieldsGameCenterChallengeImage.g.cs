
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage
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
    public static class GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengeVersionsDefaultImageGetToOneRelatedFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}