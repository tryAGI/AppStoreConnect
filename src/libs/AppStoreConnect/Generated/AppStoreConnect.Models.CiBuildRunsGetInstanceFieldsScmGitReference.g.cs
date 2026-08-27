
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsGetInstanceFieldsScmGitReference
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
    public static class CiBuildRunsGetInstanceFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceFieldsScmGitReference value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceFieldsScmGitReference.CanonicalName => "canonicalName",
                CiBuildRunsGetInstanceFieldsScmGitReference.IsDeleted => "isDeleted",
                CiBuildRunsGetInstanceFieldsScmGitReference.Kind => "kind",
                CiBuildRunsGetInstanceFieldsScmGitReference.Name => "name",
                CiBuildRunsGetInstanceFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiBuildRunsGetInstanceFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiBuildRunsGetInstanceFieldsScmGitReference.IsDeleted,
                "kind" => CiBuildRunsGetInstanceFieldsScmGitReference.Kind,
                "name" => CiBuildRunsGetInstanceFieldsScmGitReference.Name,
                "repository" => CiBuildRunsGetInstanceFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}