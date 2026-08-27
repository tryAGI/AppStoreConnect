
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmGitReferencesGetInstanceFieldsScmGitReference
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
    public static class ScmGitReferencesGetInstanceFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmGitReferencesGetInstanceFieldsScmGitReference value)
        {
            return value switch
            {
                ScmGitReferencesGetInstanceFieldsScmGitReference.CanonicalName => "canonicalName",
                ScmGitReferencesGetInstanceFieldsScmGitReference.IsDeleted => "isDeleted",
                ScmGitReferencesGetInstanceFieldsScmGitReference.Kind => "kind",
                ScmGitReferencesGetInstanceFieldsScmGitReference.Name => "name",
                ScmGitReferencesGetInstanceFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmGitReferencesGetInstanceFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => ScmGitReferencesGetInstanceFieldsScmGitReference.CanonicalName,
                "isDeleted" => ScmGitReferencesGetInstanceFieldsScmGitReference.IsDeleted,
                "kind" => ScmGitReferencesGetInstanceFieldsScmGitReference.Kind,
                "name" => ScmGitReferencesGetInstanceFieldsScmGitReference.Name,
                "repository" => ScmGitReferencesGetInstanceFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}