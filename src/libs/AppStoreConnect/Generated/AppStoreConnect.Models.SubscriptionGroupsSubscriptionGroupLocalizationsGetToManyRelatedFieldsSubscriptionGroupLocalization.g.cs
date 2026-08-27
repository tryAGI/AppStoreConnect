
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization
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
    public static class SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.State => "state",
                SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name,
                "state" => SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.State,
                "subscriptionGroup" => SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.SubscriptionGroup,
                _ => null,
            };
        }
    }
}