
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoryResponseIncludedItemDiscriminatorType
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
    public static class ScmRepositoryResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoryResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ScmRepositoryResponseIncludedItemDiscriminatorType.ScmGitReferences => "scmGitReferences",
                ScmRepositoryResponseIncludedItemDiscriminatorType.ScmProviders => "scmProviders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoryResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => ScmRepositoryResponseIncludedItemDiscriminatorType.ScmGitReferences,
                "scmProviders" => ScmRepositoryResponseIncludedItemDiscriminatorType.ScmProviders,
                _ => null,
            };
        }
    }
}