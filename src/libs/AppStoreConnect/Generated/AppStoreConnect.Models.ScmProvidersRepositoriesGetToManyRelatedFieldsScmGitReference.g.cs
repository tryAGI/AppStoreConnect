
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference
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
    public static class ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.Kind => "kind",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.Name => "name",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.IsDeleted,
                "kind" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.Kind,
                "name" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.Name,
                "repository" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}