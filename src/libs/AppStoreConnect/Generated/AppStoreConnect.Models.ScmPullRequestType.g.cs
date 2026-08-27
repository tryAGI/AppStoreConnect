
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmPullRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmPullRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmPullRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmPullRequestType value)
        {
            return value switch
            {
                ScmPullRequestType.ScmPullRequests => "scmPullRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmPullRequestType? ToEnum(string value)
        {
            return value switch
            {
                "scmPullRequests" => ScmPullRequestType.ScmPullRequests,
                _ => null,
            };
        }
    }
}