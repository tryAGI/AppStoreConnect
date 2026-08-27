
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview
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
    public static class CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview value)
        {
            return value switch
            {
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Body => "body",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.CreatedDate => "createdDate",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Rating => "rating",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Response => "response",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.ReviewTerritory => "reviewTerritory",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.ReviewerNickname => "reviewerNickname",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Territory => "territory",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview? ToEnum(string value)
        {
            return value switch
            {
                "body" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Body,
                "createdDate" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.CreatedDate,
                "rating" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Rating,
                "response" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Response,
                "reviewTerritory" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.ReviewTerritory,
                "reviewerNickname" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.ReviewerNickname,
                "territory" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Territory,
                "title" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReview.Title,
                _ => null,
            };
        }
    }
}