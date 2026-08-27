
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization
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
    public static class SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.Name,
                "version" => SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization.Version,
                _ => null,
            };
        }
    }
}