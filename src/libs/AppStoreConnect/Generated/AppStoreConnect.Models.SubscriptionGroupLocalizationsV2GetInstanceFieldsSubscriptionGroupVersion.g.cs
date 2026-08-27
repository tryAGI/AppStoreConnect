
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion
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
    public static class SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.Localizations => "localizations",
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.State => "state",
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.Localizations,
                "state" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}