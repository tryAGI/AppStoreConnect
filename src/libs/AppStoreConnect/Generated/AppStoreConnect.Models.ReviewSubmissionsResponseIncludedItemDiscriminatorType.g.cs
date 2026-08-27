
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissionItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ReviewSubmissionsResponseIncludedItemDiscriminatorType.Actors => "actors",
                ReviewSubmissionsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                ReviewSubmissionsResponseIncludedItemDiscriminatorType.Apps => "apps",
                ReviewSubmissionsResponseIncludedItemDiscriminatorType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => ReviewSubmissionsResponseIncludedItemDiscriminatorType.Actors,
                "appStoreVersions" => ReviewSubmissionsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => ReviewSubmissionsResponseIncludedItemDiscriminatorType.Apps,
                "reviewSubmissionItems" => ReviewSubmissionsResponseIncludedItemDiscriminatorType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}