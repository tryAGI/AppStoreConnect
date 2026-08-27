
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie
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
    public static class ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmRepositoriesPullRequestsGetToManyRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}