
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion
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
    public static class SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion value)
        {
            return value switch
            {
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Image => "image",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Images => "images",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Localizations => "localizations",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.State => "state",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Subscription => "subscription",
                SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Image,
                "images" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Images,
                "localizations" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Localizations,
                "state" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.State,
                "subscription" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Subscription,
                "version" => SubscriptionLocalizationsV2GetInstanceFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}