
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction
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
    public static class CiBuildRunsActionsGetToManyRelatedFieldsCiBuildActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction value)
        {
            return value switch
            {
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.ActionType => "actionType",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.Artifacts => "artifacts",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.BuildRun => "buildRun",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.CompletionStatus => "completionStatus",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.ExecutionProgress => "executionProgress",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.FinishedDate => "finishedDate",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.IsRequiredToPass => "isRequiredToPass",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.IssueCounts => "issueCounts",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.Issues => "issues",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.Name => "name",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.StartedDate => "startedDate",
                CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.TestResults => "testResults",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction? ToEnum(string value)
        {
            return value switch
            {
                "actionType" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.ActionType,
                "artifacts" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.Artifacts,
                "buildRun" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.BuildRun,
                "completionStatus" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.CompletionStatus,
                "executionProgress" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.ExecutionProgress,
                "finishedDate" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.FinishedDate,
                "isRequiredToPass" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.IsRequiredToPass,
                "issueCounts" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.IssueCounts,
                "issues" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.Issues,
                "name" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.Name,
                "startedDate" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.StartedDate,
                "testResults" => CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction.TestResults,
                _ => null,
            };
        }
    }
}