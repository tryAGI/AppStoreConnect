
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization
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
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name,
                "version" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization.Version,
                _ => null,
            };
        }
    }
}