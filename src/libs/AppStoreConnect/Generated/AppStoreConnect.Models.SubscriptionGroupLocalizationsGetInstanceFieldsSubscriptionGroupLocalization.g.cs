
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        CustomAppName,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.State => "state",
                SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.Name,
                "state" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.State,
                "subscriptionGroup" => SubscriptionGroupLocalizationsGetInstanceFieldsSubscriptionGroupLocalization.SubscriptionGroup,
                _ => null,
            };
        }
    }
}