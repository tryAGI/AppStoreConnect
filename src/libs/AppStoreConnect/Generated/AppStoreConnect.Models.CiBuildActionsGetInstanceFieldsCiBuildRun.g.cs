
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsGetInstanceFieldsCiBuildRun
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
    public static class CiBuildActionsGetInstanceFieldsCiBuildRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsGetInstanceFieldsCiBuildRun value)
        {
            return value switch
            {
                CiBuildActionsGetInstanceFieldsCiBuildRun.Actions => "actions",
                CiBuildActionsGetInstanceFieldsCiBuildRun.Builds => "builds",
                CiBuildActionsGetInstanceFieldsCiBuildRun.CancelReason => "cancelReason",
                CiBuildActionsGetInstanceFieldsCiBuildRun.CompletionStatus => "completionStatus",
                CiBuildActionsGetInstanceFieldsCiBuildRun.CreatedDate => "createdDate",
                CiBuildActionsGetInstanceFieldsCiBuildRun.DestinationBranch => "destinationBranch",
                CiBuildActionsGetInstanceFieldsCiBuildRun.DestinationCommit => "destinationCommit",
                CiBuildActionsGetInstanceFieldsCiBuildRun.ExecutionProgress => "executionProgress",
                CiBuildActionsGetInstanceFieldsCiBuildRun.FinishedDate => "finishedDate",
                CiBuildActionsGetInstanceFieldsCiBuildRun.IsPullRequestBuild => "isPullRequestBuild",
                CiBuildActionsGetInstanceFieldsCiBuildRun.IssueCounts => "issueCounts",
                CiBuildActionsGetInstanceFieldsCiBuildRun.Number => "number",
                CiBuildActionsGetInstanceFieldsCiBuildRun.Product => "product",
                CiBuildActionsGetInstanceFieldsCiBuildRun.PullRequest => "pullRequest",
                CiBuildActionsGetInstanceFieldsCiBuildRun.SourceBranchOrTag => "sourceBranchOrTag",
                CiBuildActionsGetInstanceFieldsCiBuildRun.SourceCommit => "sourceCommit",
                CiBuildActionsGetInstanceFieldsCiBuildRun.StartReason => "startReason",
                CiBuildActionsGetInstanceFieldsCiBuildRun.StartedDate => "startedDate",
                CiBuildActionsGetInstanceFieldsCiBuildRun.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsGetInstanceFieldsCiBuildRun? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiBuildActionsGetInstanceFieldsCiBuildRun.Actions,
                "builds" => CiBuildActionsGetInstanceFieldsCiBuildRun.Builds,
                "cancelReason" => CiBuildActionsGetInstanceFieldsCiBuildRun.CancelReason,
                "completionStatus" => CiBuildActionsGetInstanceFieldsCiBuildRun.CompletionStatus,
                "createdDate" => CiBuildActionsGetInstanceFieldsCiBuildRun.CreatedDate,
                "destinationBranch" => CiBuildActionsGetInstanceFieldsCiBuildRun.DestinationBranch,
                "destinationCommit" => CiBuildActionsGetInstanceFieldsCiBuildRun.DestinationCommit,
                "executionProgress" => CiBuildActionsGetInstanceFieldsCiBuildRun.ExecutionProgress,
                "finishedDate" => CiBuildActionsGetInstanceFieldsCiBuildRun.FinishedDate,
                "isPullRequestBuild" => CiBuildActionsGetInstanceFieldsCiBuildRun.IsPullRequestBuild,
                "issueCounts" => CiBuildActionsGetInstanceFieldsCiBuildRun.IssueCounts,
                "number" => CiBuildActionsGetInstanceFieldsCiBuildRun.Number,
                "product" => CiBuildActionsGetInstanceFieldsCiBuildRun.Product,
                "pullRequest" => CiBuildActionsGetInstanceFieldsCiBuildRun.PullRequest,
                "sourceBranchOrTag" => CiBuildActionsGetInstanceFieldsCiBuildRun.SourceBranchOrTag,
                "sourceCommit" => CiBuildActionsGetInstanceFieldsCiBuildRun.SourceCommit,
                "startReason" => CiBuildActionsGetInstanceFieldsCiBuildRun.StartReason,
                "startedDate" => CiBuildActionsGetInstanceFieldsCiBuildRun.StartedDate,
                "workflow" => CiBuildActionsGetInstanceFieldsCiBuildRun.Workflow,
                _ => null,
            };
        }
    }
}