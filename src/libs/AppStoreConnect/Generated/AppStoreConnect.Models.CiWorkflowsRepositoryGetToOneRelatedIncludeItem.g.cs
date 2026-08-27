
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowsRepositoryGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        DefaultBranch,
        /// <summary>
        /// 
        /// </summary>
        ScmProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsRepositoryGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsRepositoryGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                CiWorkflowsRepositoryGetToOneRelatedIncludeItem.DefaultBranch => "defaultBranch",
                CiWorkflowsRepositoryGetToOneRelatedIncludeItem.ScmProvider => "scmProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsRepositoryGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiWorkflowsRepositoryGetToOneRelatedIncludeItem.DefaultBranch,
                "scmProvider" => CiWorkflowsRepositoryGetToOneRelatedIncludeItem.ScmProvider,
                _ => null,
            };
        }
    }
}