
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage
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
    public static class GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengeLocalizationsImageGetToOneRelatedFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}