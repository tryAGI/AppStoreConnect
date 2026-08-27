
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage
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
    public static class GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage value)
        {
            return value switch
            {
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.AssetDeliveryState => "assetDeliveryState",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.FileName => "fileName",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.FileSize => "fileSize",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.ImageAsset => "imageAsset",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.AssetDeliveryState,
                "fileName" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.FileName,
                "fileSize" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.FileSize,
                "imageAsset" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.ImageAsset,
                "uploadOperations" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityImage.UploadOperations,
                _ => null,
            };
        }
    }
}