
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest
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
    public static class ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest value)
        {
            return value switch
            {
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.DestinationBranchName => "destinationBranchName",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryName => "destinationRepositoryName",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryOwner => "destinationRepositoryOwner",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.IsClosed => "isClosed",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.IsCrossRepository => "isCrossRepository",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.Number => "number",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.Repository => "repository",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.SourceBranchName => "sourceBranchName",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryName => "sourceRepositoryName",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryOwner => "sourceRepositoryOwner",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.Title => "title",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.WebUrl => "webUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest? ToEnum(string value)
        {
            return value switch
            {
                "destinationBranchName" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.DestinationBranchName,
                "destinationRepositoryName" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryName,
                "destinationRepositoryOwner" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryOwner,
                "isClosed" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.IsClosed,
                "isCrossRepository" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.IsCrossRepository,
                "number" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.Number,
                "repository" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.Repository,
                "sourceBranchName" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.SourceBranchName,
                "sourceRepositoryName" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryName,
                "sourceRepositoryOwner" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryOwner,
                "title" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.Title,
                "webUrl" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmPullRequest.WebUrl,
                _ => null,
            };
        }
    }
}