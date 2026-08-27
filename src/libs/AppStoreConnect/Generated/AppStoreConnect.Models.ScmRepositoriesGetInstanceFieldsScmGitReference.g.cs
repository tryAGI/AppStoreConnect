
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetInstanceFieldsScmGitReference
    {
        /// <summary>
        /// 
        /// </summary>
        CanonicalName,
        /// <summary>
        /// 
        /// </summary>
        IsDeleted,
        /// <summary>
        /// 
        /// </summary>
        Kind,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoriesGetInstanceFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetInstanceFieldsScmGitReference value)
        {
            return value switch
            {
                ScmRepositoriesGetInstanceFieldsScmGitReference.CanonicalName => "canonicalName",
                ScmRepositoriesGetInstanceFieldsScmGitReference.IsDeleted => "isDeleted",
                ScmRepositoriesGetInstanceFieldsScmGitReference.Kind => "kind",
                ScmRepositoriesGetInstanceFieldsScmGitReference.Name => "name",
                ScmRepositoriesGetInstanceFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetInstanceFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => ScmRepositoriesGetInstanceFieldsScmGitReference.CanonicalName,
                "isDeleted" => ScmRepositoriesGetInstanceFieldsScmGitReference.IsDeleted,
                "kind" => ScmRepositoriesGetInstanceFieldsScmGitReference.Kind,
                "name" => ScmRepositoriesGetInstanceFieldsScmGitReference.Name,
                "repository" => ScmRepositoriesGetInstanceFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}