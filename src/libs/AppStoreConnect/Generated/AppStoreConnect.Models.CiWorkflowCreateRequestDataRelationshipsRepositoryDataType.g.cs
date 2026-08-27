
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowCreateRequestDataRelationshipsRepositoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowCreateRequestDataRelationshipsRepositoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowCreateRequestDataRelationshipsRepositoryDataType value)
        {
            return value switch
            {
                CiWorkflowCreateRequestDataRelationshipsRepositoryDataType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowCreateRequestDataRelationshipsRepositoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => CiWorkflowCreateRequestDataRelationshipsRepositoryDataType.ScmRepositories,
                _ => null,
            };
        }
    }
}