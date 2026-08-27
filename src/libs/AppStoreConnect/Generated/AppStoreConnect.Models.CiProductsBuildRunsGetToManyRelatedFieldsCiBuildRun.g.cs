
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun
    {
        /// <summary>
        ///
        /// </summary>
        Actions,
        /// <summary>
        ///
        /// </summary>
        Builds,
        /// <summary>
        ///
        /// </summary>
        CancelReason,
        /// <summary>
        ///
        /// </summary>
        CompletionStatus,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        DestinationBranch,
        /// <summary>
        ///
        /// </summary>
        DestinationCommit,
        /// <summary>
        ///
        /// </summary>
        ExecutionProgress,
        /// <summary>
        ///
        /// </summary>
        FinishedDate,
        /// <summary>
        ///
        /// </summary>
        IsPullRequestBuild,
        /// <summary>
        ///
        /// </summary>
        IssueCounts,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Product,
        /// <summary>
        ///
        /// </summary>
        PullRequest,
        /// <summary>
        ///
        /// </summary>
        SourceBranchOrTag,
        /// <summary>
        ///
        /// </summary>
        SourceCommit,
        /// <summary>
        ///
        /// </summary>
        StartReason,
        /// <summary>
        ///
        /// </summary>
        StartedDate,
        /// <summary>
        ///
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Actions => "actions",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Builds => "builds",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.CancelReason => "cancelReason",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.CompletionStatus => "completionStatus",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.CreatedDate => "createdDate",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationBranch => "destinationBranch",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationCommit => "destinationCommit",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.ExecutionProgress => "executionProgress",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.FinishedDate => "finishedDate",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.IsPullRequestBuild => "isPullRequestBuild",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.IssueCounts => "issueCounts",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Number => "number",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Product => "product",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.PullRequest => "pullRequest",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceBranchOrTag => "sourceBranchOrTag",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceCommit => "sourceCommit",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartReason => "startReason",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartedDate => "startedDate",
                CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Actions,
                "builds" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Builds,
                "cancelReason" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.CancelReason,
                "completionStatus" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.CompletionStatus,
                "createdDate" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.CreatedDate,
                "destinationBranch" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationBranch,
                "destinationCommit" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationCommit,
                "executionProgress" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.ExecutionProgress,
                "finishedDate" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.FinishedDate,
                "isPullRequestBuild" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.IsPullRequestBuild,
                "issueCounts" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.IssueCounts,
                "number" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Number,
                "product" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Product,
                "pullRequest" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.PullRequest,
                "sourceBranchOrTag" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceBranchOrTag,
                "sourceCommit" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceCommit,
                "startReason" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartReason,
                "startedDate" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartedDate,
                "workflow" => CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun.Workflow,
                _ => null,
            };
        }
    }
}