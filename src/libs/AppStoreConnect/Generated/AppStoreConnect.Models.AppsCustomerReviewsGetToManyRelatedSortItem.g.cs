
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCustomerReviewsGetToManyRelatedSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinuscreatedDate,
        /// <summary>
        /// 
        /// </summary>
        Minusrating,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        Rating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsCustomerReviewsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsCustomerReviewsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppsCustomerReviewsGetToManyRelatedSortItem.Minusrating => "-rating",
                AppsCustomerReviewsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppsCustomerReviewsGetToManyRelatedSortItem.Rating => "rating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppsCustomerReviewsGetToManyRelatedSortItem.MinuscreatedDate,
                "-rating" => AppsCustomerReviewsGetToManyRelatedSortItem.Minusrating,
                "createdDate" => AppsCustomerReviewsGetToManyRelatedSortItem.CreatedDate,
                "rating" => AppsCustomerReviewsGetToManyRelatedSortItem.Rating,
                _ => null,
            };
        }
    }
}