
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion
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
    public static class SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations => "localizations",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.State => "state",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations,
                "state" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}