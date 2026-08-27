
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest
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
    public static class CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationBranchName => "destinationBranchName",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryName => "destinationRepositoryName",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryOwner => "destinationRepositoryOwner",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsClosed => "isClosed",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsCrossRepository => "isCrossRepository",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.Number => "number",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.Repository => "repository",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceBranchName => "sourceBranchName",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryName => "sourceRepositoryName",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryOwner => "sourceRepositoryOwner",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.Title => "title",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.WebUrl => "webUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest? ToEnum(string value)
        {
            return value switch
            {
                "destinationBranchName" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationBranchName,
                "destinationRepositoryName" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryName,
                "destinationRepositoryOwner" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryOwner,
                "isClosed" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsClosed,
                "isCrossRepository" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsCrossRepository,
                "number" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.Number,
                "repository" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.Repository,
                "sourceBranchName" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceBranchName,
                "sourceRepositoryName" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryName,
                "sourceRepositoryOwner" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryOwner,
                "title" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.Title,
                "webUrl" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest.WebUrl,
                _ => null,
            };
        }
    }
}