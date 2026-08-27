
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCustomerReviewsGetToManyRelatedIncludeItem
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
    public static class AppsCustomerReviewsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsCustomerReviewsGetToManyRelatedIncludeItem.Response => "response",
                AppsCustomerReviewsGetToManyRelatedIncludeItem.ReviewTerritory => "reviewTerritory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "response" => AppsCustomerReviewsGetToManyRelatedIncludeItem.Response,
                "reviewTerritory" => AppsCustomerReviewsGetToManyRelatedIncludeItem.ReviewTerritory,
                _ => null,
            };
        }
    }
}