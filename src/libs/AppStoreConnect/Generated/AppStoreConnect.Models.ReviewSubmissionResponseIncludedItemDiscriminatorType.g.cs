
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionResponseIncludedItemDiscriminatorType
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
    public static class ReviewSubmissionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ReviewSubmissionResponseIncludedItemDiscriminatorType.Actors => "actors",
                ReviewSubmissionResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                ReviewSubmissionResponseIncludedItemDiscriminatorType.Apps => "apps",
                ReviewSubmissionResponseIncludedItemDiscriminatorType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => ReviewSubmissionResponseIncludedItemDiscriminatorType.Actors,
                "appStoreVersions" => ReviewSubmissionResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => ReviewSubmissionResponseIncludedItemDiscriminatorType.Apps,
                "reviewSubmissionItems" => ReviewSubmissionResponseIncludedItemDiscriminatorType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}