
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow
    {
        /// <summary>
        /// 
        /// </summary>
        Actions,
        /// <summary>
        /// 
        /// </summary>
        BranchStartCondition,
        /// <summary>
        /// 
        /// </summary>
        BuildRuns,
        /// <summary>
        /// 
        /// </summary>
        Clean,
        /// <summary>
        /// 
        /// </summary>
        ContainerFilePath,
        /// <summary>
        /// 
        /// </summary>
        Description,
        /// <summary>
        /// 
        /// </summary>
        IsEnabled,
        /// <summary>
        /// 
        /// </summary>
        IsLockedForEditing,
        /// <summary>
        /// 
        /// </summary>
        LastModifiedDate,
        /// <summary>
        /// 
        /// </summary>
        MacOsVersion,
        /// <summary>
        /// 
        /// </summary>
        ManualBranchStartCondition,
        /// <summary>
        /// 
        /// </summary>
        ManualPullRequestStartCondition,
        /// <summary>
        /// 
        /// </summary>
        ManualTagStartCondition,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Product,
        /// <summary>
        /// 
        /// </summary>
        PullRequestStartCondition,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        ScheduledStartCondition,
        /// <summary>
        /// 
        /// </summary>
        TagStartCondition,
        /// <summary>
        /// 
        /// </summary>
        XcodeVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Actions => "actions",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.BranchStartCondition => "branchStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.BuildRuns => "buildRuns",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Clean => "clean",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ContainerFilePath => "containerFilePath",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Description => "description",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsEnabled => "isEnabled",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsLockedForEditing => "isLockedForEditing",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.LastModifiedDate => "lastModifiedDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.MacOsVersion => "macOsVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualBranchStartCondition => "manualBranchStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualPullRequestStartCondition => "manualPullRequestStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualTagStartCondition => "manualTagStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Name => "name",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Product => "product",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.PullRequestStartCondition => "pullRequestStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Repository => "repository",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ScheduledStartCondition => "scheduledStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.TagStartCondition => "tagStartCondition",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Actions,
                "branchStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.BranchStartCondition,
                "buildRuns" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.BuildRuns,
                "clean" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Clean,
                "containerFilePath" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ContainerFilePath,
                "description" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Description,
                "isEnabled" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsEnabled,
                "isLockedForEditing" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsLockedForEditing,
                "lastModifiedDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.LastModifiedDate,
                "macOsVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.MacOsVersion,
                "manualBranchStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualBranchStartCondition,
                "manualPullRequestStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualPullRequestStartCondition,
                "manualTagStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualTagStartCondition,
                "name" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Name,
                "product" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Product,
                "pullRequestStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.PullRequestStartCondition,
                "repository" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.Repository,
                "scheduledStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.ScheduledStartCondition,
                "tagStartCondition" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.TagStartCondition,
                "xcodeVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow.XcodeVersion,
                _ => null,
            };
        }
    }
}