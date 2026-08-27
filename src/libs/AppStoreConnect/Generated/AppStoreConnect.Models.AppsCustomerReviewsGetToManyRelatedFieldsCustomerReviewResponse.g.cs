
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse
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
    public static class AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse value)
        {
            return value switch
            {
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.LastModifiedDate => "lastModifiedDate",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.ResponseBody => "responseBody",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.Review => "review",
                AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse? ToEnum(string value)
        {
            return value switch
            {
                "lastModifiedDate" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.LastModifiedDate,
                "responseBody" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.ResponseBody,
                "review" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.Review,
                "state" => AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse.State,
                _ => null,
            };
        }
    }
}