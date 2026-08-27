
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}