
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdPlatform
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
        Universal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdPlatform value)
        {
            return value switch
            {
                BundleIdPlatform.Ios => "IOS",
                BundleIdPlatform.MacOs => "MAC_OS",
                BundleIdPlatform.Universal => "UNIVERSAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdPlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => BundleIdPlatform.Ios,
                "MAC_OS" => BundleIdPlatform.MacOs,
                "UNIVERSAL" => BundleIdPlatform.Universal,
                _ => null,
            };
        }
    }
}