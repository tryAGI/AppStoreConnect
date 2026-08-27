
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmProvidersGetCollectionFieldsScmProvider
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
    public static class ScmProvidersGetCollectionFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProvidersGetCollectionFieldsScmProvider value)
        {
            return value switch
            {
                ScmProvidersGetCollectionFieldsScmProvider.Repositories => "repositories",
                ScmProvidersGetCollectionFieldsScmProvider.ScmProviderType => "scmProviderType",
                ScmProvidersGetCollectionFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProvidersGetCollectionFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => ScmProvidersGetCollectionFieldsScmProvider.Repositories,
                "scmProviderType" => ScmProvidersGetCollectionFieldsScmProvider.ScmProviderType,
                "url" => ScmProvidersGetCollectionFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}