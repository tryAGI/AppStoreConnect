
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsReviewSubmissionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsReviewSubmissionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsReviewSubmissionsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsReviewSubmissionsDataItemType.ReviewSubmissions => "reviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsReviewSubmissionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissions" => AppRelationshipsReviewSubmissionsDataItemType.ReviewSubmissions,
                _ => null,
            };
        }
    }
}