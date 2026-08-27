
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreviewType
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
        Desktop,
        /// <summary>
        /// 
        /// </summary>
        Ipad105,
        /// <summary>
        /// 
        /// </summary>
        Ipad97,
        /// <summary>
        /// 
        /// </summary>
        IpadPro129,
        /// <summary>
        /// 
        /// </summary>
        IpadPro3gen11,
        /// <summary>
        /// 
        /// </summary>
        IpadPro3gen129,
        /// <summary>
        /// 
        /// </summary>
        Iphone35,
        /// <summary>
        /// 
        /// </summary>
        Iphone40,
        /// <summary>
        /// 
        /// </summary>
        Iphone47,
        /// <summary>
        /// 
        /// </summary>
        Iphone55,
        /// <summary>
        /// 
        /// </summary>
        Iphone58,
        /// <summary>
        /// 
        /// </summary>
        Iphone61,
        /// <summary>
        /// 
        /// </summary>
        Iphone65,
        /// <summary>
        /// 
        /// </summary>
        Iphone67,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreviewType value)
        {
            return value switch
            {
                PreviewType.AppleTv => "APPLE_TV",
                PreviewType.AppleVisionPro => "APPLE_VISION_PRO",
                PreviewType.Desktop => "DESKTOP",
                PreviewType.Ipad105 => "IPAD_105",
                PreviewType.Ipad97 => "IPAD_97",
                PreviewType.IpadPro129 => "IPAD_PRO_129",
                PreviewType.IpadPro3gen11 => "IPAD_PRO_3GEN_11",
                PreviewType.IpadPro3gen129 => "IPAD_PRO_3GEN_129",
                PreviewType.Iphone35 => "IPHONE_35",
                PreviewType.Iphone40 => "IPHONE_40",
                PreviewType.Iphone47 => "IPHONE_47",
                PreviewType.Iphone55 => "IPHONE_55",
                PreviewType.Iphone58 => "IPHONE_58",
                PreviewType.Iphone61 => "IPHONE_61",
                PreviewType.Iphone65 => "IPHONE_65",
                PreviewType.Iphone67 => "IPHONE_67",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreviewType? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => PreviewType.AppleTv,
                "APPLE_VISION_PRO" => PreviewType.AppleVisionPro,
                "DESKTOP" => PreviewType.Desktop,
                "IPAD_105" => PreviewType.Ipad105,
                "IPAD_97" => PreviewType.Ipad97,
                "IPAD_PRO_129" => PreviewType.IpadPro129,
                "IPAD_PRO_3GEN_11" => PreviewType.IpadPro3gen11,
                "IPAD_PRO_3GEN_129" => PreviewType.IpadPro3gen129,
                "IPHONE_35" => PreviewType.Iphone35,
                "IPHONE_40" => PreviewType.Iphone40,
                "IPHONE_47" => PreviewType.Iphone47,
                "IPHONE_55" => PreviewType.Iphone55,
                "IPHONE_58" => PreviewType.Iphone58,
                "IPHONE_61" => PreviewType.Iphone61,
                "IPHONE_65" => PreviewType.Iphone65,
                "IPHONE_67" => PreviewType.Iphone67,
                _ => null,
            };
        }
    }
}