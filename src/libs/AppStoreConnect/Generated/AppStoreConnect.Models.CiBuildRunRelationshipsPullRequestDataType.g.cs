
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunRelationshipsPullRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        ScmPullRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunRelationshipsPullRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunRelationshipsPullRequestDataType value)
        {
            return value switch
            {
                CiBuildRunRelationshipsPullRequestDataType.ScmPullRequests => "scmPullRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunRelationshipsPullRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmPullRequests" => CiBuildRunRelationshipsPullRequestDataType.ScmPullRequests,
                _ => null,
            };
        }
    }
}