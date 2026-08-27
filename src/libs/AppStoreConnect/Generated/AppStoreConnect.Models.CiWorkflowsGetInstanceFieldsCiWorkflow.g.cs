
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowsGetInstanceFieldsCiWorkflow
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
    public static class CiWorkflowsGetInstanceFieldsCiWorkflowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsGetInstanceFieldsCiWorkflow value)
        {
            return value switch
            {
                CiWorkflowsGetInstanceFieldsCiWorkflow.Actions => "actions",
                CiWorkflowsGetInstanceFieldsCiWorkflow.BranchStartCondition => "branchStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.BuildRuns => "buildRuns",
                CiWorkflowsGetInstanceFieldsCiWorkflow.Clean => "clean",
                CiWorkflowsGetInstanceFieldsCiWorkflow.ContainerFilePath => "containerFilePath",
                CiWorkflowsGetInstanceFieldsCiWorkflow.Description => "description",
                CiWorkflowsGetInstanceFieldsCiWorkflow.IsEnabled => "isEnabled",
                CiWorkflowsGetInstanceFieldsCiWorkflow.IsLockedForEditing => "isLockedForEditing",
                CiWorkflowsGetInstanceFieldsCiWorkflow.LastModifiedDate => "lastModifiedDate",
                CiWorkflowsGetInstanceFieldsCiWorkflow.MacOsVersion => "macOsVersion",
                CiWorkflowsGetInstanceFieldsCiWorkflow.ManualBranchStartCondition => "manualBranchStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.ManualPullRequestStartCondition => "manualPullRequestStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.ManualTagStartCondition => "manualTagStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.Name => "name",
                CiWorkflowsGetInstanceFieldsCiWorkflow.Product => "product",
                CiWorkflowsGetInstanceFieldsCiWorkflow.PullRequestStartCondition => "pullRequestStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.Repository => "repository",
                CiWorkflowsGetInstanceFieldsCiWorkflow.ScheduledStartCondition => "scheduledStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.TagStartCondition => "tagStartCondition",
                CiWorkflowsGetInstanceFieldsCiWorkflow.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsGetInstanceFieldsCiWorkflow? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiWorkflowsGetInstanceFieldsCiWorkflow.Actions,
                "branchStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.BranchStartCondition,
                "buildRuns" => CiWorkflowsGetInstanceFieldsCiWorkflow.BuildRuns,
                "clean" => CiWorkflowsGetInstanceFieldsCiWorkflow.Clean,
                "containerFilePath" => CiWorkflowsGetInstanceFieldsCiWorkflow.ContainerFilePath,
                "description" => CiWorkflowsGetInstanceFieldsCiWorkflow.Description,
                "isEnabled" => CiWorkflowsGetInstanceFieldsCiWorkflow.IsEnabled,
                "isLockedForEditing" => CiWorkflowsGetInstanceFieldsCiWorkflow.IsLockedForEditing,
                "lastModifiedDate" => CiWorkflowsGetInstanceFieldsCiWorkflow.LastModifiedDate,
                "macOsVersion" => CiWorkflowsGetInstanceFieldsCiWorkflow.MacOsVersion,
                "manualBranchStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.ManualBranchStartCondition,
                "manualPullRequestStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.ManualPullRequestStartCondition,
                "manualTagStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.ManualTagStartCondition,
                "name" => CiWorkflowsGetInstanceFieldsCiWorkflow.Name,
                "product" => CiWorkflowsGetInstanceFieldsCiWorkflow.Product,
                "pullRequestStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.PullRequestStartCondition,
                "repository" => CiWorkflowsGetInstanceFieldsCiWorkflow.Repository,
                "scheduledStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.ScheduledStartCondition,
                "tagStartCondition" => CiWorkflowsGetInstanceFieldsCiWorkflow.TagStartCondition,
                "xcodeVersion" => CiWorkflowsGetInstanceFieldsCiWorkflow.XcodeVersion,
                _ => null,
            };
        }
    }
}