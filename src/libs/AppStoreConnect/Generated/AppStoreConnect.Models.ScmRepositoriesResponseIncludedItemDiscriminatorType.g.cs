
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoriesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmGitReferences,
        /// <summary>
        /// 
        /// </summary>
        ScmProviders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoriesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoriesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ScmRepositoriesResponseIncludedItemDiscriminatorType.ScmGitReferences => "scmGitReferences",
                ScmRepositoriesResponseIncludedItemDiscriminatorType.ScmProviders => "scmProviders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoriesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => ScmRepositoriesResponseIncludedItemDiscriminatorType.ScmGitReferences,
                "scmProviders" => ScmRepositoriesResponseIncludedItemDiscriminatorType.ScmProviders,
                _ => null,
            };
        }
    }
}