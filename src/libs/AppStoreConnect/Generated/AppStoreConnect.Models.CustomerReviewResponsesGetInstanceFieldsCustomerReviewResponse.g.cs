
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse
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
    public static class CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse value)
        {
            return value switch
            {
                CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.LastModifiedDate => "lastModifiedDate",
                CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.ResponseBody => "responseBody",
                CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.Review => "review",
                CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse? ToEnum(string value)
        {
            return value switch
            {
                "lastModifiedDate" => CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.LastModifiedDate,
                "responseBody" => CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.ResponseBody,
                "review" => CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.Review,
                "state" => CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse.State,
                _ => null,
            };
        }
    }
}