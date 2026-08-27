
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider
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
    public static class CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider value)
        {
            return value switch
            {
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider.Repositories => "repositories",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider.ScmProviderType => "scmProviderType",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider.Repositories,
                "scmProviderType" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider.ScmProviderType,
                "url" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}