
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmPullRequestsGetInstanceFieldsScmRepositorie
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
    public static class ScmPullRequestsGetInstanceFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmPullRequestsGetInstanceFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmPullRequestsGetInstanceFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.OwnerName => "ownerName",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmPullRequestsGetInstanceFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmPullRequestsGetInstanceFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmPullRequestsGetInstanceFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmPullRequestsGetInstanceFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmPullRequestsGetInstanceFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmPullRequestsGetInstanceFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmPullRequestsGetInstanceFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmPullRequestsGetInstanceFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmPullRequestsGetInstanceFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmPullRequestsGetInstanceFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmPullRequestsGetInstanceFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}