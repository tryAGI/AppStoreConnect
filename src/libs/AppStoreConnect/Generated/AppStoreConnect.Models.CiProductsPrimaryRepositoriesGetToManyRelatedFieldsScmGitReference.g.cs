
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference
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
    public static class CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.Kind => "kind",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.Name => "name",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.IsDeleted,
                "kind" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.Kind,
                "name" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.Name,
                "repository" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}