
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksGetInstanceFieldsWebhook
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
    public static class WebhooksGetInstanceFieldsWebhookExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksGetInstanceFieldsWebhook value)
        {
            return value switch
            {
                WebhooksGetInstanceFieldsWebhook.App => "app",
                WebhooksGetInstanceFieldsWebhook.Deliveries => "deliveries",
                WebhooksGetInstanceFieldsWebhook.Enabled => "enabled",
                WebhooksGetInstanceFieldsWebhook.EventTypes => "eventTypes",
                WebhooksGetInstanceFieldsWebhook.Name => "name",
                WebhooksGetInstanceFieldsWebhook.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksGetInstanceFieldsWebhook? ToEnum(string value)
        {
            return value switch
            {
                "app" => WebhooksGetInstanceFieldsWebhook.App,
                "deliveries" => WebhooksGetInstanceFieldsWebhook.Deliveries,
                "enabled" => WebhooksGetInstanceFieldsWebhook.Enabled,
                "eventTypes" => WebhooksGetInstanceFieldsWebhook.EventTypes,
                "name" => WebhooksGetInstanceFieldsWebhook.Name,
                "url" => WebhooksGetInstanceFieldsWebhook.Url,
                _ => null,
            };
        }
    }
}