
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage
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
    public static class GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivityImagesGetInstanceFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}