
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetInstanceFieldsScmRepositorie
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
    public static class CiProductsGetInstanceFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetInstanceFieldsScmRepositorie value)
        {
            return value switch
            {
                CiProductsGetInstanceFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiProductsGetInstanceFieldsScmRepositorie.GitReferences => "gitReferences",
                CiProductsGetInstanceFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiProductsGetInstanceFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiProductsGetInstanceFieldsScmRepositorie.OwnerName => "ownerName",
                CiProductsGetInstanceFieldsScmRepositorie.PullRequests => "pullRequests",
                CiProductsGetInstanceFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiProductsGetInstanceFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiProductsGetInstanceFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetInstanceFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsGetInstanceFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiProductsGetInstanceFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiProductsGetInstanceFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiProductsGetInstanceFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiProductsGetInstanceFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiProductsGetInstanceFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiProductsGetInstanceFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiProductsGetInstanceFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiProductsGetInstanceFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}