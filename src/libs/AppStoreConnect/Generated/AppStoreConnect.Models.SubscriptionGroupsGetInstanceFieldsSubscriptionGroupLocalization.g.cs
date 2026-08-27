
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization
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
    public static class SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.State => "state",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.Name,
                "state" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.State,
                "subscriptionGroup" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization.SubscriptionGroup,
                _ => null,
            };
        }
    }
}