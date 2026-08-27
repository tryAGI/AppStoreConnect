
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage
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
    public static class GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}