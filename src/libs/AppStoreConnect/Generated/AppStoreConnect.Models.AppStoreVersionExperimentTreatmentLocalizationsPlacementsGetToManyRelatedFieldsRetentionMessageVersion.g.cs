
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}