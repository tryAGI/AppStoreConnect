
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroup,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.Localizations => "localizations",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.State => "state",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.Localizations,
                "state" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}