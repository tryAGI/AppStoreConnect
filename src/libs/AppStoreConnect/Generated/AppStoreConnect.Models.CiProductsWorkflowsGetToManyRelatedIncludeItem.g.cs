
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsWorkflowsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        MacOsVersion,
        /// <summary>
        /// 
        /// </summary>
        Product,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        XcodeVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsWorkflowsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsWorkflowsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiProductsWorkflowsGetToManyRelatedIncludeItem.MacOsVersion => "macOsVersion",
                CiProductsWorkflowsGetToManyRelatedIncludeItem.Product => "product",
                CiProductsWorkflowsGetToManyRelatedIncludeItem.Repository => "repository",
                CiProductsWorkflowsGetToManyRelatedIncludeItem.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsWorkflowsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersion" => CiProductsWorkflowsGetToManyRelatedIncludeItem.MacOsVersion,
                "product" => CiProductsWorkflowsGetToManyRelatedIncludeItem.Product,
                "repository" => CiProductsWorkflowsGetToManyRelatedIncludeItem.Repository,
                "xcodeVersion" => CiProductsWorkflowsGetToManyRelatedIncludeItem.XcodeVersion,
                _ => null,
            };
        }
    }
}