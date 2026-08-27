
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}