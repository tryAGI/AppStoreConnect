
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsGetInstanceIncludeItem
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                RetentionMessageVersionsGetInstanceIncludeItem.Localizations => "localizations",
                RetentionMessageVersionsGetInstanceIncludeItem.Placement => "placement",
                RetentionMessageVersionsGetInstanceIncludeItem.RetentionMessage => "retentionMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessageVersionsGetInstanceIncludeItem.Localizations,
                "placement" => RetentionMessageVersionsGetInstanceIncludeItem.Placement,
                "retentionMessage" => RetentionMessageVersionsGetInstanceIncludeItem.RetentionMessage,
                _ => null,
            };
        }
    }
}