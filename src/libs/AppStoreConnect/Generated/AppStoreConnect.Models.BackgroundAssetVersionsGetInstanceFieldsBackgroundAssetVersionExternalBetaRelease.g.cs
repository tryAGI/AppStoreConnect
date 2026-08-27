
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease
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
    public static class BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease.State,
                _ => null,
            };
        }
    }
}