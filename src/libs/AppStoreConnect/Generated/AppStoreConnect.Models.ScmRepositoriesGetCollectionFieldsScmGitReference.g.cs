
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetCollectionFieldsScmGitReference
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
    public static class ScmRepositoriesGetCollectionFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetCollectionFieldsScmGitReference value)
        {
            return value switch
            {
                ScmRepositoriesGetCollectionFieldsScmGitReference.CanonicalName => "canonicalName",
                ScmRepositoriesGetCollectionFieldsScmGitReference.IsDeleted => "isDeleted",
                ScmRepositoriesGetCollectionFieldsScmGitReference.Kind => "kind",
                ScmRepositoriesGetCollectionFieldsScmGitReference.Name => "name",
                ScmRepositoriesGetCollectionFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetCollectionFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => ScmRepositoriesGetCollectionFieldsScmGitReference.CanonicalName,
                "isDeleted" => ScmRepositoriesGetCollectionFieldsScmGitReference.IsDeleted,
                "kind" => ScmRepositoriesGetCollectionFieldsScmGitReference.Kind,
                "name" => ScmRepositoriesGetCollectionFieldsScmGitReference.Name,
                "repository" => ScmRepositoriesGetCollectionFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}