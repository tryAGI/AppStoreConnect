
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAttributesMarketSetting
    {
        /// <summary>
        ///
        /// </summary>
        AppleBusiness,
        /// <summary>
        ///
        /// </summary>
        AppleSchool,
        /// <summary>
        ///
        /// </summary>
        AppStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAttributesMarketSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAttributesMarketSetting value)
        {
            return value switch
            {
                SubscriptionAttributesMarketSetting.AppleBusiness => "APPLE_BUSINESS",
                SubscriptionAttributesMarketSetting.AppleSchool => "APPLE_SCHOOL",
                SubscriptionAttributesMarketSetting.AppStore => "APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAttributesMarketSetting? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_BUSINESS" => SubscriptionAttributesMarketSetting.AppleBusiness,
                "APPLE_SCHOOL" => SubscriptionAttributesMarketSetting.AppleSchool,
                "APP_STORE" => SubscriptionAttributesMarketSetting.AppStore,
                _ => null,
            };
        }
    }
}