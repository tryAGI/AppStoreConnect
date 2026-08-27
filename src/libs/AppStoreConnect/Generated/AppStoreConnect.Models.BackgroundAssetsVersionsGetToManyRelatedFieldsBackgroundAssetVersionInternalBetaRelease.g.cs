
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease.BackgroundAssetVersion => "backgroundAssetVersion",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease.BackgroundAssetVersion,
                "state" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease.State,
                _ => null,
            };
        }
    }
}