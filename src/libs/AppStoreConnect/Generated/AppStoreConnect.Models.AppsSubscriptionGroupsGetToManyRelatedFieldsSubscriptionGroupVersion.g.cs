
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion
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
    public static class AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations => "localizations",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.State => "state",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations,
                "state" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}