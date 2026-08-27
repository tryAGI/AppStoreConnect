
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAssetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAssetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAssetDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAssetDataType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAssetDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssets" => BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAssetDataType.BackgroundAssets,
                _ => null,
            };
        }
    }
}