
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview
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
    public static class AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview value)
        {
            return value switch
            {
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Body => "body",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.CreatedDate => "createdDate",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Rating => "rating",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Response => "response",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewTerritory => "reviewTerritory",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewerNickname => "reviewerNickname",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Territory => "territory",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview? ToEnum(string value)
        {
            return value switch
            {
                "body" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Body,
                "createdDate" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.CreatedDate,
                "rating" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Rating,
                "response" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Response,
                "reviewTerritory" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewTerritory,
                "reviewerNickname" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.ReviewerNickname,
                "territory" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Territory,
                "title" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview.Title,
                _ => null,
            };
        }
    }
}