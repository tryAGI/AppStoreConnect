
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage
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
    public static class GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}