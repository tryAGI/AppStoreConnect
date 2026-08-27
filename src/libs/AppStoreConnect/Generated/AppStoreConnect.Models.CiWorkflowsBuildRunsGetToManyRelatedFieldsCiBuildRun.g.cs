
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun
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
    public static class CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Actions => "actions",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Builds => "builds",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.CancelReason => "cancelReason",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.CompletionStatus => "completionStatus",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.CreatedDate => "createdDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationBranch => "destinationBranch",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationCommit => "destinationCommit",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.ExecutionProgress => "executionProgress",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.FinishedDate => "finishedDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.IsPullRequestBuild => "isPullRequestBuild",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.IssueCounts => "issueCounts",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Number => "number",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Product => "product",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.PullRequest => "pullRequest",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceBranchOrTag => "sourceBranchOrTag",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceCommit => "sourceCommit",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartReason => "startReason",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartedDate => "startedDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Actions,
                "builds" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Builds,
                "cancelReason" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.CancelReason,
                "completionStatus" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.CompletionStatus,
                "createdDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.CreatedDate,
                "destinationBranch" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationBranch,
                "destinationCommit" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.DestinationCommit,
                "executionProgress" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.ExecutionProgress,
                "finishedDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.FinishedDate,
                "isPullRequestBuild" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.IsPullRequestBuild,
                "issueCounts" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.IssueCounts,
                "number" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Number,
                "product" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Product,
                "pullRequest" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.PullRequest,
                "sourceBranchOrTag" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceBranchOrTag,
                "sourceCommit" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.SourceCommit,
                "startReason" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartReason,
                "startedDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.StartedDate,
                "workflow" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun.Workflow,
                _ => null,
            };
        }
    }
}