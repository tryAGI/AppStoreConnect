
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionPromotionType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionPromotions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPromotionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPromotionType value)
        {
            return value switch
            {
                AppStoreVersionPromotionType.AppStoreVersionPromotions => "appStoreVersionPromotions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPromotionType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionPromotions" => AppStoreVersionPromotionType.AppStoreVersionPromotions,
                _ => null,
            };
        }
    }
}