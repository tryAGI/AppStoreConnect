
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetUploadFiles,
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionAppStoreReleases,
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionExternalBetaReleases,
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersionInternalBetaReleases,
        /// <summary>
        ///
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionAppStoreReleases => "backgroundAssetVersionAppStoreReleases",
                BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionExternalBetaReleases => "backgroundAssetVersionExternalBetaReleases",
                BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionInternalBetaReleases => "backgroundAssetVersionInternalBetaReleases",
                BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetUploadFiles,
                "backgroundAssetVersionAppStoreReleases" => BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionAppStoreReleases,
                "backgroundAssetVersionExternalBetaReleases" => BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionExternalBetaReleases,
                "backgroundAssetVersionInternalBetaReleases" => BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionInternalBetaReleases,
                "backgroundAssets" => BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssets,
                _ => null,
            };
        }
    }
}