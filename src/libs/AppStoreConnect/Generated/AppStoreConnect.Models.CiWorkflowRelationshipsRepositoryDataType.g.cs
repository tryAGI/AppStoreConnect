
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowRelationshipsRepositoryDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowRelationshipsRepositoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowRelationshipsRepositoryDataType value)
        {
            return value switch
            {
                CiWorkflowRelationshipsRepositoryDataType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowRelationshipsRepositoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmRepositories" => CiWorkflowRelationshipsRepositoryDataType.ScmRepositories,
                _ => null,
            };
        }
    }
}