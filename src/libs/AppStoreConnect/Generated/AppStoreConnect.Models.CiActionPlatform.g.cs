
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiActionPlatform
    {
        /// <summary>
        /// 
        /// </summary>
        Ios,
        /// <summary>
        /// 
        /// </summary>
        Macos,
        /// <summary>
        /// 
        /// </summary>
        Tvos,
        /// <summary>
        /// 
        /// </summary>
        Visionos,
        /// <summary>
        /// 
        /// </summary>
        Watchos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiActionPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiActionPlatform value)
        {
            return value switch
            {
                CiActionPlatform.Ios => "IOS",
                CiActionPlatform.Macos => "MACOS",
                CiActionPlatform.Tvos => "TVOS",
                CiActionPlatform.Visionos => "VISIONOS",
                CiActionPlatform.Watchos => "WATCHOS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiActionPlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => CiActionPlatform.Ios,
                "MACOS" => CiActionPlatform.Macos,
                "TVOS" => CiActionPlatform.Tvos,
                "VISIONOS" => CiActionPlatform.Visionos,
                "WATCHOS" => CiActionPlatform.Watchos,
                _ => null,
            };
        }
    }
}