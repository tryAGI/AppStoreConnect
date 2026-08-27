
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsGetCollectionIncludeItem
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
    public static class ReviewSubmissionsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionIncludeItem value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionIncludeItem.App => "app",
                ReviewSubmissionsGetCollectionIncludeItem.AppStoreVersionForReview => "appStoreVersionForReview",
                ReviewSubmissionsGetCollectionIncludeItem.Items => "items",
                ReviewSubmissionsGetCollectionIncludeItem.LastUpdatedByActor => "lastUpdatedByActor",
                ReviewSubmissionsGetCollectionIncludeItem.SubmittedByActor => "submittedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => ReviewSubmissionsGetCollectionIncludeItem.App,
                "appStoreVersionForReview" => ReviewSubmissionsGetCollectionIncludeItem.AppStoreVersionForReview,
                "items" => ReviewSubmissionsGetCollectionIncludeItem.Items,
                "lastUpdatedByActor" => ReviewSubmissionsGetCollectionIncludeItem.LastUpdatedByActor,
                "submittedByActor" => ReviewSubmissionsGetCollectionIncludeItem.SubmittedByActor,
                _ => null,
            };
        }
    }
}