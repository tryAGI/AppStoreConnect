
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsGetInstanceFieldsCiBuildAction
    {
        /// <summary>
        /// 
        /// </summary>
        ActionType,
        /// <summary>
        /// 
        /// </summary>
        Artifacts,
        /// <summary>
        /// 
        /// </summary>
        BuildRun,
        /// <summary>
        /// 
        /// </summary>
        CompletionStatus,
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
        IsRequiredToPass,
        /// <summary>
        /// 
        /// </summary>
        IssueCounts,
        /// <summary>
        /// 
        /// </summary>
        Issues,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        StartedDate,
        /// <summary>
        /// 
        /// </summary>
        TestResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionsGetInstanceFieldsCiBuildActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsGetInstanceFieldsCiBuildAction value)
        {
            return value switch
            {
                CiBuildActionsGetInstanceFieldsCiBuildAction.ActionType => "actionType",
                CiBuildActionsGetInstanceFieldsCiBuildAction.Artifacts => "artifacts",
                CiBuildActionsGetInstanceFieldsCiBuildAction.BuildRun => "buildRun",
                CiBuildActionsGetInstanceFieldsCiBuildAction.CompletionStatus => "completionStatus",
                CiBuildActionsGetInstanceFieldsCiBuildAction.ExecutionProgress => "executionProgress",
                CiBuildActionsGetInstanceFieldsCiBuildAction.FinishedDate => "finishedDate",
                CiBuildActionsGetInstanceFieldsCiBuildAction.IsRequiredToPass => "isRequiredToPass",
                CiBuildActionsGetInstanceFieldsCiBuildAction.IssueCounts => "issueCounts",
                CiBuildActionsGetInstanceFieldsCiBuildAction.Issues => "issues",
                CiBuildActionsGetInstanceFieldsCiBuildAction.Name => "name",
                CiBuildActionsGetInstanceFieldsCiBuildAction.StartedDate => "startedDate",
                CiBuildActionsGetInstanceFieldsCiBuildAction.TestResults => "testResults",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsGetInstanceFieldsCiBuildAction? ToEnum(string value)
        {
            return value switch
            {
                "actionType" => CiBuildActionsGetInstanceFieldsCiBuildAction.ActionType,
                "artifacts" => CiBuildActionsGetInstanceFieldsCiBuildAction.Artifacts,
                "buildRun" => CiBuildActionsGetInstanceFieldsCiBuildAction.BuildRun,
                "completionStatus" => CiBuildActionsGetInstanceFieldsCiBuildAction.CompletionStatus,
                "executionProgress" => CiBuildActionsGetInstanceFieldsCiBuildAction.ExecutionProgress,
                "finishedDate" => CiBuildActionsGetInstanceFieldsCiBuildAction.FinishedDate,
                "isRequiredToPass" => CiBuildActionsGetInstanceFieldsCiBuildAction.IsRequiredToPass,
                "issueCounts" => CiBuildActionsGetInstanceFieldsCiBuildAction.IssueCounts,
                "issues" => CiBuildActionsGetInstanceFieldsCiBuildAction.Issues,
                "name" => CiBuildActionsGetInstanceFieldsCiBuildAction.Name,
                "startedDate" => CiBuildActionsGetInstanceFieldsCiBuildAction.StartedDate,
                "testResults" => CiBuildActionsGetInstanceFieldsCiBuildAction.TestResults,
                _ => null,
            };
        }
    }
}