
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}