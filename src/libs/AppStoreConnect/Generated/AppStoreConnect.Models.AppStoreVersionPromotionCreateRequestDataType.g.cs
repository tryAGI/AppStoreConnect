
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionPromotionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionPromotions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPromotionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPromotionCreateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionPromotionCreateRequestDataType.AppStoreVersionPromotions => "appStoreVersionPromotions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPromotionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPromotions" => AppStoreVersionPromotionCreateRequestDataType.AppStoreVersionPromotions,
                _ => null,
            };
        }
    }
}