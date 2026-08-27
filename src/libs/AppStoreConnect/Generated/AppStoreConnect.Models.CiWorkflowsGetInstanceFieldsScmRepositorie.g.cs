
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowsGetInstanceFieldsScmRepositorie
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
    public static class CiWorkflowsGetInstanceFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsGetInstanceFieldsScmRepositorie value)
        {
            return value switch
            {
                CiWorkflowsGetInstanceFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiWorkflowsGetInstanceFieldsScmRepositorie.GitReferences => "gitReferences",
                CiWorkflowsGetInstanceFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiWorkflowsGetInstanceFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiWorkflowsGetInstanceFieldsScmRepositorie.OwnerName => "ownerName",
                CiWorkflowsGetInstanceFieldsScmRepositorie.PullRequests => "pullRequests",
                CiWorkflowsGetInstanceFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiWorkflowsGetInstanceFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiWorkflowsGetInstanceFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsGetInstanceFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiWorkflowsGetInstanceFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiWorkflowsGetInstanceFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiWorkflowsGetInstanceFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiWorkflowsGetInstanceFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiWorkflowsGetInstanceFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiWorkflowsGetInstanceFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiWorkflowsGetInstanceFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiWorkflowsGetInstanceFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiWorkflowsGetInstanceFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}