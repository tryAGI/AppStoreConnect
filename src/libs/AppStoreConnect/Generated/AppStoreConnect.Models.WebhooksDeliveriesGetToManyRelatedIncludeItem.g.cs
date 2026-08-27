
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksDeliveriesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksDeliveriesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksDeliveriesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                WebhooksDeliveriesGetToManyRelatedIncludeItem.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksDeliveriesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhooksDeliveriesGetToManyRelatedIncludeItem.Event,
                _ => null,
            };
        }
    }
}