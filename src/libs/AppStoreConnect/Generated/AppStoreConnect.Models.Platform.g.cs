
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum Platform
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Platform value)
        {
            return value switch
            {
                Platform.Ios => "IOS",
                Platform.MacOs => "MAC_OS",
                Platform.TvOs => "TV_OS",
                Platform.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Platform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => Platform.Ios,
                "MAC_OS" => Platform.MacOs,
                "TV_OS" => Platform.TvOs,
                "VISION_OS" => Platform.VisionOs,
                _ => null,
            };
        }
    }
}