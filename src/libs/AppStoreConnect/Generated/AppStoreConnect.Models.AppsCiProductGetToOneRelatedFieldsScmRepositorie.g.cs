
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsCiProductGetToOneRelatedFieldsScmRepositorie
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
    public static class AppsCiProductGetToOneRelatedFieldsScmRepositorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCiProductGetToOneRelatedFieldsScmRepositorie value)
        {
            return value switch
            {
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.DefaultBranch => "defaultBranch",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.GitReferences => "gitReferences",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.HttpCloneUrl => "httpCloneUrl",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.LastAccessedDate => "lastAccessedDate",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.OwnerName => "ownerName",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.PullRequests => "pullRequests",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.RepositoryName => "repositoryName",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.ScmProvider => "scmProvider",
                AppsCiProductGetToOneRelatedFieldsScmRepositorie.SshCloneUrl => "sshCloneUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCiProductGetToOneRelatedFieldsScmRepositorie? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.DefaultBranch,
                "gitReferences" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.GitReferences,
                "httpCloneUrl" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.HttpCloneUrl,
                "lastAccessedDate" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.LastAccessedDate,
                "ownerName" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.OwnerName,
                "pullRequests" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.PullRequests,
                "repositoryName" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.RepositoryName,
                "scmProvider" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.ScmProvider,
                "sshCloneUrl" => AppsCiProductGetToOneRelatedFieldsScmRepositorie.SshCloneUrl,
                _ => null,
            };
        }
    }
}