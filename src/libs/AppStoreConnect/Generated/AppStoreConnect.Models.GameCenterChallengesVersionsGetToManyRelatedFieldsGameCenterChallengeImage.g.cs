
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage
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
    public static class GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage value)
        {
            return value switch
            {
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.FileName => "fileName",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.FileSize => "fileSize",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.ImageAsset => "imageAsset",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.AssetDeliveryState,
                "fileName" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.FileName,
                "fileSize" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.FileSize,
                "imageAsset" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.ImageAsset,
                "uploadOperations" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage.UploadOperations,
                _ => null,
            };
        }
    }
}