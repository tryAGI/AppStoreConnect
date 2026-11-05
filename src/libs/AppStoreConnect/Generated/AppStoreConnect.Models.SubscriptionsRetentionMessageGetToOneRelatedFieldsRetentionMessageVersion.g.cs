
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Placement,
        /// <summary>
        ///
        /// </summary>
        RetentionMessage,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.Placement => "placement",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}