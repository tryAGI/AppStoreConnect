
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetCollectionFieldsScmRepositorie
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
    public static class ScmRepositoriesGetCollectionFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetCollectionFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmRepositoriesGetCollectionFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.OwnerName => "ownerName",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmRepositoriesGetCollectionFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetCollectionFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmRepositoriesGetCollectionFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmRepositoriesGetCollectionFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmRepositoriesGetCollectionFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmRepositoriesGetCollectionFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmRepositoriesGetCollectionFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmRepositoriesGetCollectionFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmRepositoriesGetCollectionFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmRepositoriesGetCollectionFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmRepositoriesGetCollectionFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}