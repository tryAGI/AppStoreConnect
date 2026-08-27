
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow
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
    public static class CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Actions => "actions",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.BranchStartCondition => "branchStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.BuildRuns => "buildRuns",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Clean => "clean",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ContainerFilePath => "containerFilePath",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Description => "description",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.IsEnabled => "isEnabled",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.IsLockedForEditing => "isLockedForEditing",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.LastModifiedDate => "lastModifiedDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.MacOsVersion => "macOsVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ManualBranchStartCondition => "manualBranchStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ManualPullRequestStartCondition => "manualPullRequestStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ManualTagStartCondition => "manualTagStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Name => "name",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Product => "product",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.PullRequestStartCondition => "pullRequestStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Repository => "repository",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ScheduledStartCondition => "scheduledStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.TagStartCondition => "tagStartCondition",
                CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Actions,
                "branchStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.BranchStartCondition,
                "buildRuns" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.BuildRuns,
                "clean" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Clean,
                "containerFilePath" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ContainerFilePath,
                "description" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Description,
                "isEnabled" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.IsEnabled,
                "isLockedForEditing" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.IsLockedForEditing,
                "lastModifiedDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.LastModifiedDate,
                "macOsVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.MacOsVersion,
                "manualBranchStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ManualBranchStartCondition,
                "manualPullRequestStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ManualPullRequestStartCondition,
                "manualTagStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ManualTagStartCondition,
                "name" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Name,
                "product" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Product,
                "pullRequestStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.PullRequestStartCondition,
                "repository" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.Repository,
                "scheduledStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.ScheduledStartCondition,
                "tagStartCondition" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.TagStartCondition,
                "xcodeVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow.XcodeVersion,
                _ => null,
            };
        }
    }
}