
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsWebhooksGetToManyRelatedFieldsWebhook
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Deliveries,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        EventTypes,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsWebhooksGetToManyRelatedFieldsWebhookExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsWebhooksGetToManyRelatedFieldsWebhook value)
        {
            return value switch
            {
                AppsWebhooksGetToManyRelatedFieldsWebhook.App => "app",
                AppsWebhooksGetToManyRelatedFieldsWebhook.Deliveries => "deliveries",
                AppsWebhooksGetToManyRelatedFieldsWebhook.Enabled => "enabled",
                AppsWebhooksGetToManyRelatedFieldsWebhook.EventTypes => "eventTypes",
                AppsWebhooksGetToManyRelatedFieldsWebhook.Name => "name",
                AppsWebhooksGetToManyRelatedFieldsWebhook.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsWebhooksGetToManyRelatedFieldsWebhook? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsWebhooksGetToManyRelatedFieldsWebhook.App,
                "deliveries" => AppsWebhooksGetToManyRelatedFieldsWebhook.Deliveries,
                "enabled" => AppsWebhooksGetToManyRelatedFieldsWebhook.Enabled,
                "eventTypes" => AppsWebhooksGetToManyRelatedFieldsWebhook.EventTypes,
                "name" => AppsWebhooksGetToManyRelatedFieldsWebhook.Name,
                "url" => AppsWebhooksGetToManyRelatedFieldsWebhook.Url,
                _ => null,
            };
        }
    }
}