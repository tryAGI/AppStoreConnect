
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie
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
    public static class CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}