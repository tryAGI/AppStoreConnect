
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem.BackgroundAssetVersion => "backgroundAssetVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersion" => BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem.BackgroundAssetVersion,
                _ => null,
            };
        }
    }
}