
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider
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
    public static class CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider value)
        {
            return value switch
            {
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider.Repositories => "repositories",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider.ScmProviderType => "scmProviderType",
                CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider.Repositories,
                "scmProviderType" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider.ScmProviderType,
                "url" => CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}