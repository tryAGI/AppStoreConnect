
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}