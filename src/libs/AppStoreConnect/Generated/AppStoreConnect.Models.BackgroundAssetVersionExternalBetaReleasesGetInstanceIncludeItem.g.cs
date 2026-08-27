
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionExternalBetaReleasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionExternalBetaReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionExternalBetaReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                BackgroundAssetVersionExternalBetaReleasesGetInstanceIncludeItem.BackgroundAssetVersion => "backgroundAssetVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionExternalBetaReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionExternalBetaReleasesGetInstanceIncludeItem.BackgroundAssetVersion,
                _ => null,
            };
        }
    }
}