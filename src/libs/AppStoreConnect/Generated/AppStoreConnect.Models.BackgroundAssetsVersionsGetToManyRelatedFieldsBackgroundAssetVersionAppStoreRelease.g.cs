
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease.State,
                _ => null,
            };
        }
    }
}