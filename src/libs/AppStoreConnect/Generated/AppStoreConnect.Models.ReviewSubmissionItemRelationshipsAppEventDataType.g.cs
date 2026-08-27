
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppEventDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppEventDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppEventDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppEventDataType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppEventDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => ReviewSubmissionItemRelationshipsAppEventDataType.AppEvents,
                _ => null,
            };
        }
    }
}