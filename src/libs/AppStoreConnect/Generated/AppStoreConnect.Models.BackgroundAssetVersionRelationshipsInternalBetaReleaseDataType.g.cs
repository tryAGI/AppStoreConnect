
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionInternalBetaReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionRelationshipsInternalBetaReleaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType.BackgroundAssetVersionInternalBetaReleases => "backgroundAssetVersionInternalBetaReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersionInternalBetaReleases" => BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType.BackgroundAssetVersionInternalBetaReleases,
                _ => null,
            };
        }
    }
}