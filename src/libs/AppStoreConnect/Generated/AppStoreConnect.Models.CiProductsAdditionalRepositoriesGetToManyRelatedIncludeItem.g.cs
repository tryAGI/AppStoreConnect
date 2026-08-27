
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        DefaultBranch,
        /// <summary>
        /// 
        /// </summary>
        ScmProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem.DefaultBranch => "defaultBranch",
                CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem.ScmProvider => "scmProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem.DefaultBranch,
                "scmProvider" => CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem.ScmProvider,
                _ => null,
            };
        }
    }
}