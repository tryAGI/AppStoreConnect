
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionRelationshipsBackgroundAssetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionRelationshipsBackgroundAssetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionRelationshipsBackgroundAssetDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionRelationshipsBackgroundAssetDataType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionRelationshipsBackgroundAssetDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssets" => BackgroundAssetVersionRelationshipsBackgroundAssetDataType.BackgroundAssets,
                _ => null,
            };
        }
    }
}