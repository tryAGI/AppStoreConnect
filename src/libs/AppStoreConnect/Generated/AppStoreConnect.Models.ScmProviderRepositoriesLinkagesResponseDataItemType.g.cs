
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmProviderRepositoriesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmProviderRepositoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProviderRepositoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                ScmProviderRepositoriesLinkagesResponseDataItemType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProviderRepositoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => ScmProviderRepositoriesLinkagesResponseDataItemType.ScmRepositories,
                _ => null,
            };
        }
    }
}