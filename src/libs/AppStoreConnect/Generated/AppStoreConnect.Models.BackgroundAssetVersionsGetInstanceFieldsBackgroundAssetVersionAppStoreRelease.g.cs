
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease
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
    public static class BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease.State,
                _ => null,
            };
        }
    }
}