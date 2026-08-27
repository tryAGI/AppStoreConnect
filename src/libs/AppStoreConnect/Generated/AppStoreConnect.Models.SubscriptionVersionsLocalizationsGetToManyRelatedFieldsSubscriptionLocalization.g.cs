
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization
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
    public static class SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Description => "description",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Name => "name",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Name,
                "version" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Version,
                _ => null,
            };
        }
    }
}