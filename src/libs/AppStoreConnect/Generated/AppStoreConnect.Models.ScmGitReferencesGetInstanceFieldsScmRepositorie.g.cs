
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmGitReferencesGetInstanceFieldsScmRepositorie
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
    public static class ScmGitReferencesGetInstanceFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmGitReferencesGetInstanceFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmGitReferencesGetInstanceFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.OwnerName => "ownerName",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmGitReferencesGetInstanceFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmGitReferencesGetInstanceFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmGitReferencesGetInstanceFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmGitReferencesGetInstanceFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmGitReferencesGetInstanceFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmGitReferencesGetInstanceFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmGitReferencesGetInstanceFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmGitReferencesGetInstanceFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmGitReferencesGetInstanceFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmGitReferencesGetInstanceFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmGitReferencesGetInstanceFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}