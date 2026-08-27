
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion
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
    public static class SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.Localizations => "localizations",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.State => "state",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.Localizations,
                "state" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}