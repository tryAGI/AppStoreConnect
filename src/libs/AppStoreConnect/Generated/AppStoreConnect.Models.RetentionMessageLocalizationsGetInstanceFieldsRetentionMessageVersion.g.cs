
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion
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
    public static class RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.Localizations => "localizations",
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.Placement => "placement",
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.Localizations,
                "placement" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.RetentionMessage,
                "state" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}