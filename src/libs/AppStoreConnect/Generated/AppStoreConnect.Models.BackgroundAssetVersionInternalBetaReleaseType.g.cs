
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionInternalBetaReleaseType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionInternalBetaReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionInternalBetaReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionInternalBetaReleaseType value)
        {
            return value switch
            {
                BackgroundAssetVersionInternalBetaReleaseType.BackgroundAssetVersionInternalBetaReleases => "backgroundAssetVersionInternalBetaReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionInternalBetaReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersionInternalBetaReleases" => BackgroundAssetVersionInternalBetaReleaseType.BackgroundAssetVersionInternalBetaReleases,
                _ => null,
            };
        }
    }
}