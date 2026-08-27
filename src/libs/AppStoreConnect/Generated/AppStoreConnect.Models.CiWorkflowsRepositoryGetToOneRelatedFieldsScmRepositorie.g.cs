
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie
    {
        /// <summary>
        ///
        /// </summary>
        DefaultBranch,
        /// <summary>
        ///
        /// </summary>
        GitReferences,
        /// <summary>
        ///
        /// </summary>
        HttpCloneUrl,
        /// <summary>
        ///
        /// </summary>
        LastAccessedDate,
        /// <summary>
        ///
        /// </summary>
        OwnerName,
        /// <summary>
        ///
        /// </summary>
        PullRequests,
        /// <summary>
        ///
        /// </summary>
        RepositoryName,
        /// <summary>
        ///
        /// </summary>
        ScmProvider,
        /// <summary>
        ///
        /// </summary>
        SshCloneUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}