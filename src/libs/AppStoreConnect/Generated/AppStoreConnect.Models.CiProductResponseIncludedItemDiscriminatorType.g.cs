
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductResponseIncludedItemDiscriminatorType
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
    public static class CiProductResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CiProductResponseIncludedItemDiscriminatorType.Apps => "apps",
                CiProductResponseIncludedItemDiscriminatorType.BundleIds => "bundleIds",
                CiProductResponseIncludedItemDiscriminatorType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => CiProductResponseIncludedItemDiscriminatorType.Apps,
                "bundleIds" => CiProductResponseIncludedItemDiscriminatorType.BundleIds,
                "scmRepositories" => CiProductResponseIncludedItemDiscriminatorType.ScmRepositories,
                _ => null,
            };
        }
    }
}