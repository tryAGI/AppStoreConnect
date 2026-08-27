
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference
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
    public static class ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.Kind => "kind",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.Name => "name",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.IsDeleted,
                "kind" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.Kind,
                "name" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.Name,
                "repository" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}