
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionsResponseIncludedItemDiscriminatorType
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
    public static class BackgroundAssetVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetVersionAppStoreReleases => "backgroundAssetVersionAppStoreReleases",
                BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetVersionExternalBetaReleases => "backgroundAssetVersionExternalBetaReleases",
                BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetVersionInternalBetaReleases => "backgroundAssetVersionInternalBetaReleases",
                BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetUploadFiles,
                "backgroundAssetVersionAppStoreReleases" => BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetVersionAppStoreReleases,
                "backgroundAssetVersionExternalBetaReleases" => BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetVersionExternalBetaReleases,
                "backgroundAssetVersionInternalBetaReleases" => BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssetVersionInternalBetaReleases,
                "backgroundAssets" => BackgroundAssetVersionsResponseIncludedItemDiscriminatorType.BackgroundAssets,
                _ => null,
            };
        }
    }
}