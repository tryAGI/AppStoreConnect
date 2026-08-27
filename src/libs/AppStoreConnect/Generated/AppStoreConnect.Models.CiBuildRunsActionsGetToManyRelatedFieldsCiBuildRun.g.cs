
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun
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
    public static class CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun value)
        {
            return value switch
            {
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Actions => "actions",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Builds => "builds",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.CancelReason => "cancelReason",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.CompletionStatus => "completionStatus",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.CreatedDate => "createdDate",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.DestinationBranch => "destinationBranch",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.DestinationCommit => "destinationCommit",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.ExecutionProgress => "executionProgress",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.FinishedDate => "finishedDate",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.IsPullRequestBuild => "isPullRequestBuild",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.IssueCounts => "issueCounts",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Number => "number",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Product => "product",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.PullRequest => "pullRequest",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.SourceBranchOrTag => "sourceBranchOrTag",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.SourceCommit => "sourceCommit",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.StartReason => "startReason",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.StartedDate => "startedDate",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Actions,
                "builds" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Builds,
                "cancelReason" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.CancelReason,
                "completionStatus" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.CompletionStatus,
                "createdDate" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.CreatedDate,
                "destinationBranch" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.DestinationBranch,
                "destinationCommit" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.DestinationCommit,
                "executionProgress" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.ExecutionProgress,
                "finishedDate" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.FinishedDate,
                "isPullRequestBuild" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.IsPullRequestBuild,
                "issueCounts" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.IssueCounts,
                "number" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Number,
                "product" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Product,
                "pullRequest" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.PullRequest,
                "sourceBranchOrTag" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.SourceBranchOrTag,
                "sourceCommit" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.SourceCommit,
                "startReason" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.StartReason,
                "startedDate" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.StartedDate,
                "workflow" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun.Workflow,
                _ => null,
            };
        }
    }
}