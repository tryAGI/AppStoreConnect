
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage
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
    public static class GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}