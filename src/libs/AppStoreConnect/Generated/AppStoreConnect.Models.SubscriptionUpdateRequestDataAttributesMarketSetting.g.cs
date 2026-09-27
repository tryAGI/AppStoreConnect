
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionUpdateRequestDataAttributesMarketSetting
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
    public static class SubscriptionUpdateRequestDataAttributesMarketSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataAttributesMarketSetting value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataAttributesMarketSetting.AppleBusiness => "APPLE_BUSINESS",
                SubscriptionUpdateRequestDataAttributesMarketSetting.AppleSchool => "APPLE_SCHOOL",
                SubscriptionUpdateRequestDataAttributesMarketSetting.AppStore => "APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataAttributesMarketSetting? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_BUSINESS" => SubscriptionUpdateRequestDataAttributesMarketSetting.AppleBusiness,
                "APPLE_SCHOOL" => SubscriptionUpdateRequestDataAttributesMarketSetting.AppleSchool,
                "APP_STORE" => SubscriptionUpdateRequestDataAttributesMarketSetting.AppStore,
                _ => null,
            };
        }
    }
}