
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetInstanceIncludeItem
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
    public static class ReviewSubmissionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                ReviewSubmissionsGetInstanceIncludeItem.App => "app",
                ReviewSubmissionsGetInstanceIncludeItem.AppStoreVersionForReview => "appStoreVersionForReview",
                ReviewSubmissionsGetInstanceIncludeItem.Items => "items",
                ReviewSubmissionsGetInstanceIncludeItem.LastUpdatedByActor => "lastUpdatedByActor",
                ReviewSubmissionsGetInstanceIncludeItem.SubmittedByActor => "submittedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => ReviewSubmissionsGetInstanceIncludeItem.App,
                "appStoreVersionForReview" => ReviewSubmissionsGetInstanceIncludeItem.AppStoreVersionForReview,
                "items" => ReviewSubmissionsGetInstanceIncludeItem.Items,
                "lastUpdatedByActor" => ReviewSubmissionsGetInstanceIncludeItem.LastUpdatedByActor,
                "submittedByActor" => ReviewSubmissionsGetInstanceIncludeItem.SubmittedByActor,
                _ => null,
            };
        }
    }
}