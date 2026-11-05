
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}