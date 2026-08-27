
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem
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
    public static class CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem.DefaultBranch => "defaultBranch",
                CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem.ScmProvider => "scmProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem.DefaultBranch,
                "scmProvider" => CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem.ScmProvider,
                _ => null,
            };
        }
    }
}