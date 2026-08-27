
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedIncludeItem
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
    public static class CiBuildActionsBuildRunGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedIncludeItem.Builds => "builds",
                CiBuildActionsBuildRunGetToOneRelatedIncludeItem.DestinationBranch => "destinationBranch",
                CiBuildActionsBuildRunGetToOneRelatedIncludeItem.Product => "product",
                CiBuildActionsBuildRunGetToOneRelatedIncludeItem.PullRequest => "pullRequest",
                CiBuildActionsBuildRunGetToOneRelatedIncludeItem.SourceBranchOrTag => "sourceBranchOrTag",
                CiBuildActionsBuildRunGetToOneRelatedIncludeItem.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiBuildActionsBuildRunGetToOneRelatedIncludeItem.Builds,
                "destinationBranch" => CiBuildActionsBuildRunGetToOneRelatedIncludeItem.DestinationBranch,
                "product" => CiBuildActionsBuildRunGetToOneRelatedIncludeItem.Product,
                "pullRequest" => CiBuildActionsBuildRunGetToOneRelatedIncludeItem.PullRequest,
                "sourceBranchOrTag" => CiBuildActionsBuildRunGetToOneRelatedIncludeItem.SourceBranchOrTag,
                "workflow" => CiBuildActionsBuildRunGetToOneRelatedIncludeItem.Workflow,
                _ => null,
            };
        }
    }
}