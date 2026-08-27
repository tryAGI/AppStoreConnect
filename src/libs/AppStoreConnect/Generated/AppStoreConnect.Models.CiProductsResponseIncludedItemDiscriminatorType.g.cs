
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        BundleIds,
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CiProductsResponseIncludedItemDiscriminatorType.Apps => "apps",
                CiProductsResponseIncludedItemDiscriminatorType.BundleIds => "bundleIds",
                CiProductsResponseIncludedItemDiscriminatorType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => CiProductsResponseIncludedItemDiscriminatorType.Apps,
                "bundleIds" => CiProductsResponseIncludedItemDiscriminatorType.BundleIds,
                "scmRepositories" => CiProductsResponseIncludedItemDiscriminatorType.ScmRepositories,
                _ => null,
            };
        }
    }
}