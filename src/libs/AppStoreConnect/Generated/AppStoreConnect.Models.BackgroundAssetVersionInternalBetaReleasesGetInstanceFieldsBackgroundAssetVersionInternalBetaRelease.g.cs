
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease
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
    public static class BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease value)
        {
            return value switch
            {
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.State,
                _ => null,
            };
        }
    }
}