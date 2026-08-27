
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionForReview,
        /// <summary>
        /// 
        /// </summary>
        Items,
        /// <summary>
        /// 
        /// </summary>
        LastUpdatedByActor,
        /// <summary>
        /// 
        /// </summary>
        SubmittedByActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsReviewSubmissionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedIncludeItem.App => "app",
                AppsReviewSubmissionsGetToManyRelatedIncludeItem.AppStoreVersionForReview => "appStoreVersionForReview",
                AppsReviewSubmissionsGetToManyRelatedIncludeItem.Items => "items",
                AppsReviewSubmissionsGetToManyRelatedIncludeItem.LastUpdatedByActor => "lastUpdatedByActor",
                AppsReviewSubmissionsGetToManyRelatedIncludeItem.SubmittedByActor => "submittedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsReviewSubmissionsGetToManyRelatedIncludeItem.App,
                "appStoreVersionForReview" => AppsReviewSubmissionsGetToManyRelatedIncludeItem.AppStoreVersionForReview,
                "items" => AppsReviewSubmissionsGetToManyRelatedIncludeItem.Items,
                "lastUpdatedByActor" => AppsReviewSubmissionsGetToManyRelatedIncludeItem.LastUpdatedByActor,
                "submittedByActor" => AppsReviewSubmissionsGetToManyRelatedIncludeItem.SubmittedByActor,
                _ => null,
            };
        }
    }
}