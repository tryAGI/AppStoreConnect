
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie
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
    public static class CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}