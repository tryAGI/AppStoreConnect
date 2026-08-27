
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterAttributesAppDevicePlatform
    {
        /// <summary>
        ///
        /// </summary>
        Ios,
        /// <summary>
        ///
        /// </summary>
        MacOs,
        /// <summary>
        ///
        /// </summary>
        TvOs,
        /// <summary>
        ///
        /// </summary>
        VisionOs,
        /// <summary>
        ///
        /// </summary>
        WatchOs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterAttributesAppDevicePlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterAttributesAppDevicePlatform value)
        {
            return value switch
            {
                BetaTesterAttributesAppDevicePlatform.Ios => "IOS",
                BetaTesterAttributesAppDevicePlatform.MacOs => "MAC_OS",
                BetaTesterAttributesAppDevicePlatform.TvOs => "TV_OS",
                BetaTesterAttributesAppDevicePlatform.VisionOs => "VISION_OS",
                BetaTesterAttributesAppDevicePlatform.WatchOs => "WATCH_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterAttributesAppDevicePlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => BetaTesterAttributesAppDevicePlatform.Ios,
                "MAC_OS" => BetaTesterAttributesAppDevicePlatform.MacOs,
                "TV_OS" => BetaTesterAttributesAppDevicePlatform.TvOs,
                "VISION_OS" => BetaTesterAttributesAppDevicePlatform.VisionOs,
                "WATCH_OS" => BetaTesterAttributesAppDevicePlatform.WatchOs,
                _ => null,
            };
        }
    }
}