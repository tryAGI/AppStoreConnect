
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem
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
    public static class AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem value)
        {
            return value switch
            {
                AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.AppleTv => "APPLE_TV",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.AppleWatch => "APPLE_WATCH",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Ipad => "IPAD",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Iphone => "IPHONE",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Mac => "MAC",
                AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Vision => "VISION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_TV" => AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.AppleTv,
                "APPLE_WATCH" => AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.AppleWatch,
                "IPAD" => AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Ipad,
                "IPHONE" => AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Iphone,
                "MAC" => AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Mac,
                "VISION" => AppsAccessibilityDeclarationsGetToManyRelatedFilterDeviceFamilyItem.Vision,
                _ => null,
            };
        }
    }
}