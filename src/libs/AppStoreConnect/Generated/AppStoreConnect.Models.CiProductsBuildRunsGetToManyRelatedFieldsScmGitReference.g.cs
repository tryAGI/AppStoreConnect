
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference
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
    public static class CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.Kind => "kind",
                CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.Name => "name",
                CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.IsDeleted,
                "kind" => CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.Kind,
                "name" => CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.Name,
                "repository" => CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}