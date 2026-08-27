
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewResponseV1AttributesState
    {
        /// <summary>
        /// 
        /// </summary>
        PendingPublish,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponseV1AttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseV1AttributesState value)
        {
            return value switch
            {
                CustomerReviewResponseV1AttributesState.PendingPublish => "PENDING_PUBLISH",
                CustomerReviewResponseV1AttributesState.Published => "PUBLISHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseV1AttributesState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING_PUBLISH" => CustomerReviewResponseV1AttributesState.PendingPublish,
                "PUBLISHED" => CustomerReviewResponseV1AttributesState.Published,
                _ => null,
            };
        }
    }
}