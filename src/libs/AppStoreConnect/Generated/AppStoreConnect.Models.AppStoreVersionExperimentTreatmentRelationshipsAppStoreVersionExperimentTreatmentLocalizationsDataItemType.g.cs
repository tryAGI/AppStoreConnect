
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType.AppStoreVersionExperimentTreatmentLocalizations,
                _ => null,
            };
        }
    }
}