
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie
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
    public static class CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}