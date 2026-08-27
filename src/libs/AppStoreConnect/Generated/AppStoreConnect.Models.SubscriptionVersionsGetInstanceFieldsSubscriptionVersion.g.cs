
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionsGetInstanceFieldsSubscriptionVersion
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
    public static class SubscriptionVersionsGetInstanceFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsGetInstanceFieldsSubscriptionVersion value)
        {
            return value switch
            {
                SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Image => "image",
                SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Images => "images",
                SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Localizations => "localizations",
                SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.State => "state",
                SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Subscription => "subscription",
                SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsGetInstanceFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Image,
                "images" => SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Images,
                "localizations" => SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Localizations,
                "state" => SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.State,
                "subscription" => SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Subscription,
                "version" => SubscriptionVersionsGetInstanceFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}