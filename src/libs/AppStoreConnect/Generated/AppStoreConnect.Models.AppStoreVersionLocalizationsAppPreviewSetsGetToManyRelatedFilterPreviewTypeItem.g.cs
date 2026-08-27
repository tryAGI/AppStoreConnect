
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem
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
    public static class AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleTv => "APPLE_TV",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleVisionPro => "APPLE_VISION_PRO",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Desktop => "DESKTOP",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad105 => "IPAD_105",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad97 => "IPAD_97",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro129 => "IPAD_PRO_129",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen11 => "IPAD_PRO_3GEN_11",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen129 => "IPAD_PRO_3GEN_129",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone35 => "IPHONE_35",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone40 => "IPHONE_40",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone47 => "IPHONE_47",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone55 => "IPHONE_55",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone58 => "IPHONE_58",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone61 => "IPHONE_61",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone65 => "IPHONE_65",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone67 => "IPHONE_67",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleTv,
                "APPLE_VISION_PRO" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleVisionPro,
                "DESKTOP" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Desktop,
                "IPAD_105" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad105,
                "IPAD_97" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad97,
                "IPAD_PRO_129" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro129,
                "IPAD_PRO_3GEN_11" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen11,
                "IPAD_PRO_3GEN_129" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen129,
                "IPHONE_35" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone35,
                "IPHONE_40" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone40,
                "IPHONE_47" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone47,
                "IPHONE_55" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone55,
                "IPHONE_58" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone58,
                "IPHONE_61" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone61,
                "IPHONE_65" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone65,
                "IPHONE_67" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone67,
                _ => null,
            };
        }
    }
}