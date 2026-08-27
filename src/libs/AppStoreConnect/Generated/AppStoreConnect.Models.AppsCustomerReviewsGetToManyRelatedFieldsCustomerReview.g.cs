
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview
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
    public static class AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview value)
        {
            return value switch
            {
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Body => "body",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.CreatedDate => "createdDate",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Rating => "rating",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Response => "response",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewTerritory => "reviewTerritory",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewerNickname => "reviewerNickname",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Territory => "territory",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview? ToEnum(string value)
        {
            return value switch
            {
                "body" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Body,
                "createdDate" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.CreatedDate,
                "rating" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Rating,
                "response" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Response,
                "reviewTerritory" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewTerritory,
                "reviewerNickname" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewerNickname,
                "territory" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Territory,
                "title" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Title,
                _ => null,
            };
        }
    }
}