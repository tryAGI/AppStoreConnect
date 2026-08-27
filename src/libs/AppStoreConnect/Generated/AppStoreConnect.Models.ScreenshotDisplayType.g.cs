
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScreenshotDisplayType
    {
        /// <summary>
        /// 
        /// </summary>
        AppAppleTv,
        /// <summary>
        /// 
        /// </summary>
        AppAppleVisionPro,
        /// <summary>
        /// 
        /// </summary>
        AppDesktop,
        /// <summary>
        /// 
        /// </summary>
        AppIpad105,
        /// <summary>
        /// 
        /// </summary>
        AppIpad97,
        /// <summary>
        /// 
        /// </summary>
        AppIpadPro129,
        /// <summary>
        /// 
        /// </summary>
        AppIpadPro3gen11,
        /// <summary>
        /// 
        /// </summary>
        AppIpadPro3gen129,
        /// <summary>
        /// 
        /// </summary>
        AppIphone35,
        /// <summary>
        /// 
        /// </summary>
        AppIphone40,
        /// <summary>
        /// 
        /// </summary>
        AppIphone47,
        /// <summary>
        /// 
        /// </summary>
        AppIphone55,
        /// <summary>
        /// 
        /// </summary>
        AppIphone58,
        /// <summary>
        /// 
        /// </summary>
        AppIphone61,
        /// <summary>
        /// 
        /// </summary>
        AppIphone65,
        /// <summary>
        /// 
        /// </summary>
        AppIphone67,
        /// <summary>
        /// 
        /// </summary>
        AppWatchSeries10,
        /// <summary>
        /// 
        /// </summary>
        AppWatchSeries3,
        /// <summary>
        /// 
        /// </summary>
        AppWatchSeries4,
        /// <summary>
        /// 
        /// </summary>
        AppWatchSeries7,
        /// <summary>
        /// 
        /// </summary>
        AppWatchUltra,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIpad105,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIpad97,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIpadPro129,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIpadPro3gen11,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIpadPro3gen129,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone40,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone47,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone55,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone58,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone61,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone65,
        /// <summary>
        /// 
        /// </summary>
        ImessageAppIphone67,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScreenshotDisplayTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScreenshotDisplayType value)
        {
            return value switch
            {
                ScreenshotDisplayType.AppAppleTv => "APP_APPLE_TV",
                ScreenshotDisplayType.AppAppleVisionPro => "APP_APPLE_VISION_PRO",
                ScreenshotDisplayType.AppDesktop => "APP_DESKTOP",
                ScreenshotDisplayType.AppIpad105 => "APP_IPAD_105",
                ScreenshotDisplayType.AppIpad97 => "APP_IPAD_97",
                ScreenshotDisplayType.AppIpadPro129 => "APP_IPAD_PRO_129",
                ScreenshotDisplayType.AppIpadPro3gen11 => "APP_IPAD_PRO_3GEN_11",
                ScreenshotDisplayType.AppIpadPro3gen129 => "APP_IPAD_PRO_3GEN_129",
                ScreenshotDisplayType.AppIphone35 => "APP_IPHONE_35",
                ScreenshotDisplayType.AppIphone40 => "APP_IPHONE_40",
                ScreenshotDisplayType.AppIphone47 => "APP_IPHONE_47",
                ScreenshotDisplayType.AppIphone55 => "APP_IPHONE_55",
                ScreenshotDisplayType.AppIphone58 => "APP_IPHONE_58",
                ScreenshotDisplayType.AppIphone61 => "APP_IPHONE_61",
                ScreenshotDisplayType.AppIphone65 => "APP_IPHONE_65",
                ScreenshotDisplayType.AppIphone67 => "APP_IPHONE_67",
                ScreenshotDisplayType.AppWatchSeries10 => "APP_WATCH_SERIES_10",
                ScreenshotDisplayType.AppWatchSeries3 => "APP_WATCH_SERIES_3",
                ScreenshotDisplayType.AppWatchSeries4 => "APP_WATCH_SERIES_4",
                ScreenshotDisplayType.AppWatchSeries7 => "APP_WATCH_SERIES_7",
                ScreenshotDisplayType.AppWatchUltra => "APP_WATCH_ULTRA",
                ScreenshotDisplayType.ImessageAppIpad105 => "IMESSAGE_APP_IPAD_105",
                ScreenshotDisplayType.ImessageAppIpad97 => "IMESSAGE_APP_IPAD_97",
                ScreenshotDisplayType.ImessageAppIpadPro129 => "IMESSAGE_APP_IPAD_PRO_129",
                ScreenshotDisplayType.ImessageAppIpadPro3gen11 => "IMESSAGE_APP_IPAD_PRO_3GEN_11",
                ScreenshotDisplayType.ImessageAppIpadPro3gen129 => "IMESSAGE_APP_IPAD_PRO_3GEN_129",
                ScreenshotDisplayType.ImessageAppIphone40 => "IMESSAGE_APP_IPHONE_40",
                ScreenshotDisplayType.ImessageAppIphone47 => "IMESSAGE_APP_IPHONE_47",
                ScreenshotDisplayType.ImessageAppIphone55 => "IMESSAGE_APP_IPHONE_55",
                ScreenshotDisplayType.ImessageAppIphone58 => "IMESSAGE_APP_IPHONE_58",
                ScreenshotDisplayType.ImessageAppIphone61 => "IMESSAGE_APP_IPHONE_61",
                ScreenshotDisplayType.ImessageAppIphone65 => "IMESSAGE_APP_IPHONE_65",
                ScreenshotDisplayType.ImessageAppIphone67 => "IMESSAGE_APP_IPHONE_67",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScreenshotDisplayType? ToEnum(string value)
        {
            return value switch
            {
                "APP_APPLE_TV" => ScreenshotDisplayType.AppAppleTv,
                "APP_APPLE_VISION_PRO" => ScreenshotDisplayType.AppAppleVisionPro,
                "APP_DESKTOP" => ScreenshotDisplayType.AppDesktop,
                "APP_IPAD_105" => ScreenshotDisplayType.AppIpad105,
                "APP_IPAD_97" => ScreenshotDisplayType.AppIpad97,
                "APP_IPAD_PRO_129" => ScreenshotDisplayType.AppIpadPro129,
                "APP_IPAD_PRO_3GEN_11" => ScreenshotDisplayType.AppIpadPro3gen11,
                "APP_IPAD_PRO_3GEN_129" => ScreenshotDisplayType.AppIpadPro3gen129,
                "APP_IPHONE_35" => ScreenshotDisplayType.AppIphone35,
                "APP_IPHONE_40" => ScreenshotDisplayType.AppIphone40,
                "APP_IPHONE_47" => ScreenshotDisplayType.AppIphone47,
                "APP_IPHONE_55" => ScreenshotDisplayType.AppIphone55,
                "APP_IPHONE_58" => ScreenshotDisplayType.AppIphone58,
                "APP_IPHONE_61" => ScreenshotDisplayType.AppIphone61,
                "APP_IPHONE_65" => ScreenshotDisplayType.AppIphone65,
                "APP_IPHONE_67" => ScreenshotDisplayType.AppIphone67,
                "APP_WATCH_SERIES_10" => ScreenshotDisplayType.AppWatchSeries10,
                "APP_WATCH_SERIES_3" => ScreenshotDisplayType.AppWatchSeries3,
                "APP_WATCH_SERIES_4" => ScreenshotDisplayType.AppWatchSeries4,
                "APP_WATCH_SERIES_7" => ScreenshotDisplayType.AppWatchSeries7,
                "APP_WATCH_ULTRA" => ScreenshotDisplayType.AppWatchUltra,
                "IMESSAGE_APP_IPAD_105" => ScreenshotDisplayType.ImessageAppIpad105,
                "IMESSAGE_APP_IPAD_97" => ScreenshotDisplayType.ImessageAppIpad97,
                "IMESSAGE_APP_IPAD_PRO_129" => ScreenshotDisplayType.ImessageAppIpadPro129,
                "IMESSAGE_APP_IPAD_PRO_3GEN_11" => ScreenshotDisplayType.ImessageAppIpadPro3gen11,
                "IMESSAGE_APP_IPAD_PRO_3GEN_129" => ScreenshotDisplayType.ImessageAppIpadPro3gen129,
                "IMESSAGE_APP_IPHONE_40" => ScreenshotDisplayType.ImessageAppIphone40,
                "IMESSAGE_APP_IPHONE_47" => ScreenshotDisplayType.ImessageAppIphone47,
                "IMESSAGE_APP_IPHONE_55" => ScreenshotDisplayType.ImessageAppIphone55,
                "IMESSAGE_APP_IPHONE_58" => ScreenshotDisplayType.ImessageAppIphone58,
                "IMESSAGE_APP_IPHONE_61" => ScreenshotDisplayType.ImessageAppIphone61,
                "IMESSAGE_APP_IPHONE_65" => ScreenshotDisplayType.ImessageAppIphone65,
                "IMESSAGE_APP_IPHONE_67" => ScreenshotDisplayType.ImessageAppIphone67,
                _ => null,
            };
        }
    }
}