
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow
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
    public static class CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Actions => "actions",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.BranchStartCondition => "branchStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.BuildRuns => "buildRuns",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Clean => "clean",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ContainerFilePath => "containerFilePath",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Description => "description",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsEnabled => "isEnabled",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsLockedForEditing => "isLockedForEditing",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.LastModifiedDate => "lastModifiedDate",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.MacOsVersion => "macOsVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualBranchStartCondition => "manualBranchStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualPullRequestStartCondition => "manualPullRequestStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualTagStartCondition => "manualTagStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Name => "name",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Product => "product",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.PullRequestStartCondition => "pullRequestStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Repository => "repository",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ScheduledStartCondition => "scheduledStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.TagStartCondition => "tagStartCondition",
                CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow? ToEnum(string value)
        {
            return value switch
            {
                "actions" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Actions,
                "branchStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.BranchStartCondition,
                "buildRuns" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.BuildRuns,
                "clean" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Clean,
                "containerFilePath" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ContainerFilePath,
                "description" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Description,
                "isEnabled" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsEnabled,
                "isLockedForEditing" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.IsLockedForEditing,
                "lastModifiedDate" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.LastModifiedDate,
                "macOsVersion" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.MacOsVersion,
                "manualBranchStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualBranchStartCondition,
                "manualPullRequestStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualPullRequestStartCondition,
                "manualTagStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ManualTagStartCondition,
                "name" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Name,
                "product" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Product,
                "pullRequestStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.PullRequestStartCondition,
                "repository" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.Repository,
                "scheduledStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.ScheduledStartCondition,
                "tagStartCondition" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.TagStartCondition,
                "xcodeVersion" => CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow.XcodeVersion,
                _ => null,
            };
        }
    }
}