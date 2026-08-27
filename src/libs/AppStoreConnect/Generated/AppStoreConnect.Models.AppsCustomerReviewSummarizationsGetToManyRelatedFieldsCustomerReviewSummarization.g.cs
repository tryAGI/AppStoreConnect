
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Territory,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization value)
        {
            return value switch
            {
                AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.CreatedDate => "createdDate",
                AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Locale => "locale",
                AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Platform => "platform",
                AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Territory => "territory",
                AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization? ToEnum(string value)
        {
            return value switch
            {
                "createdDate" => AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.CreatedDate,
                "locale" => AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Locale,
                "platform" => AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Platform,
                "territory" => AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Territory,
                "text" => AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization.Text,
                _ => null,
            };
        }
    }
}