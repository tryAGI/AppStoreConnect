
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionAppStoreReleaseType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersionAppStoreReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionAppStoreReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionAppStoreReleaseType value)
        {
            return value switch
            {
                BackgroundAssetVersionAppStoreReleaseType.BackgroundAssetVersionAppStoreReleases => "backgroundAssetVersionAppStoreReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionAppStoreReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersionAppStoreReleases" => BackgroundAssetVersionAppStoreReleaseType.BackgroundAssetVersionAppStoreReleases,
                _ => null,
            };
        }
    }
}