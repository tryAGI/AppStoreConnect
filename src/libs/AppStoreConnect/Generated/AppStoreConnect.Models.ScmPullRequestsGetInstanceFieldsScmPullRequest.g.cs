
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmPullRequestsGetInstanceFieldsScmPullRequest
    {
        /// <summary>
        ///
        /// </summary>
        DestinationBranchName,
        /// <summary>
        ///
        /// </summary>
        DestinationRepositoryName,
        /// <summary>
        ///
        /// </summary>
        DestinationRepositoryOwner,
        /// <summary>
        ///
        /// </summary>
        IsClosed,
        /// <summary>
        ///
        /// </summary>
        IsCrossRepository,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        SourceBranchName,
        /// <summary>
        ///
        /// </summary>
        SourceRepositoryName,
        /// <summary>
        ///
        /// </summary>
        SourceRepositoryOwner,
        /// <summary>
        ///
        /// </summary>
        Title,
        /// <summary>
        ///
        /// </summary>
        WebUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmPullRequestsGetInstanceFieldsScmPullRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmPullRequestsGetInstanceFieldsScmPullRequest value)
        {
            return value switch
            {
                ScmPullRequestsGetInstanceFieldsScmPullRequest.DestinationBranchName => "destinationBranchName",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.DestinationRepositoryName => "destinationRepositoryName",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.DestinationRepositoryOwner => "destinationRepositoryOwner",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.IsClosed => "isClosed",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.IsCrossRepository => "isCrossRepository",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.Number => "number",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.Repository => "repository",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.SourceBranchName => "sourceBranchName",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.SourceRepositoryName => "sourceRepositoryName",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.SourceRepositoryOwner => "sourceRepositoryOwner",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.Title => "title",
                ScmPullRequestsGetInstanceFieldsScmPullRequest.WebUrl => "webUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmPullRequestsGetInstanceFieldsScmPullRequest? ToEnum(string value)
        {
            return value switch
            {
                "destinationBranchName" => ScmPullRequestsGetInstanceFieldsScmPullRequest.DestinationBranchName,
                "destinationRepositoryName" => ScmPullRequestsGetInstanceFieldsScmPullRequest.DestinationRepositoryName,
                "destinationRepositoryOwner" => ScmPullRequestsGetInstanceFieldsScmPullRequest.DestinationRepositoryOwner,
                "isClosed" => ScmPullRequestsGetInstanceFieldsScmPullRequest.IsClosed,
                "isCrossRepository" => ScmPullRequestsGetInstanceFieldsScmPullRequest.IsCrossRepository,
                "number" => ScmPullRequestsGetInstanceFieldsScmPullRequest.Number,
                "repository" => ScmPullRequestsGetInstanceFieldsScmPullRequest.Repository,
                "sourceBranchName" => ScmPullRequestsGetInstanceFieldsScmPullRequest.SourceBranchName,
                "sourceRepositoryName" => ScmPullRequestsGetInstanceFieldsScmPullRequest.SourceRepositoryName,
                "sourceRepositoryOwner" => ScmPullRequestsGetInstanceFieldsScmPullRequest.SourceRepositoryOwner,
                "title" => ScmPullRequestsGetInstanceFieldsScmPullRequest.Title,
                "webUrl" => ScmPullRequestsGetInstanceFieldsScmPullRequest.WebUrl,
                _ => null,
            };
        }
    }
}