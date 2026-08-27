
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion
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
    public static class SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion value)
        {
            return value switch
            {
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations => "localizations",
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.State => "state",
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup => "subscriptionGroup",
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.Localizations,
                "state" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.State,
                "subscriptionGroup" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.SubscriptionGroup,
                "version" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion.Version,
                _ => null,
            };
        }
    }
}