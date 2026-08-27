
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}