
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetCollectionIncludeItem
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
    public static class ScmRepositoriesGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetCollectionIncludeItem value)
        {
            return value switch
            {
                ScmRepositoriesGetCollectionIncludeItem.DefaultBranch => "defaultBranch",
                ScmRepositoriesGetCollectionIncludeItem.ScmProvider => "scmProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmRepositoriesGetCollectionIncludeItem.DefaultBranch,
                "scmProvider" => ScmRepositoriesGetCollectionIncludeItem.ScmProvider,
                _ => null,
            };
        }
    }
}