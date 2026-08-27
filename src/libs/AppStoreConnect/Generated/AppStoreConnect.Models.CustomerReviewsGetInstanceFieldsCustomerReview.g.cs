
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewsGetInstanceFieldsCustomerReview
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
    public static class CustomerReviewsGetInstanceFieldsCustomerReviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsGetInstanceFieldsCustomerReview value)
        {
            return value switch
            {
                CustomerReviewsGetInstanceFieldsCustomerReview.Body => "body",
                CustomerReviewsGetInstanceFieldsCustomerReview.CreatedDate => "createdDate",
                CustomerReviewsGetInstanceFieldsCustomerReview.Rating => "rating",
                CustomerReviewsGetInstanceFieldsCustomerReview.Response => "response",
                CustomerReviewsGetInstanceFieldsCustomerReview.ReviewTerritory => "reviewTerritory",
                CustomerReviewsGetInstanceFieldsCustomerReview.ReviewerNickname => "reviewerNickname",
                CustomerReviewsGetInstanceFieldsCustomerReview.Territory => "territory",
                CustomerReviewsGetInstanceFieldsCustomerReview.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsGetInstanceFieldsCustomerReview? ToEnum(string value)
        {
            return value switch
            {
                "body" => CustomerReviewsGetInstanceFieldsCustomerReview.Body,
                "createdDate" => CustomerReviewsGetInstanceFieldsCustomerReview.CreatedDate,
                "rating" => CustomerReviewsGetInstanceFieldsCustomerReview.Rating,
                "response" => CustomerReviewsGetInstanceFieldsCustomerReview.Response,
                "reviewTerritory" => CustomerReviewsGetInstanceFieldsCustomerReview.ReviewTerritory,
                "reviewerNickname" => CustomerReviewsGetInstanceFieldsCustomerReview.ReviewerNickname,
                "territory" => CustomerReviewsGetInstanceFieldsCustomerReview.Territory,
                "title" => CustomerReviewsGetInstanceFieldsCustomerReview.Title,
                _ => null,
            };
        }
    }
}