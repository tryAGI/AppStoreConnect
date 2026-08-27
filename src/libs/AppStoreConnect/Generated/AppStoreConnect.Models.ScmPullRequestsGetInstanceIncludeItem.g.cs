
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmPullRequestsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmPullRequestsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmPullRequestsGetInstanceIncludeItem value)
        {
            return value switch
            {
                ScmPullRequestsGetInstanceIncludeItem.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmPullRequestsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "repository" => ScmPullRequestsGetInstanceIncludeItem.Repository,
                _ => null,
            };
        }
    }
}