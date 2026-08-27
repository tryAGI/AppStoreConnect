
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentDataType value)
        {
            return value switch
            {
                AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentDataType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionPromotionCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentDataType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}