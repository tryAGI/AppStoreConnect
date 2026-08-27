
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionRelationshipsLastUpdatedByActorDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionRelationshipsLastUpdatedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionRelationshipsLastUpdatedByActorDataType value)
        {
            return value switch
            {
                ReviewSubmissionRelationshipsLastUpdatedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionRelationshipsLastUpdatedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => ReviewSubmissionRelationshipsLastUpdatedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}