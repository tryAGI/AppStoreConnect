
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie
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
    public static class ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}