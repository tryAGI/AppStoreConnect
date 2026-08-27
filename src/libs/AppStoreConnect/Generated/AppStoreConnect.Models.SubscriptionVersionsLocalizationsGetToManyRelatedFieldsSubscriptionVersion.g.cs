
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Images,
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
        Subscription,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion value)
        {
            return value switch
            {
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Image => "image",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Images => "images",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Localizations => "localizations",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.State => "state",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Subscription => "subscription",
                SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Image,
                "images" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Images,
                "localizations" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Localizations,
                "state" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.State,
                "subscription" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Subscription,
                "version" => SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}