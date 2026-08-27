
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiIssuesGetInstanceFieldsCiIssue
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
    public static class CiIssuesGetInstanceFieldsCiIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiIssuesGetInstanceFieldsCiIssue value)
        {
            return value switch
            {
                CiIssuesGetInstanceFieldsCiIssue.Category => "category",
                CiIssuesGetInstanceFieldsCiIssue.FileSource => "fileSource",
                CiIssuesGetInstanceFieldsCiIssue.IssueType => "issueType",
                CiIssuesGetInstanceFieldsCiIssue.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiIssuesGetInstanceFieldsCiIssue? ToEnum(string value)
        {
            return value switch
            {
                "category" => CiIssuesGetInstanceFieldsCiIssue.Category,
                "fileSource" => CiIssuesGetInstanceFieldsCiIssue.FileSource,
                "issueType" => CiIssuesGetInstanceFieldsCiIssue.IssueType,
                "message" => CiIssuesGetInstanceFieldsCiIssue.Message,
                _ => null,
            };
        }
    }
}