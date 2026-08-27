
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersion,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease value)
        {
            return value switch
            {
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.State,
                _ => null,
            };
        }
    }
}