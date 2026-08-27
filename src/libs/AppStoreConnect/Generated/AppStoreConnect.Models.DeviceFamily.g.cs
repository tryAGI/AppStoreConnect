
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DeviceFamily
    {
        /// <summary>
        ///
        /// </summary>
        AppleTv,
        /// <summary>
        ///
        /// </summary>
        AppleWatch,
        /// <summary>
        ///
        /// </summary>
        Ipad,
        /// <summary>
        ///
        /// </summary>
        Iphone,
        /// <summary>
        ///
        /// </summary>
        Mac,
        /// <summary>
        ///
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceFamilyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceFamily value)
        {
            return value switch
            {
                DeviceFamily.AppleTv => "APPLE_TV",
                DeviceFamily.AppleWatch => "APPLE_WATCH",
                DeviceFamily.Ipad => "IPAD",
                DeviceFamily.Iphone => "IPHONE",
                DeviceFamily.Mac => "MAC",
                DeviceFamily.Vision => "VISION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceFamily? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => DeviceFamily.AppleTv,
                "APPLE_WATCH" => DeviceFamily.AppleWatch,
                "IPAD" => DeviceFamily.Ipad,
                "IPHONE" => DeviceFamily.Iphone,
                "MAC" => DeviceFamily.Mac,
                "VISION" => DeviceFamily.Vision,
                _ => null,
            };
        }
    }
}