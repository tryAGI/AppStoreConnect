
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunCreateRequestDataRelationshipsPullRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        ScmPullRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunCreateRequestDataRelationshipsPullRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunCreateRequestDataRelationshipsPullRequestDataType value)
        {
            return value switch
            {
                CiBuildRunCreateRequestDataRelationshipsPullRequestDataType.ScmPullRequests => "scmPullRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunCreateRequestDataRelationshipsPullRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmPullRequests" => CiBuildRunCreateRequestDataRelationshipsPullRequestDataType.ScmPullRequests,
                _ => null,
            };
        }
    }
}