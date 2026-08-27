
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsGetCollectionFieldsScmRepositorie
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
    public static class CiProductsGetCollectionFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetCollectionFieldsScmRepositorie value)
        {
            return value switch
            {
                CiProductsGetCollectionFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiProductsGetCollectionFieldsScmRepositorie.GitReferences => "gitReferences",
                CiProductsGetCollectionFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiProductsGetCollectionFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiProductsGetCollectionFieldsScmRepositorie.OwnerName => "ownerName",
                CiProductsGetCollectionFieldsScmRepositorie.PullRequests => "pullRequests",
                CiProductsGetCollectionFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiProductsGetCollectionFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiProductsGetCollectionFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetCollectionFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsGetCollectionFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiProductsGetCollectionFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiProductsGetCollectionFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiProductsGetCollectionFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiProductsGetCollectionFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiProductsGetCollectionFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiProductsGetCollectionFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiProductsGetCollectionFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiProductsGetCollectionFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}