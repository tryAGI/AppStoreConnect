
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease.State,
                _ => null,
            };
        }
    }
}