
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductAdditionalRepositoriesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductAdditionalRepositoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductAdditionalRepositoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiProductAdditionalRepositoriesLinkagesResponseDataItemType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductAdditionalRepositoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => CiProductAdditionalRepositoriesLinkagesResponseDataItemType.ScmRepositories,
                _ => null,
            };
        }
    }
}