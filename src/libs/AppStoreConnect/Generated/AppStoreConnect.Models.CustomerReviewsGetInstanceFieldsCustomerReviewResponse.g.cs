
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewsGetInstanceFieldsCustomerReviewResponse
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
    public static class CustomerReviewsGetInstanceFieldsCustomerReviewResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsGetInstanceFieldsCustomerReviewResponse value)
        {
            return value switch
            {
                CustomerReviewsGetInstanceFieldsCustomerReviewResponse.LastModifiedDate => "lastModifiedDate",
                CustomerReviewsGetInstanceFieldsCustomerReviewResponse.ResponseBody => "responseBody",
                CustomerReviewsGetInstanceFieldsCustomerReviewResponse.Review => "review",
                CustomerReviewsGetInstanceFieldsCustomerReviewResponse.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsGetInstanceFieldsCustomerReviewResponse? ToEnum(string value)
        {
            return value switch
            {
                "lastModifiedDate" => CustomerReviewsGetInstanceFieldsCustomerReviewResponse.LastModifiedDate,
                "responseBody" => CustomerReviewsGetInstanceFieldsCustomerReviewResponse.ResponseBody,
                "review" => CustomerReviewsGetInstanceFieldsCustomerReviewResponse.Review,
                "state" => CustomerReviewsGetInstanceFieldsCustomerReviewResponse.State,
                _ => null,
            };
        }
    }
}