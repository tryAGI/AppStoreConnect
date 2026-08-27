
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsGetInstanceFieldsCiBuildRun
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
    public static class CiBuildRunsGetInstanceFieldsCiBuildRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceFieldsCiBuildRun value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceFieldsCiBuildRun.Actions => "actions",
                CiBuildRunsGetInstanceFieldsCiBuildRun.Builds => "builds",
                CiBuildRunsGetInstanceFieldsCiBuildRun.CancelReason => "cancelReason",
                CiBuildRunsGetInstanceFieldsCiBuildRun.CompletionStatus => "completionStatus",
                CiBuildRunsGetInstanceFieldsCiBuildRun.CreatedDate => "createdDate",
                CiBuildRunsGetInstanceFieldsCiBuildRun.DestinationBranch => "destinationBranch",
                CiBuildRunsGetInstanceFieldsCiBuildRun.DestinationCommit => "destinationCommit",
                CiBuildRunsGetInstanceFieldsCiBuildRun.ExecutionProgress => "executionProgress",
                CiBuildRunsGetInstanceFieldsCiBuildRun.FinishedDate => "finishedDate",
                CiBuildRunsGetInstanceFieldsCiBuildRun.IsPullRequestBuild => "isPullRequestBuild",
                CiBuildRunsGetInstanceFieldsCiBuildRun.IssueCounts => "issueCounts",
                CiBuildRunsGetInstanceFieldsCiBuildRun.Number => "number",
                CiBuildRunsGetInstanceFieldsCiBuildRun.Product => "product",
                CiBuildRunsGetInstanceFieldsCiBuildRun.PullRequest => "pullRequest",
                CiBuildRunsGetInstanceFieldsCiBuildRun.SourceBranchOrTag => "sourceBranchOrTag",
                CiBuildRunsGetInstanceFieldsCiBuildRun.SourceCommit => "sourceCommit",
                CiBuildRunsGetInstanceFieldsCiBuildRun.StartReason => "startReason",
                CiBuildRunsGetInstanceFieldsCiBuildRun.StartedDate => "startedDate",
                CiBuildRunsGetInstanceFieldsCiBuildRun.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceFieldsCiBuildRun? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiBuildRunsGetInstanceFieldsCiBuildRun.Actions,
                "builds" => CiBuildRunsGetInstanceFieldsCiBuildRun.Builds,
                "cancelReason" => CiBuildRunsGetInstanceFieldsCiBuildRun.CancelReason,
                "completionStatus" => CiBuildRunsGetInstanceFieldsCiBuildRun.CompletionStatus,
                "createdDate" => CiBuildRunsGetInstanceFieldsCiBuildRun.CreatedDate,
                "destinationBranch" => CiBuildRunsGetInstanceFieldsCiBuildRun.DestinationBranch,
                "destinationCommit" => CiBuildRunsGetInstanceFieldsCiBuildRun.DestinationCommit,
                "executionProgress" => CiBuildRunsGetInstanceFieldsCiBuildRun.ExecutionProgress,
                "finishedDate" => CiBuildRunsGetInstanceFieldsCiBuildRun.FinishedDate,
                "isPullRequestBuild" => CiBuildRunsGetInstanceFieldsCiBuildRun.IsPullRequestBuild,
                "issueCounts" => CiBuildRunsGetInstanceFieldsCiBuildRun.IssueCounts,
                "number" => CiBuildRunsGetInstanceFieldsCiBuildRun.Number,
                "product" => CiBuildRunsGetInstanceFieldsCiBuildRun.Product,
                "pullRequest" => CiBuildRunsGetInstanceFieldsCiBuildRun.PullRequest,
                "sourceBranchOrTag" => CiBuildRunsGetInstanceFieldsCiBuildRun.SourceBranchOrTag,
                "sourceCommit" => CiBuildRunsGetInstanceFieldsCiBuildRun.SourceCommit,
                "startReason" => CiBuildRunsGetInstanceFieldsCiBuildRun.StartReason,
                "startedDate" => CiBuildRunsGetInstanceFieldsCiBuildRun.StartedDate,
                "workflow" => CiBuildRunsGetInstanceFieldsCiBuildRun.Workflow,
                _ => null,
            };
        }
    }
}