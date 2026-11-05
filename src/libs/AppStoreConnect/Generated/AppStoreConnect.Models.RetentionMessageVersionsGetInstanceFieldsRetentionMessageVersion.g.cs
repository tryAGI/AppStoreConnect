
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion
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
    public static class RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.Localizations => "localizations",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.Placement => "placement",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.Localizations,
                "placement" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.RetentionMessage,
                "state" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}