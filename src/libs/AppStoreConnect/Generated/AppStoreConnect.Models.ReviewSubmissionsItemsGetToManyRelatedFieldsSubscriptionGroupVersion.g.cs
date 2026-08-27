
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}