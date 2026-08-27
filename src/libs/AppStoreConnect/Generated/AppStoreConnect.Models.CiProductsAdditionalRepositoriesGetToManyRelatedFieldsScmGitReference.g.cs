
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference
    {
        /// <summary>
        /// 
        /// </summary>
        CanonicalName,
        /// <summary>
        /// 
        /// </summary>
        IsDeleted,
        /// <summary>
        /// 
        /// </summary>
        Kind,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.Kind => "kind",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.Name => "name",
                CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.IsDeleted,
                "kind" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.Kind,
                "name" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.Name,
                "repository" => CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}