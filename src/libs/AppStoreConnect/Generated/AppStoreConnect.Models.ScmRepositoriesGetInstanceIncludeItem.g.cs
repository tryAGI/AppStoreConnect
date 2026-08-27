
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetInstanceIncludeItem
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
    public static class ScmRepositoriesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetInstanceIncludeItem value)
        {
            return value switch
            {
                ScmRepositoriesGetInstanceIncludeItem.DefaultBranch => "defaultBranch",
                ScmRepositoriesGetInstanceIncludeItem.ScmProvider => "scmProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmRepositoriesGetInstanceIncludeItem.DefaultBranch,
                "scmProvider" => ScmRepositoriesGetInstanceIncludeItem.ScmProvider,
                _ => null,
            };
        }
    }
}