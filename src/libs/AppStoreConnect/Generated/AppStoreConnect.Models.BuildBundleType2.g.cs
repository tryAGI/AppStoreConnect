
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundleType2
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AppClip,
        /// <summary>
        /// 
        /// </summary>
        WatchApp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleType2 value)
        {
            return value switch
            {
                BuildBundleType2.App => "APP",
                BuildBundleType2.AppClip => "APP_CLIP",
                BuildBundleType2.WatchApp => "WATCH_APP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleType2? ToEnum(string value)
        {
            return value switch
            {
                "APP" => BuildBundleType2.App,
                "APP_CLIP" => BuildBundleType2.AppClip,
                "WATCH_APP" => BuildBundleType2.WatchApp,
                _ => null,
            };
        }
    }
}