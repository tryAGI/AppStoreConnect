
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmGitReferencesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmGitReferencesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmGitReferencesGetInstanceIncludeItem value)
        {
            return value switch
            {
                ScmGitReferencesGetInstanceIncludeItem.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmGitReferencesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repository" => ScmGitReferencesGetInstanceIncludeItem.Repository,
                _ => null,
            };
        }
    }
}