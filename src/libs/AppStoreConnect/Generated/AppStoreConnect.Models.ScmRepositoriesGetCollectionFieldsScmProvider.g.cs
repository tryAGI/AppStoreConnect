
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesGetCollectionFieldsScmProvider
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
    public static class ScmRepositoriesGetCollectionFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesGetCollectionFieldsScmProvider value)
        {
            return value switch
            {
                ScmRepositoriesGetCollectionFieldsScmProvider.Repositories => "repositories",
                ScmRepositoriesGetCollectionFieldsScmProvider.ScmProviderType => "scmProviderType",
                ScmRepositoriesGetCollectionFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesGetCollectionFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => ScmRepositoriesGetCollectionFieldsScmProvider.Repositories,
                "scmProviderType" => ScmRepositoriesGetCollectionFieldsScmProvider.ScmProviderType,
                "url" => ScmRepositoriesGetCollectionFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}