
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem
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
    public static class AppStoreVersionsCustomerReviewsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.Minusrating => "-rating",
                AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.Rating => "rating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.MinuscreatedDate,
                "-rating" => AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.Minusrating,
                "createdDate" => AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.CreatedDate,
                "rating" => AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem.Rating,
                _ => null,
            };
        }
    }
}