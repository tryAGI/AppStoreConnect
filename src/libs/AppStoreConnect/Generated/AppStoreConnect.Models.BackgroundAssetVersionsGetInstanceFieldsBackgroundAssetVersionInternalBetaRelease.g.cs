
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease
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
    public static class BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease.State,
                _ => null,
            };
        }
    }
}