
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage
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
    public static class GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}