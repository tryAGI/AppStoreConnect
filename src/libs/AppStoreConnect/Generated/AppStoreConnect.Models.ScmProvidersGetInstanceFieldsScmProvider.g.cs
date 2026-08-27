
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmProvidersGetInstanceFieldsScmProvider
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
    public static class ScmProvidersGetInstanceFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProvidersGetInstanceFieldsScmProvider value)
        {
            return value switch
            {
                ScmProvidersGetInstanceFieldsScmProvider.Repositories => "repositories",
                ScmProvidersGetInstanceFieldsScmProvider.ScmProviderType => "scmProviderType",
                ScmProvidersGetInstanceFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProvidersGetInstanceFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => ScmProvidersGetInstanceFieldsScmProvider.Repositories,
                "scmProviderType" => ScmProvidersGetInstanceFieldsScmProvider.ScmProviderType,
                "url" => ScmProvidersGetInstanceFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}