
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsGetInstanceFieldsCiWorkflow
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
    public static class CiBuildRunsGetInstanceFieldsCiWorkflowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceFieldsCiWorkflow value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceFieldsCiWorkflow.Actions => "actions",
                CiBuildRunsGetInstanceFieldsCiWorkflow.BranchStartCondition => "branchStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.BuildRuns => "buildRuns",
                CiBuildRunsGetInstanceFieldsCiWorkflow.Clean => "clean",
                CiBuildRunsGetInstanceFieldsCiWorkflow.ContainerFilePath => "containerFilePath",
                CiBuildRunsGetInstanceFieldsCiWorkflow.Description => "description",
                CiBuildRunsGetInstanceFieldsCiWorkflow.IsEnabled => "isEnabled",
                CiBuildRunsGetInstanceFieldsCiWorkflow.IsLockedForEditing => "isLockedForEditing",
                CiBuildRunsGetInstanceFieldsCiWorkflow.LastModifiedDate => "lastModifiedDate",
                CiBuildRunsGetInstanceFieldsCiWorkflow.MacOsVersion => "macOsVersion",
                CiBuildRunsGetInstanceFieldsCiWorkflow.ManualBranchStartCondition => "manualBranchStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.ManualPullRequestStartCondition => "manualPullRequestStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.ManualTagStartCondition => "manualTagStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.Name => "name",
                CiBuildRunsGetInstanceFieldsCiWorkflow.Product => "product",
                CiBuildRunsGetInstanceFieldsCiWorkflow.PullRequestStartCondition => "pullRequestStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.Repository => "repository",
                CiBuildRunsGetInstanceFieldsCiWorkflow.ScheduledStartCondition => "scheduledStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.TagStartCondition => "tagStartCondition",
                CiBuildRunsGetInstanceFieldsCiWorkflow.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceFieldsCiWorkflow? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiBuildRunsGetInstanceFieldsCiWorkflow.Actions,
                "branchStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.BranchStartCondition,
                "buildRuns" => CiBuildRunsGetInstanceFieldsCiWorkflow.BuildRuns,
                "clean" => CiBuildRunsGetInstanceFieldsCiWorkflow.Clean,
                "containerFilePath" => CiBuildRunsGetInstanceFieldsCiWorkflow.ContainerFilePath,
                "description" => CiBuildRunsGetInstanceFieldsCiWorkflow.Description,
                "isEnabled" => CiBuildRunsGetInstanceFieldsCiWorkflow.IsEnabled,
                "isLockedForEditing" => CiBuildRunsGetInstanceFieldsCiWorkflow.IsLockedForEditing,
                "lastModifiedDate" => CiBuildRunsGetInstanceFieldsCiWorkflow.LastModifiedDate,
                "macOsVersion" => CiBuildRunsGetInstanceFieldsCiWorkflow.MacOsVersion,
                "manualBranchStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.ManualBranchStartCondition,
                "manualPullRequestStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.ManualPullRequestStartCondition,
                "manualTagStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.ManualTagStartCondition,
                "name" => CiBuildRunsGetInstanceFieldsCiWorkflow.Name,
                "product" => CiBuildRunsGetInstanceFieldsCiWorkflow.Product,
                "pullRequestStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.PullRequestStartCondition,
                "repository" => CiBuildRunsGetInstanceFieldsCiWorkflow.Repository,
                "scheduledStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.ScheduledStartCondition,
                "tagStartCondition" => CiBuildRunsGetInstanceFieldsCiWorkflow.TagStartCondition,
                "xcodeVersion" => CiBuildRunsGetInstanceFieldsCiWorkflow.XcodeVersion,
                _ => null,
            };
        }
    }
}