
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization
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
    public static class SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization value)
        {
            return value switch
            {
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName => "customAppName",
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale => "locale",
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name => "name",
                SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization? ToEnum(string value)
        {
            return value switch
            {
                "customAppName" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.CustomAppName,
                "locale" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Locale,
                "name" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Name,
                "version" => SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization.Version,
                _ => null,
            };
        }
    }
}