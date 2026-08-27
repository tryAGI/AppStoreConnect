
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem
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
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem.MinuscreatedDate,
                "createdDate" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem.CreatedDate,
                _ => null,
            };
        }
    }
}