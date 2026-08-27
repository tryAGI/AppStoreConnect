
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionRelationshipsSubmittedByActorDataType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionRelationshipsSubmittedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionRelationshipsSubmittedByActorDataType value)
        {
            return value switch
            {
                ReviewSubmissionRelationshipsSubmittedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionRelationshipsSubmittedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => ReviewSubmissionRelationshipsSubmittedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}