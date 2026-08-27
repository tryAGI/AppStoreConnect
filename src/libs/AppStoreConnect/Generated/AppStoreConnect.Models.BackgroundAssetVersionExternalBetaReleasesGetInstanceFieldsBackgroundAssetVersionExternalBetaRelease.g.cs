
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease
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
    public static class BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease value)
        {
            return value switch
            {
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.State,
                _ => null,
            };
        }
    }
}