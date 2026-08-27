
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse
    {
        /// <summary>
        ///
        /// </summary>
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        ResponseBody,
        /// <summary>
        ///
        /// </summary>
        Review,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse value)
        {
            return value switch
            {
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.ResponseBody => "responseBody",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.Review => "review",
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse? ToEnum(string value)
        {
            return value switch
            {
                "lastModifiedDate" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.LastModifiedDate,
                "responseBody" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.ResponseBody,
                "review" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.Review,
                "state" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.State,
                _ => null,
            };
        }
    }
}