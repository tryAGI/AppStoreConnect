
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}