
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider
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
    public static class ScmProvidersRepositoriesGetToManyRelatedFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider value)
        {
            return value switch
            {
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider.Repositories => "repositories",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider.ScmProviderType => "scmProviderType",
                ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider.Repositories,
                "scmProviderType" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider.ScmProviderType,
                "url" => ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}