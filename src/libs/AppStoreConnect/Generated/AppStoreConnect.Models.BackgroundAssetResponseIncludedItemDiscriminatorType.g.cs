
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetResponseIncludedItemDiscriminatorType
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
    public static class BackgroundAssetResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BackgroundAssetResponseIncludedItemDiscriminatorType.Apps => "apps",
                BackgroundAssetResponseIncludedItemDiscriminatorType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BackgroundAssetResponseIncludedItemDiscriminatorType.Apps,
                "backgroundAssetVersions" => BackgroundAssetResponseIncludedItemDiscriminatorType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}