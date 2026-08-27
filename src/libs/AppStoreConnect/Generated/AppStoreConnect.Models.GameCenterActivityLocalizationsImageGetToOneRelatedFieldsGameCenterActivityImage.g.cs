
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage
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
    public static class GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivityLocalizationsImageGetToOneRelatedFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}