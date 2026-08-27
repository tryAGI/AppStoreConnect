
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Description,
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
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Description => "description",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Name => "name",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Name,
                "version" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization.Version,
                _ => null,
            };
        }
    }
}