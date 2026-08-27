
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleTv => "APPLE_TV",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleVisionPro => "APPLE_VISION_PRO",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Desktop => "DESKTOP",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad105 => "IPAD_105",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad97 => "IPAD_97",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro129 => "IPAD_PRO_129",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen11 => "IPAD_PRO_3GEN_11",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen129 => "IPAD_PRO_3GEN_129",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone35 => "IPHONE_35",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone40 => "IPHONE_40",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone47 => "IPHONE_47",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone55 => "IPHONE_55",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone58 => "IPHONE_58",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone61 => "IPHONE_61",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone65 => "IPHONE_65",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone67 => "IPHONE_67",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleTv,
                "APPLE_VISION_PRO" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.AppleVisionPro,
                "DESKTOP" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Desktop,
                "IPAD_105" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad105,
                "IPAD_97" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Ipad97,
                "IPAD_PRO_129" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro129,
                "IPAD_PRO_3GEN_11" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen11,
                "IPAD_PRO_3GEN_129" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.IpadPro3gen129,
                "IPHONE_35" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone35,
                "IPHONE_40" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone40,
                "IPHONE_47" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone47,
                "IPHONE_55" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone55,
                "IPHONE_58" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone58,
                "IPHONE_61" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone61,
                "IPHONE_65" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone65,
                "IPHONE_67" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem.Iphone67,
                _ => null,
            };
        }
    }
}