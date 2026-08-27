
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem.BackgroundAssetVersion => "backgroundAssetVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionAppStoreReleasesGetInstanceIncludeItem.BackgroundAssetVersion,
                _ => null,
            };
        }
    }
}