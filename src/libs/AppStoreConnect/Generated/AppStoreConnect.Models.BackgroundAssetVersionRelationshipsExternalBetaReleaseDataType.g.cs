
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionExternalBetaReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionRelationshipsExternalBetaReleaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType.BackgroundAssetVersionExternalBetaReleases => "backgroundAssetVersionExternalBetaReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersionExternalBetaReleases" => BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType.BackgroundAssetVersionExternalBetaReleases,
                _ => null,
            };
        }
    }
}