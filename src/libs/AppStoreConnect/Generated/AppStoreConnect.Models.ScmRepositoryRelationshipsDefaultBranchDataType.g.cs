
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoryRelationshipsDefaultBranchDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmGitReferences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoryRelationshipsDefaultBranchDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoryRelationshipsDefaultBranchDataType value)
        {
            return value switch
            {
                ScmRepositoryRelationshipsDefaultBranchDataType.ScmGitReferences => "scmGitReferences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoryRelationshipsDefaultBranchDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => ScmRepositoryRelationshipsDefaultBranchDataType.ScmGitReferences,
                _ => null,
            };
        }
    }
}