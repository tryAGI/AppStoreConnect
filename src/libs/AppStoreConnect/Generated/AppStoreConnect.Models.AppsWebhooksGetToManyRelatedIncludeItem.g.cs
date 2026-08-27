
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsWebhooksGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsWebhooksGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsWebhooksGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsWebhooksGetToManyRelatedIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsWebhooksGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsWebhooksGetToManyRelatedIncludeItem.App,
                _ => null,
            };
        }
    }
}