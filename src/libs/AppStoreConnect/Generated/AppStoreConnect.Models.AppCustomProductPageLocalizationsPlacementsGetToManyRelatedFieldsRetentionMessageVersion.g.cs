
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}