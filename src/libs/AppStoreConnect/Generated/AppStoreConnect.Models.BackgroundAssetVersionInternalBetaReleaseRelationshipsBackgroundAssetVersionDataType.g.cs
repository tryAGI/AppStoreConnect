
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}