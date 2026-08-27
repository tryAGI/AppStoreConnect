
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionExternalBetaReleaseType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersionExternalBetaReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionExternalBetaReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionExternalBetaReleaseType value)
        {
            return value switch
            {
                BackgroundAssetVersionExternalBetaReleaseType.BackgroundAssetVersionExternalBetaReleases => "backgroundAssetVersionExternalBetaReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionExternalBetaReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersionExternalBetaReleases" => BackgroundAssetVersionExternalBetaReleaseType.BackgroundAssetVersionExternalBetaReleases,
                _ => null,
            };
        }
    }
}