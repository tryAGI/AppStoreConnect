
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductPrimaryRepositoriesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductPrimaryRepositoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductPrimaryRepositoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiProductPrimaryRepositoriesLinkagesResponseDataItemType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductPrimaryRepositoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => CiProductPrimaryRepositoriesLinkagesResponseDataItemType.ScmRepositories,
                _ => null,
            };
        }
    }
}