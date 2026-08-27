
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedIncludeItem
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
    public static class CiProductsBuildRunsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedIncludeItem.Builds => "builds",
                CiProductsBuildRunsGetToManyRelatedIncludeItem.DestinationBranch => "destinationBranch",
                CiProductsBuildRunsGetToManyRelatedIncludeItem.Product => "product",
                CiProductsBuildRunsGetToManyRelatedIncludeItem.PullRequest => "pullRequest",
                CiProductsBuildRunsGetToManyRelatedIncludeItem.SourceBranchOrTag => "sourceBranchOrTag",
                CiProductsBuildRunsGetToManyRelatedIncludeItem.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiProductsBuildRunsGetToManyRelatedIncludeItem.Builds,
                "destinationBranch" => CiProductsBuildRunsGetToManyRelatedIncludeItem.DestinationBranch,
                "product" => CiProductsBuildRunsGetToManyRelatedIncludeItem.Product,
                "pullRequest" => CiProductsBuildRunsGetToManyRelatedIncludeItem.PullRequest,
                "sourceBranchOrTag" => CiProductsBuildRunsGetToManyRelatedIncludeItem.SourceBranchOrTag,
                "workflow" => CiProductsBuildRunsGetToManyRelatedIncludeItem.Workflow,
                _ => null,
            };
        }
    }
}