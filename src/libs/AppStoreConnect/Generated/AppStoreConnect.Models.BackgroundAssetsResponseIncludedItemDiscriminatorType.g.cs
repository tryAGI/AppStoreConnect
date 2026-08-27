
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BackgroundAssetsResponseIncludedItemDiscriminatorType.Apps => "apps",
                BackgroundAssetsResponseIncludedItemDiscriminatorType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BackgroundAssetsResponseIncludedItemDiscriminatorType.Apps,
                "backgroundAssetVersions" => BackgroundAssetsResponseIncludedItemDiscriminatorType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}