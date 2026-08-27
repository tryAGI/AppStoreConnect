
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue
    {
        /// <summary>
        ///
        /// </summary>
        Category,
        /// <summary>
        ///
        /// </summary>
        FileSource,
        /// <summary>
        ///
        /// </summary>
        IssueType,
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionsIssuesGetToManyRelatedFieldsCiIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue value)
        {
            return value switch
            {
                CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.Category => "category",
                CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.FileSource => "fileSource",
                CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.IssueType => "issueType",
                CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue? ToEnum(string value)
        {
            return value switch
            {
                "category" => CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.Category,
                "fileSource" => CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.FileSource,
                "issueType" => CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.IssueType,
                "message" => CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue.Message,
                _ => null,
            };
        }
    }
}