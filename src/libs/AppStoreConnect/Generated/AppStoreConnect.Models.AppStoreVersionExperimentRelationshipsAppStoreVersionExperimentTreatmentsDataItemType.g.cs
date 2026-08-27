
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}