
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmProviderTypeKind
    {
        /// <summary>
        /// 
        /// </summary>
        BitbucketCloud,
        /// <summary>
        /// 
        /// </summary>
        BitbucketServer,
        /// <summary>
        /// 
        /// </summary>
        GithubCloud,
        /// <summary>
        /// 
        /// </summary>
        GithubEnterprise,
        /// <summary>
        /// 
        /// </summary>
        GitlabCloud,
        /// <summary>
        /// 
        /// </summary>
        GitlabSelfManaged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmProviderTypeKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProviderTypeKind value)
        {
            return value switch
            {
                ScmProviderTypeKind.BitbucketCloud => "BITBUCKET_CLOUD",
                ScmProviderTypeKind.BitbucketServer => "BITBUCKET_SERVER",
                ScmProviderTypeKind.GithubCloud => "GITHUB_CLOUD",
                ScmProviderTypeKind.GithubEnterprise => "GITHUB_ENTERPRISE",
                ScmProviderTypeKind.GitlabCloud => "GITLAB_CLOUD",
                ScmProviderTypeKind.GitlabSelfManaged => "GITLAB_SELF_MANAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProviderTypeKind? ToEnum(string value)
        {
            return value switch
            {
                "BITBUCKET_CLOUD" => ScmProviderTypeKind.BitbucketCloud,
                "BITBUCKET_SERVER" => ScmProviderTypeKind.BitbucketServer,
                "GITHUB_CLOUD" => ScmProviderTypeKind.GithubCloud,
                "GITHUB_ENTERPRISE" => ScmProviderTypeKind.GithubEnterprise,
                "GITLAB_CLOUD" => ScmProviderTypeKind.GitlabCloud,
                "GITLAB_SELF_MANAGED" => ScmProviderTypeKind.GitlabSelfManaged,
                _ => null,
            };
        }
    }
}