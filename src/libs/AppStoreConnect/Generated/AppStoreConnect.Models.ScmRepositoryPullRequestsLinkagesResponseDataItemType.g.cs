
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoryPullRequestsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ScmPullRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoryPullRequestsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoryPullRequestsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                ScmRepositoryPullRequestsLinkagesResponseDataItemType.ScmPullRequests => "scmPullRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoryPullRequestsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "scmPullRequests" => ScmRepositoryPullRequestsLinkagesResponseDataItemType.ScmPullRequests,
                _ => null,
            };
        }
    }
}