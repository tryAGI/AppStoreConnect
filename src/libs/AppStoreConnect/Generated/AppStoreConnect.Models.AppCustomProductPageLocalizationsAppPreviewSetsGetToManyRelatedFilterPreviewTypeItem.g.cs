
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem
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
    public static class AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleTv => "APPLE_TV",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleVisionPro => "APPLE_VISION_PRO",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Desktop => "DESKTOP",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad105 => "IPAD_105",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad97 => "IPAD_97",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro129 => "IPAD_PRO_129",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen11 => "IPAD_PRO_3GEN_11",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen129 => "IPAD_PRO_3GEN_129",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone35 => "IPHONE_35",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone40 => "IPHONE_40",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone47 => "IPHONE_47",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone55 => "IPHONE_55",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone58 => "IPHONE_58",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone61 => "IPHONE_61",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone65 => "IPHONE_65",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone67 => "IPHONE_67",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleTv,
                "APPLE_VISION_PRO" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleVisionPro,
                "DESKTOP" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Desktop,
                "IPAD_105" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad105,
                "IPAD_97" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad97,
                "IPAD_PRO_129" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro129,
                "IPAD_PRO_3GEN_11" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen11,
                "IPAD_PRO_3GEN_129" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen129,
                "IPHONE_35" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone35,
                "IPHONE_40" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone40,
                "IPHONE_47" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone47,
                "IPHONE_55" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone55,
                "IPHONE_58" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone58,
                "IPHONE_61" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone61,
                "IPHONE_65" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone65,
                "IPHONE_67" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone67,
                _ => null,
            };
        }
    }
}