
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}