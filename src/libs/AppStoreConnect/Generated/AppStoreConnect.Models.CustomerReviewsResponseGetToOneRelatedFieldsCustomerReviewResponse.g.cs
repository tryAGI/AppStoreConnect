
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse
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
    public static class CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse value)
        {
            return value switch
            {
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.LastModifiedDate => "lastModifiedDate",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.ResponseBody => "responseBody",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.Review => "review",
                CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse? ToEnum(string value)
        {
            return value switch
            {
                "lastModifiedDate" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.LastModifiedDate,
                "responseBody" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.ResponseBody,
                "review" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.Review,
                "state" => CustomerReviewsResponseGetToOneRelatedFieldsCustomerReviewResponse.State,
                _ => null,
            };
        }
    }
}