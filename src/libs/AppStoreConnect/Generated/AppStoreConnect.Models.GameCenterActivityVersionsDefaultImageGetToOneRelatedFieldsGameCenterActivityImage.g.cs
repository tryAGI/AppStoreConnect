
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage
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
    public static class GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivityVersionsDefaultImageGetToOneRelatedFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}