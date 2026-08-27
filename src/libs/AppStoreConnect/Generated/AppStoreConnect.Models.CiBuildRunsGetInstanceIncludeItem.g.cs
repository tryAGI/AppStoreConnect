
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsGetInstanceIncludeItem
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
    public static class CiBuildRunsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceIncludeItem.Builds => "builds",
                CiBuildRunsGetInstanceIncludeItem.DestinationBranch => "destinationBranch",
                CiBuildRunsGetInstanceIncludeItem.Product => "product",
                CiBuildRunsGetInstanceIncludeItem.PullRequest => "pullRequest",
                CiBuildRunsGetInstanceIncludeItem.SourceBranchOrTag => "sourceBranchOrTag",
                CiBuildRunsGetInstanceIncludeItem.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiBuildRunsGetInstanceIncludeItem.Builds,
                "destinationBranch" => CiBuildRunsGetInstanceIncludeItem.DestinationBranch,
                "product" => CiBuildRunsGetInstanceIncludeItem.Product,
                "pullRequest" => CiBuildRunsGetInstanceIncludeItem.PullRequest,
                "sourceBranchOrTag" => CiBuildRunsGetInstanceIncludeItem.SourceBranchOrTag,
                "workflow" => CiBuildRunsGetInstanceIncludeItem.Workflow,
                _ => null,
            };
        }
    }
}