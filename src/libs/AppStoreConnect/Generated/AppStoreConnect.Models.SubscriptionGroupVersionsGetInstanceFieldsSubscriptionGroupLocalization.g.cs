
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization
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
    public static class SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.Name,
                "version" => SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization.Version,
                _ => null,
            };
        }
    }
}