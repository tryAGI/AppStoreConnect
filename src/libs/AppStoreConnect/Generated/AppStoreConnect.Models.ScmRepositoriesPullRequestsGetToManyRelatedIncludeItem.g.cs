
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesPullRequestsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoriesPullRequestsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesPullRequestsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                ScmRepositoriesPullRequestsGetToManyRelatedIncludeItem.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesPullRequestsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repository" => ScmRepositoriesPullRequestsGetToManyRelatedIncludeItem.Repository,
                _ => null,
            };
        }
    }
}