
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference
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
    public static class CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.Kind => "kind",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.Name => "name",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.IsDeleted,
                "kind" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.Kind,
                "name" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.Name,
                "repository" => CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}