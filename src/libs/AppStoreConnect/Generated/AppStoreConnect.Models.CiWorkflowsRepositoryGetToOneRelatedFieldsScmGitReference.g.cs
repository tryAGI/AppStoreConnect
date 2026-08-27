
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference
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
    public static class CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.Kind => "kind",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.Name => "name",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.IsDeleted,
                "kind" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.Kind,
                "name" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.Name,
                "repository" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}