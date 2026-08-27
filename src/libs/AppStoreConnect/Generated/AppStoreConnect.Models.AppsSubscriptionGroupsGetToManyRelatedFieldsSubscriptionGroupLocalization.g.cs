
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization
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
    public static class AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale => "locale",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name => "name",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.State => "state",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale,
                "name" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name,
                "state" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.State,
                "subscriptionGroup" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization.SubscriptionGroup,
                _ => null,
            };
        }
    }
}