
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest
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
    public static class CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.DestinationBranchName => "destinationBranchName",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.DestinationRepositoryName => "destinationRepositoryName",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.DestinationRepositoryOwner => "destinationRepositoryOwner",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.IsClosed => "isClosed",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.IsCrossRepository => "isCrossRepository",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.Number => "number",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.Repository => "repository",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.SourceBranchName => "sourceBranchName",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.SourceRepositoryName => "sourceRepositoryName",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.SourceRepositoryOwner => "sourceRepositoryOwner",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.Title => "title",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.WebUrl => "webUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest? ToEnum(string value)
        {
            return value switch
            {
                "destinationBranchName" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.DestinationBranchName,
                "destinationRepositoryName" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.DestinationRepositoryName,
                "destinationRepositoryOwner" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.DestinationRepositoryOwner,
                "isClosed" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.IsClosed,
                "isCrossRepository" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.IsCrossRepository,
                "number" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.Number,
                "repository" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.Repository,
                "sourceBranchName" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.SourceBranchName,
                "sourceRepositoryName" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.SourceRepositoryName,
                "sourceRepositoryOwner" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.SourceRepositoryOwner,
                "title" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.Title,
                "webUrl" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest.WebUrl,
                _ => null,
            };
        }
    }
}