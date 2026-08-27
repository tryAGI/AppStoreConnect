
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionRelationshipsAppStoreReleaseDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionAppStoreReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionRelationshipsAppStoreReleaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionRelationshipsAppStoreReleaseDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionRelationshipsAppStoreReleaseDataType.BackgroundAssetVersionAppStoreReleases => "backgroundAssetVersionAppStoreReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionRelationshipsAppStoreReleaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersionAppStoreReleases" => BackgroundAssetVersionRelationshipsAppStoreReleaseDataType.BackgroundAssetVersionAppStoreReleases,
                _ => null,
            };
        }
    }
}