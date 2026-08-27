
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsGetInstanceFieldsScmPullRequest
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
    public static class CiBuildRunsGetInstanceFieldsScmPullRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceFieldsScmPullRequest value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceFieldsScmPullRequest.DestinationBranchName => "destinationBranchName",
                CiBuildRunsGetInstanceFieldsScmPullRequest.DestinationRepositoryName => "destinationRepositoryName",
                CiBuildRunsGetInstanceFieldsScmPullRequest.DestinationRepositoryOwner => "destinationRepositoryOwner",
                CiBuildRunsGetInstanceFieldsScmPullRequest.IsClosed => "isClosed",
                CiBuildRunsGetInstanceFieldsScmPullRequest.IsCrossRepository => "isCrossRepository",
                CiBuildRunsGetInstanceFieldsScmPullRequest.Number => "number",
                CiBuildRunsGetInstanceFieldsScmPullRequest.Repository => "repository",
                CiBuildRunsGetInstanceFieldsScmPullRequest.SourceBranchName => "sourceBranchName",
                CiBuildRunsGetInstanceFieldsScmPullRequest.SourceRepositoryName => "sourceRepositoryName",
                CiBuildRunsGetInstanceFieldsScmPullRequest.SourceRepositoryOwner => "sourceRepositoryOwner",
                CiBuildRunsGetInstanceFieldsScmPullRequest.Title => "title",
                CiBuildRunsGetInstanceFieldsScmPullRequest.WebUrl => "webUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceFieldsScmPullRequest? ToEnum(string value)
        {
            return value switch
            {
                "destinationBranchName" => CiBuildRunsGetInstanceFieldsScmPullRequest.DestinationBranchName,
                "destinationRepositoryName" => CiBuildRunsGetInstanceFieldsScmPullRequest.DestinationRepositoryName,
                "destinationRepositoryOwner" => CiBuildRunsGetInstanceFieldsScmPullRequest.DestinationRepositoryOwner,
                "isClosed" => CiBuildRunsGetInstanceFieldsScmPullRequest.IsClosed,
                "isCrossRepository" => CiBuildRunsGetInstanceFieldsScmPullRequest.IsCrossRepository,
                "number" => CiBuildRunsGetInstanceFieldsScmPullRequest.Number,
                "repository" => CiBuildRunsGetInstanceFieldsScmPullRequest.Repository,
                "sourceBranchName" => CiBuildRunsGetInstanceFieldsScmPullRequest.SourceBranchName,
                "sourceRepositoryName" => CiBuildRunsGetInstanceFieldsScmPullRequest.SourceRepositoryName,
                "sourceRepositoryOwner" => CiBuildRunsGetInstanceFieldsScmPullRequest.SourceRepositoryOwner,
                "title" => CiBuildRunsGetInstanceFieldsScmPullRequest.Title,
                "webUrl" => CiBuildRunsGetInstanceFieldsScmPullRequest.WebUrl,
                _ => null,
            };
        }
    }
}