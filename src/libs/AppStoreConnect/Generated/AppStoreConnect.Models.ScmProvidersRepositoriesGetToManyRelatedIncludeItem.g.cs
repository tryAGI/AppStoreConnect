
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmProvidersRepositoriesGetToManyRelatedIncludeItem
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
    public static class ScmProvidersRepositoriesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProvidersRepositoriesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                ScmProvidersRepositoriesGetToManyRelatedIncludeItem.DefaultBranch => "defaultBranch",
                ScmProvidersRepositoriesGetToManyRelatedIncludeItem.ScmProvider => "scmProvider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProvidersRepositoriesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "defaultBranch" => ScmProvidersRepositoriesGetToManyRelatedIncludeItem.DefaultBranch,
                "scmProvider" => ScmProvidersRepositoriesGetToManyRelatedIncludeItem.ScmProvider,
                _ => null,
            };
        }
    }
}