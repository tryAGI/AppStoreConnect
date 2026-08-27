
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest
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
    public static class CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationBranchName => "destinationBranchName",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryName => "destinationRepositoryName",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryOwner => "destinationRepositoryOwner",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsClosed => "isClosed",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsCrossRepository => "isCrossRepository",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.Number => "number",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.Repository => "repository",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceBranchName => "sourceBranchName",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryName => "sourceRepositoryName",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryOwner => "sourceRepositoryOwner",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.Title => "title",
                CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.WebUrl => "webUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest? ToEnum(string value)
        {
            return value switch
            {
                "destinationBranchName" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationBranchName,
                "destinationRepositoryName" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryName,
                "destinationRepositoryOwner" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.DestinationRepositoryOwner,
                "isClosed" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsClosed,
                "isCrossRepository" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.IsCrossRepository,
                "number" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.Number,
                "repository" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.Repository,
                "sourceBranchName" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceBranchName,
                "sourceRepositoryName" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryName,
                "sourceRepositoryOwner" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.SourceRepositoryOwner,
                "title" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.Title,
                "webUrl" => CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest.WebUrl,
                _ => null,
            };
        }
    }
}