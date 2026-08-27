
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun
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
    public static class CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Actions => "actions",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Builds => "builds",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.CancelReason => "cancelReason",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.CompletionStatus => "completionStatus",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.CreatedDate => "createdDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.DestinationBranch => "destinationBranch",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.DestinationCommit => "destinationCommit",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.ExecutionProgress => "executionProgress",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.FinishedDate => "finishedDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.IsPullRequestBuild => "isPullRequestBuild",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.IssueCounts => "issueCounts",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Number => "number",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Product => "product",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.PullRequest => "pullRequest",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.SourceBranchOrTag => "sourceBranchOrTag",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.SourceCommit => "sourceCommit",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.StartReason => "startReason",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.StartedDate => "startedDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Actions,
                "builds" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Builds,
                "cancelReason" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.CancelReason,
                "completionStatus" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.CompletionStatus,
                "createdDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.CreatedDate,
                "destinationBranch" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.DestinationBranch,
                "destinationCommit" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.DestinationCommit,
                "executionProgress" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.ExecutionProgress,
                "finishedDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.FinishedDate,
                "isPullRequestBuild" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.IsPullRequestBuild,
                "issueCounts" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.IssueCounts,
                "number" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Number,
                "product" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Product,
                "pullRequest" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.PullRequest,
                "sourceBranchOrTag" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.SourceBranchOrTag,
                "sourceCommit" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.SourceCommit,
                "startReason" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.StartReason,
                "startedDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.StartedDate,
                "workflow" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun.Workflow,
                _ => null,
            };
        }
    }
}