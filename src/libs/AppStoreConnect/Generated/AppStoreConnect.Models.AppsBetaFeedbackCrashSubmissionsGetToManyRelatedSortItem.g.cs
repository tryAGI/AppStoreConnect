
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuscreatedDate,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem.MinuscreatedDate,
                "createdDate" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedSortItem.CreatedDate,
                _ => null,
            };
        }
    }
}