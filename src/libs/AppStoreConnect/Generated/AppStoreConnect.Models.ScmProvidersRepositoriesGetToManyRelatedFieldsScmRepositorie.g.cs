
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie
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
    public static class ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}