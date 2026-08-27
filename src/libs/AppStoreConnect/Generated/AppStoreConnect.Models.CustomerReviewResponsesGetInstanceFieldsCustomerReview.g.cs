
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewResponsesGetInstanceFieldsCustomerReview
    {
        /// <summary>
        ///
        /// </summary>
        Body,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        Rating,
        /// <summary>
        ///
        /// </summary>
        Response,
        /// <summary>
        ///
        /// </summary>
        ReviewTerritory,
        /// <summary>
        ///
        /// </summary>
        ReviewerNickname,
        /// <summary>
        ///
        /// </summary>
        Territory,
        /// <summary>
        ///
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponsesGetInstanceFieldsCustomerReviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponsesGetInstanceFieldsCustomerReview value)
        {
            return value switch
            {
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.Body => "body",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.CreatedDate => "createdDate",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.Rating => "rating",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.Response => "response",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.ReviewTerritory => "reviewTerritory",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.ReviewerNickname => "reviewerNickname",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.Territory => "territory",
                CustomerReviewResponsesGetInstanceFieldsCustomerReview.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponsesGetInstanceFieldsCustomerReview? ToEnum(string value)
        {
            return value switch
            {
                "body" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.Body,
                "createdDate" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.CreatedDate,
                "rating" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.Rating,
                "response" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.Response,
                "reviewTerritory" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.ReviewTerritory,
                "reviewerNickname" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.ReviewerNickname,
                "territory" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.Territory,
                "title" => CustomerReviewResponsesGetInstanceFieldsCustomerReview.Title,
                _ => null,
            };
        }
    }
}