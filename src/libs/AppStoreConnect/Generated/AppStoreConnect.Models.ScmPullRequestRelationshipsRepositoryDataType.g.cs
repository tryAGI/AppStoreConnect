
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmPullRequestRelationshipsRepositoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmPullRequestRelationshipsRepositoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmPullRequestRelationshipsRepositoryDataType value)
        {
            return value switch
            {
                ScmPullRequestRelationshipsRepositoryDataType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmPullRequestRelationshipsRepositoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => ScmPullRequestRelationshipsRepositoryDataType.ScmRepositories,
                _ => null,
            };
        }
    }
}