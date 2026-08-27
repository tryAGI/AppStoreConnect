
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewSummarizationType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerReviewSummarizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewSummarizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewSummarizationType value)
        {
            return value switch
            {
                CustomerReviewSummarizationType.CustomerReviewSummarizations => "customerReviewSummarizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewSummarizationType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewSummarizations" => CustomerReviewSummarizationType.CustomerReviewSummarizations,
                _ => null,
            };
        }
    }
}