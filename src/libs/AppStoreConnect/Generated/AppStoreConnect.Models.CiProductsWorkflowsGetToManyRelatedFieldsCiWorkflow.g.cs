
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow
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
    public static class CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow value)
        {
            return value switch
            {
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Actions => "actions",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.BranchStartCondition => "branchStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.BuildRuns => "buildRuns",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Clean => "clean",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ContainerFilePath => "containerFilePath",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Description => "description",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.IsEnabled => "isEnabled",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.IsLockedForEditing => "isLockedForEditing",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.LastModifiedDate => "lastModifiedDate",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.MacOsVersion => "macOsVersion",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ManualBranchStartCondition => "manualBranchStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ManualPullRequestStartCondition => "manualPullRequestStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ManualTagStartCondition => "manualTagStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Name => "name",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Product => "product",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.PullRequestStartCondition => "pullRequestStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Repository => "repository",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ScheduledStartCondition => "scheduledStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.TagStartCondition => "tagStartCondition",
                CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Actions,
                "branchStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.BranchStartCondition,
                "buildRuns" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.BuildRuns,
                "clean" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Clean,
                "containerFilePath" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ContainerFilePath,
                "description" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Description,
                "isEnabled" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.IsEnabled,
                "isLockedForEditing" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.IsLockedForEditing,
                "lastModifiedDate" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.LastModifiedDate,
                "macOsVersion" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.MacOsVersion,
                "manualBranchStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ManualBranchStartCondition,
                "manualPullRequestStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ManualPullRequestStartCondition,
                "manualTagStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ManualTagStartCondition,
                "name" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Name,
                "product" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Product,
                "pullRequestStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.PullRequestStartCondition,
                "repository" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.Repository,
                "scheduledStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.ScheduledStartCondition,
                "tagStartCondition" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.TagStartCondition,
                "xcodeVersion" => CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow.XcodeVersion,
                _ => null,
            };
        }
    }
}