
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowRepositoryLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowRepositoryLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowRepositoryLinkageResponseDataType value)
        {
            return value switch
            {
                CiWorkflowRepositoryLinkageResponseDataType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowRepositoryLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => CiWorkflowRepositoryLinkageResponseDataType.ScmRepositories,
                _ => null,
            };
        }
    }
}