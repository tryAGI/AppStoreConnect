
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}