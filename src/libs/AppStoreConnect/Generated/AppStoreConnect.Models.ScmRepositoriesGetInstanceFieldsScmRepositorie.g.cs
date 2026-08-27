
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoriesGetInstanceFieldsScmRepositorie
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
    public static class ScmRepositoriesGetInstanceFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetInstanceFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmRepositoriesGetInstanceFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.OwnerName => "ownerName",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmRepositoriesGetInstanceFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetInstanceFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmRepositoriesGetInstanceFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmRepositoriesGetInstanceFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmRepositoriesGetInstanceFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmRepositoriesGetInstanceFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmRepositoriesGetInstanceFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmRepositoriesGetInstanceFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmRepositoriesGetInstanceFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmRepositoriesGetInstanceFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmRepositoriesGetInstanceFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}