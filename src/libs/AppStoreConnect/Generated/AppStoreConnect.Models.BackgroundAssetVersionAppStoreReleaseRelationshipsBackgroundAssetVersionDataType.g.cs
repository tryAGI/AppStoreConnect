
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}