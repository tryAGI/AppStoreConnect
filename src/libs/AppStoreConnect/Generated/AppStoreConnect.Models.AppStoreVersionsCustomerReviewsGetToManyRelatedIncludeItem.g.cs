
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Response,
        /// <summary>
        /// 
        /// </summary>
        ReviewTerritory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem.Response => "response",
                AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem.ReviewTerritory => "reviewTerritory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "response" => AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem.Response,
                "reviewTerritory" => AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem.ReviewTerritory,
                _ => null,
            };
        }
    }
}