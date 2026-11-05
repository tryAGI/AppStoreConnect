
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                RetentionMessageLocalizationsGetInstanceIncludeItem.RetentionMessageVersion => "retentionMessageVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersion" => RetentionMessageLocalizationsGetInstanceIncludeItem.RetentionMessageVersion,
                _ => null,
            };
        }
    }
}