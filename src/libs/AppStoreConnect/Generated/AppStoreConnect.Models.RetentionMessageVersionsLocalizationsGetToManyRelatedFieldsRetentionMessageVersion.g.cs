
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}