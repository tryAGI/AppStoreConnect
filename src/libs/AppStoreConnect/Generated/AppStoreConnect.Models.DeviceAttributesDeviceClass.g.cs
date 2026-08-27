
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceAttributesDeviceClass
    {
        /// <summary>
        /// 
        /// </summary>
        AppleTv,
        /// <summary>
        /// 
        /// </summary>
        AppleVisionPro,
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
        Ipod,
        /// <summary>
        /// 
        /// </summary>
        Mac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceAttributesDeviceClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceAttributesDeviceClass value)
        {
            return value switch
            {
                DeviceAttributesDeviceClass.AppleTv => "APPLE_TV",
                DeviceAttributesDeviceClass.AppleVisionPro => "APPLE_VISION_PRO",
                DeviceAttributesDeviceClass.AppleWatch => "APPLE_WATCH",
                DeviceAttributesDeviceClass.Ipad => "IPAD",
                DeviceAttributesDeviceClass.Iphone => "IPHONE",
                DeviceAttributesDeviceClass.Ipod => "IPOD",
                DeviceAttributesDeviceClass.Mac => "MAC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceAttributesDeviceClass? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => DeviceAttributesDeviceClass.AppleTv,
                "APPLE_VISION_PRO" => DeviceAttributesDeviceClass.AppleVisionPro,
                "APPLE_WATCH" => DeviceAttributesDeviceClass.AppleWatch,
                "IPAD" => DeviceAttributesDeviceClass.Ipad,
                "IPHONE" => DeviceAttributesDeviceClass.Iphone,
                "IPOD" => DeviceAttributesDeviceClass.Ipod,
                "MAC" => DeviceAttributesDeviceClass.Mac,
                _ => null,
            };
        }
    }
}