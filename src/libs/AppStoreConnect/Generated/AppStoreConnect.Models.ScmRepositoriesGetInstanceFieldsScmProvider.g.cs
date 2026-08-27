
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetInstanceFieldsScmProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Repositories,
        /// <summary>
        /// 
        /// </summary>
        ScmProviderType,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoriesGetInstanceFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetInstanceFieldsScmProvider value)
        {
            return value switch
            {
                ScmRepositoriesGetInstanceFieldsScmProvider.Repositories => "repositories",
                ScmRepositoriesGetInstanceFieldsScmProvider.ScmProviderType => "scmProviderType",
                ScmRepositoriesGetInstanceFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetInstanceFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => ScmRepositoriesGetInstanceFieldsScmProvider.Repositories,
                "scmProviderType" => ScmRepositoriesGetInstanceFieldsScmProvider.ScmProviderType,
                "url" => ScmRepositoriesGetInstanceFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}