
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoriesGitReferencesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repository" => ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem.Repository,
                _ => null,
            };
        }
    }
}