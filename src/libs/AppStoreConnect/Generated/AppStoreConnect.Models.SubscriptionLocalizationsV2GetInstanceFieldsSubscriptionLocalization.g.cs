
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization
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
    public static class SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Description => "description",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Name => "name",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Name,
                "version" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionLocalization.Version,
                _ => null,
            };
        }
    }
}