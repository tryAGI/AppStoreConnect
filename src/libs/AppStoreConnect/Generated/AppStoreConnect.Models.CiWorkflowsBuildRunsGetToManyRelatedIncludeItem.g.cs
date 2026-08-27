
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
        /// <summary>
        ///
        /// </summary>
        DestinationBranch,
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
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsBuildRunsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.Builds => "builds",
                CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.DestinationBranch => "destinationBranch",
                CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.Product => "product",
                CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.PullRequest => "pullRequest",
                CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.SourceBranchOrTag => "sourceBranchOrTag",
                CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.Builds,
                "destinationBranch" => CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.DestinationBranch,
                "product" => CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.Product,
                "pullRequest" => CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.PullRequest,
                "sourceBranchOrTag" => CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.SourceBranchOrTag,
                "workflow" => CiWorkflowsBuildRunsGetToManyRelatedIncludeItem.Workflow,
                _ => null,
            };
        }
    }
}